using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FoodShop
{
    class Datahelper
    {
        public MySqlConnection connection;

        public Datahelper()
        {
            string connectionInfo = "server=studmysql01.fhict.local;" +
                               "database=dbi416657;" +
                               "user id=dbi416657;" +
                               "password=hera.fhict;" +
                               "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }
        public string GetUserFirstNameWithRfid(string user_rfid)
        {
            try
            {
                string name = "";
                string sql = $@"SELECT first_name FROM user where RFID = '{user_rfid}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    name = reader[0].ToString();
                }
                if (name != "")
                {
                    reader.Close();
                    return name;
                }
                else
                {
                    reader.Close();
                    return "";
                }
            }
            catch
            {
                return "error";
            }
            finally
            {
                connection.Close();
            }
        }
        public int GetPrdouctPrice(String product_name)
        {

            int price = 0;

            try
            {
                string sql = $@"SELECT PriceForProduct FROM shopitems WHERE ProductName = '{product_name}' ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                reader.Read();
                price = int.Parse(reader[0].ToString());
                
                return price;
            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
        public int GetBoughtQuantity(String product_name)
        {

            int Quantity = 0;

            try
            {
                string sql = $@"SELECT StockQuantity FROM `shop_has_items` where ProductName='{product_name}' ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                reader.Read();
                Quantity = int.Parse(reader[0].ToString());

                return Quantity;
            }
            catch
            {
                return 0;

            }
            finally
            {
                connection.Close();
            }
        }

        public string SellItemToVisitor(string user_rfid, List<string> items, int spentMoney)
        {
            try
            {
                int purchaseNo = 0;
                int userId = 0;
                string sql = $@"SELECT idUser FROM user where RFID = '{user_rfid}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    userId = int.Parse(reader[0].ToString());
                }
                reader.Close();
                if (userId != -1)
                {
                    int currentUserBalance = 0;
                    sql = $@"SELECT balance FROM eventacc WHERE User_userID= '{userId}' ;; ";
                    command = new MySqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        currentUserBalance = Convert.ToInt32(reader[0].ToString());
                    }
                    reader.Close();
                    if (currentUserBalance >= spentMoney)
                    {
                        currentUserBalance -= spentMoney;
                        string maxPurchaseNo = "";
                        sql = $@"SELECT MAX(PurchaseNo) FROM invoice_user_shop ; ";
                        command = new MySqlCommand(sql, connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            maxPurchaseNo = reader[0].ToString();
                        }
                        reader.Close();
                        if (maxPurchaseNo != "")
                        {
                            purchaseNo = Convert.ToInt32(maxPurchaseNo) + 1;
                        }
                        else
                        {
                            purchaseNo = 1;
                        }
                        string prevItem = "";

                        foreach (string item in items)
                        {
                            if (prevItem == item)
                            {

                            }
                            else
                            {
                                int shopId = 0;
                                int quantity = 0;
                                prevItem = item;
                                int end = item.LastIndexOf("-");
                                string productName = item.Substring(0, end).TrimEnd();
                                if (productName == "Chain-Tag" || productName == "Magnet" || productName == "T-Shirt")
                                {
                                    shopId = 2;
                                }
                                else
                                {
                                    shopId = 1;
                                }
                                foreach (string i in items)
                                {
                                    if (item == i)
                                    {
                                        quantity++;
                                    }
                                }

                                sql = $@"INSERT INTO invoice_user_shop (PurchaseNo,EventAcc_UserID,ShopID,ProductName,Quantity) 
                                VALUES ('{purchaseNo}', '{userId}', '{shopId}', '{productName}', '{quantity}')";

                                command = new MySqlCommand(sql, connection);
                                int nrChanged = command.ExecuteNonQuery();
                                if (nrChanged > 0)
                                {
                                    int currentStockQuantity = 0;
                                    sql = $@"SELECT StockQuantity FROM shop_has_items WHERE ProductName= '{productName}' ; ";
                                    command = new MySqlCommand(sql, connection);
                                    reader = command.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        currentStockQuantity = Convert.ToInt32(reader[0].ToString());
                                    }
                                    currentStockQuantity -= quantity;
                                    reader.Close();

                                    sql = $@"UPDATE shop_has_items SET StockQuantity = '{currentStockQuantity}' WHERE ProductName= '{productName}' ; ";
                                    command = new MySqlCommand(sql, connection);

                                    int num = 0;

                                    num = Convert.ToInt32(command.ExecuteNonQuery());
                                    if (num != 0)
                                    {

                                    }
                                    else
                                    {
                                        return "Erorr!";
                                    }
                                }
                                else
                                {
                                    return "Something happened";
                                }
                            }

                        }
                        sql = $@"INSERT INTO invoice_user_shop_receipt (PurchaseNo) 
                                VALUES ('{purchaseNo}')";

                        command = new MySqlCommand(sql, connection);
                        int nrOfRecordsChanged = command.ExecuteNonQuery();
                        if (nrOfRecordsChanged > 0)
                        {
                            int currentSentMoney = 0;
                            sql = $@"SELECT SpentMoney FROM eventacc WHERE User_userID= '{userId}' ; ";
                            command = new MySqlCommand(sql, connection);
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                currentSentMoney = Convert.ToInt32(reader[0].ToString());
                            }
                            reader.Close();
                            currentSentMoney += spentMoney;
                            sql = $@"UPDATE eventacc SET balance = '{currentUserBalance}' WHERE User_userID= '{userId}' ; ";
                            command = new MySqlCommand(sql, connection);

                            int number = 0;

                            number = Convert.ToInt32(command.ExecuteNonQuery());
                            if (number != 0)
                            {
                                sql = $@"UPDATE eventacc SET SpentMoney = '{currentSentMoney}' WHERE User_userID= '{userId}' ; ";
                                command = new MySqlCommand(sql, connection);

                                number = 0;

                                number = Convert.ToInt32(command.ExecuteNonQuery());
                                if (number != 0)
                                {
                                    return "added";
                                }
                                else
                                {
                                    return "Erorr!";
                                }
                            }
                            else
                            {
                                return "Erorr!";
                            }
                        }
                        else
                        {
                            return "Erorr!";
                        }

                    }
                    else
                    {
                        return "nobalance";
                    }
                }
                else
                {
                    return "nouser";
                }

            }
            catch
            {
                return "error";

            }
            finally
            {

                connection.Close();

            }
        }
    }
}
