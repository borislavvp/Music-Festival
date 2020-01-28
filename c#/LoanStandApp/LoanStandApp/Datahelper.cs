using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LoanStandApp
{
    class Datahelper
    {
        private MySqlConnection connection;
        private MySqlConnection connection2;
        public Datahelper()
        {
            string connectionInfo = "server=studmysql01.fhict.local;" +
                               "database=dbi416657;" +
                               "user id=dbi416657;" +
                               "password=hera.fhict;" +
                               "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
            connection2 = new MySqlConnection(connectionInfo);
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
                string sql = $@"SELECT PriceForProduct FROM rentshop_products WHERE ProductName = '{product_name}' ;";
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
        public int GetRetrunedItemCount(string item,int userId)
        {
            int returnedItems = 0;
            string sql = $@"SELECT SUM(Returned) FROM invoice_user_rentshop where ProductName = '{item}' AND EventAcc_UserID = '{userId}';";
            MySqlCommand command = new MySqlCommand(sql, connection2);
            connection2.Open();
            MySqlDataReader reader2 = command.ExecuteReader();
            while (reader2.Read())
            {
                returnedItems = Convert.ToInt32(reader2[0].ToString());
            }
            reader2.Close();
            return returnedItems;
        }
        public List<string> GetItemsLoanedByUser(string user_rfid)
        {
            try
            {
                List<string> temp = new List<string>();
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
                    sql = $@"SELECT ProductName FROM invoice_user_rentshop where EventAcc_UserID = '{userId}' ORDER BY ProductName;";
                    command = new MySqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        temp.Add(reader[0].ToString());
                    }
                    reader.Close();
                    string prevItem = "";
                    List<string> itemsLoaned = new List<string>();
                    foreach (string item in temp)
                    {
                        int quantity = 0;
                        if (prevItem == item)
                        {

                        }
                        else
                        {
                            prevItem = item;
                            sql = $@"SELECT SUM(Quantity) FROM invoice_user_rentshop WHERE ProductName = '{item}' AND EventAcc_UserID = '{userId}';";
                            command = new MySqlCommand(sql, connection);
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                quantity = Convert.ToInt32(reader[0].ToString());
                            }
                            int returnedItems = GetRetrunedItemCount(item,userId);
                            connection2.Close();
                            if (quantity > returnedItems)
                            {
                                itemsLoaned.Add(item);
                                int itemsToReturn = quantity - returnedItems;
                                itemsLoaned.Add(itemsToReturn.ToString());
                            }
                        }
                        reader.Close();
                    }
                    return itemsLoaned;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception )
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public int GetStockQuantityOfCamera()
        {
            try
            {
                string name = "Camera";
                int quantity = -1;
                string sql = $@"SELECT StockQuantity FROM rentshop_has_items where ProductName = '{name}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    quantity = Convert.ToInt32(reader[0].ToString());
                }
                return quantity;

            }
            catch
            {
                return -1;

            }
            finally
            {

                connection.Close();

            }
        }
        public int GetStockQuantityOfCharger()
        {
            try
            {
                string name = "Charger";
                int quantity = -1;
                string sql = $@"SELECT StockQuantity FROM rentshop_has_items where ProductName = '{name}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    quantity = Convert.ToInt32(reader[0].ToString());
                }
                return quantity;

            }
            catch
            {
                return -1;

            }
            finally
            {

                connection.Close();

            }
        }
        public int GetStockQuantityOfSelfieStick()
        {
            try
            {
                string name = "SelfieStick";
                int quantity = -1;
                string sql = $@"SELECT StockQuantity FROM rentshop_has_items where ProductName = '{name}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    quantity = Convert.ToInt32(reader[0].ToString());
                }
                return quantity;

            }
            catch
            {
                return -1;

            }
            finally
            {

                connection.Close();

            }
        }
        public int GetStockQuantityOfBackpack()
        {
            try
            {
                string name = "Backpack";
                int quantity = -1;
                string sql = $@"SELECT StockQuantity FROM rentshop_has_items where ProductName = '{name}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    quantity = Convert.ToInt32(reader[0].ToString());
                }
                return quantity;

            }
            catch
            {
                return -1;

            }
            finally
            {

                connection.Close();

            }
        }

        public string LoanItemToVisitor(string user_rfid, List<string> items, int spentMoney)
        {
            try
            {
                Random rd = new Random();
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
                        sql = $@"SELECT MAX(PurchaseNo) FROM invoice_user_rentshop ; ";
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
                                int quantity = 0;
                                prevItem = item;
                                int end = item.LastIndexOf("-");
                                string productName = item.Substring(0, end).TrimEnd();
                                foreach (string i in items)
                                {
                                    if (item == i)
                                    {
                                        quantity++;
                                    }
                                }

                                sql = $@"INSERT INTO invoice_user_rentshop (PurchaseNo,EventAcc_UserID,RentShopID,ProductName,Quantity,Returned) 
                                VALUES ('{purchaseNo}', '{userId}', '1', '{productName}', '{quantity}','0' )";

                                command = new MySqlCommand(sql, connection);
                                int nrChanged= command.ExecuteNonQuery();
                                if (nrChanged > 0)
                                {
                                    int currentStockQuantity = 0;
                                    sql = $@"SELECT StockQuantity FROM rentshop_has_items WHERE ProductName= '{productName}' ; ";
                                    command = new MySqlCommand(sql, connection);
                                    reader = command.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        currentStockQuantity = Convert.ToInt32(reader[0].ToString());
                                    }
                                    currentStockQuantity -= quantity;
                                    reader.Close();

                                    sql = $@"UPDATE rentshop_has_items SET StockQuantity = '{currentStockQuantity}' WHERE ProductName= '{productName}' ; ";
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
                        sql = $@"INSERT INTO invoice_user_rentshop_receipt (PurchaseNo) 
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

        public string ReturnItem(string user_rfid, string damaged,List<string> products)
        {

            try
            {
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
                    string prevItem = "";

                    foreach (string item in products)
                    {
                        if (prevItem == item)
                        {

                        }
                        else
                        {

                            int quantity = 0;

                            prevItem = item;
                            int end = item.LastIndexOf("-");
                            string productName = item.Substring(0, end).TrimEnd();
                            foreach (string i in products)
                            {
                                if (item == i)
                                {
                                    quantity++;
                                }
                            }
                            int currentStockQuantity = 0;
                            int countQuantity = quantity;
                            List<int> purchaseNumbers = new List<int>();
                            sql = $@"SELECT PurchaseNo FROM invoice_user_rentshop WHERE EventAcc_UserID = '{userId}' AND ProductName = '{productName}'  ; ";
                            command = new MySqlCommand(sql, connection);
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                purchaseNumbers.Add(Convert.ToInt32(reader[0].ToString()));
                            }
                            reader.Close();
                            int itemsLeft = 0;
                            foreach (int purchNo in purchaseNumbers)
                            {

                                int quantityPurchased = 0;
                                sql = $@"SELECT Quantity FROM invoice_user_rentshop WHERE EventAcc_UserID = '{userId}' AND PurchaseNo = '{purchNo}' AND ProductName = '{productName}'; ";
                                command = new MySqlCommand(sql, connection);
                                reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    quantityPurchased = Convert.ToInt32(reader[0].ToString());
                                }
                                reader.Close();

                                int returnedItems = 0;
                                sql = $@"SELECT Returned FROM invoice_user_rentshop WHERE EventAcc_UserID = '{userId}' AND PurchaseNo = '{purchNo}' AND ProductName = '{productName}'; ";
                                command = new MySqlCommand(sql, connection);
                                reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    returnedItems = Convert.ToInt32(reader[0].ToString());
                                }
                                reader.Close();
                                if (quantityPurchased != returnedItems)
                                {

                                    itemsLeft = quantity - quantityPurchased;

                                    if (itemsLeft > 0)
                                    {
                                        if (returnedItems == 0)
                                        {
                                            quantity -= quantityPurchased;
                                        }
                                        else
                                        {
                                            quantity = quantity - (quantityPurchased - returnedItems);
                                        }

                                        sql = $@"UPDATE invoice_user_rentshop SET Returned = '{quantityPurchased}' WHERE ProductName = '{productName}' AND PurchaseNo = '{purchNo}'  ; ";
                                        command = new MySqlCommand(sql, connection);

                                        int number = 0;

                                        number = Convert.ToInt32(command.ExecuteNonQuery());
                                        if (number != 0)
                                        {
                                        }
                                        else
                                        {
                                            return "Erorr!";
                                        }
                                    }
                                    else if (itemsLeft == 0)
                                    {

                                        int addStockQ = quantity - returnedItems;
                                        if (returnedItems == quantity)
                                        {
                                            quantity = quantityPurchased - quantity;
                                        }
                                        if (addStockQ < 0)
                                        {
                                            quantity = 0;
                                            addStockQ = 1;
                                        }
                                        quantity -= addStockQ;

                                        sql = $@"UPDATE invoice_user_rentshop SET Returned = '{quantityPurchased}' WHERE ProductName = '{productName}' AND PurchaseNo = '{purchNo}'  ; ";
                                        command = new MySqlCommand(sql, connection);

                                        int number = 0;

                                        number = Convert.ToInt32(command.ExecuteNonQuery());
                                        if (number != 0)
                                        {

                                            sql = $@"SELECT StockQuantity FROM rentshop_has_items WHERE ProductName= '{productName}' ; ";
                                            command = new MySqlCommand(sql, connection);
                                            reader = command.ExecuteReader();
                                            while (reader.Read())
                                            {
                                                currentStockQuantity = Convert.ToInt32(reader[0].ToString());
                                            }

                                            reader.Close();

                                            sql = $@"UPDATE invoice_user_rentshop SET Damaged = '{damaged}' WHERE ProductName = '{productName}' AND PurchaseNo = '{purchNo}'  ; ";
                                            command = new MySqlCommand(sql, connection);

                                            number = Convert.ToInt32(command.ExecuteNonQuery());
                                            if (number != 0)
                                            {
                                                if (quantity == 0)
                                                {
                                                    break;
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
                                        int returnedQuantity = 0;
                                        if (returnedItems > 0)
                                        {
                                            if (quantityPurchased - returnedItems == 1)
                                            {
                                                returnedQuantity = quantityPurchased;
                                                if (quantity + returnedItems == quantityPurchased)
                                                {
                                                    quantity = 0;
                                                }
                                                else
                                                {
                                                    quantity = 1;
                                                }
                                            }
                                            else
                                            {
                                                returnedQuantity = quantityPurchased;
                                                quantity = 0;
                                            }
                                        }
                                        else
                                        {
                                            returnedQuantity = quantity;
                                            quantity = 0;
                                        }
                                        sql = $@"UPDATE invoice_user_rentshop SET Returned = '{returnedQuantity}' WHERE ProductName = '{productName}' AND PurchaseNo = '{purchNo}'  ; ";
                                        command = new MySqlCommand(sql, connection);

                                        int number = 0;

                                        number = Convert.ToInt32(command.ExecuteNonQuery());
                                        if (number != 0)
                                        {
                                            sql = $@"SELECT StockQuantity FROM rentshop_has_items WHERE ProductName= '{productName}' ; ";
                                            command = new MySqlCommand(sql, connection);
                                            reader = command.ExecuteReader();
                                            while (reader.Read())
                                            {
                                                currentStockQuantity = Convert.ToInt32(reader[0].ToString());
                                            }
                                            reader.Close();

                                            sql = $@"UPDATE invoice_user_rentshop SET Damaged = '{damaged}' WHERE ProductName = '{productName}' AND PurchaseNo = '{purchNo}'  ; ";
                                            command = new MySqlCommand(sql, connection);

                                            number = Convert.ToInt32(command.ExecuteNonQuery());
                                            if (number != 0)
                                            {
                                                if (quantity == 0)
                                                {
                                                    break;
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
                                }
                                else
                                {

                                }
                            }

                            currentStockQuantity += countQuantity;
                            sql = $@"UPDATE rentshop_has_items SET StockQuantity = '{currentStockQuantity}' WHERE ProductName= '{productName}' ; ";
                            command = new MySqlCommand(sql, connection);

                            int num = 0;

                            num = Convert.ToInt32(command.ExecuteNonQuery());
                            if (num != 0)
                            {
                            }
                        }
                    }
                    return "returned";
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
