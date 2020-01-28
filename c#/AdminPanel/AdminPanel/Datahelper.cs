using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace AdminPanel
{
    class Datahelper
    {
        public MySqlConnection connection;
        public MySqlConnection connection2;
        public MySqlConnection connection3;

        public Datahelper()
        {
            string connectionInfo = "server=studmysql01.fhict.local;" +
                               "database=dbi416657;" +
                               "user id=dbi416657;" +
                               "password=hera.fhict;" +
                               "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
            connection2 = new MySqlConnection(connectionInfo);
            connection3 = new MySqlConnection(connectionInfo);
        }

        public string GetUserStatus(string user_id)
        {

            string userStatus = "";
            try
            {

                string sql = $@"SELECT userStatus FROM eventacc WHERE User_userid = '{user_id}' ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return "reader error";
                }
                reader.Read();

                userStatus = reader[0].ToString();
                if (userStatus == "in")
                {
                    return "In the Event ";
                }
                else
                {
                    return "Not in the Event";
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
        public List<string> GetUserHistory(string user_id)
        {
            List<string> shopList = new List<string>();

            try
            {

                string sql = $@"SELECT SpentMoney,balance FROM eventacc WHERE User_userid = '{user_id}' ;";
                string sqlshop = $@"SELECT ProductName, Quantity FROM invoice_user_shop where EventAcc_UserID = '{user_id}' ORDER BY ProductName ;";
                string sqlrent = $@"SELECT ProductName, Quantity FROM invoice_user_rentshop where EventAcc_UserID = '{user_id}' ORDER BY ProductName;";

                MySqlCommand command1 = new MySqlCommand(sql, connection);
                MySqlCommand command2 = new MySqlCommand(sqlshop, connection2);
                MySqlCommand command3 = new MySqlCommand(sqlrent, connection3);
                connection.Open();
                MySqlDataReader reader1 = command1.ExecuteReader();
                connection2.Open();
                MySqlDataReader reader2 = command2.ExecuteReader();
                connection3.Open();
                MySqlDataReader reader3 = command3.ExecuteReader();


                //List<string> rentList = new List<string>();
                if (reader1.HasRows & reader2.HasRows & reader3.HasRows)
                {
                    reader1.Read();
                    //reader2.Read();
                    //reader3.Read();

                    string SpentMoney = reader1[0].ToString();
                    string balance = reader1[1].ToString();

                    shopList.Add("SpentMoney: " + SpentMoney + "$");
                    shopList.Add("Balance: " + balance + "$");
                    shopList.Add("---------------------");
                    shopList.Add("Shop Products:");
                    string shopItemName = "";
                    int shopItemQuantity = 0;
                    int count = 0;
                    while (reader2.Read())
                    {
                        if (shopItemName == reader2[0].ToString())
                        {
                            shopItemQuantity += Convert.ToInt32(reader2[1].ToString());
                        }
                        else
                        {
                            if (count >= 1)
                            {
                                shopList.Add(shopItemName + " -" + " Quantity " + shopItemQuantity);
                                count = 0;
                            }
                            shopItemName = reader2[0].ToString();
                            shopItemQuantity = Convert.ToInt32(reader2[1].ToString());
                            count++;
                        }
                    }
                    shopList.Add(shopItemName + " -" + " Quantity " + shopItemQuantity);
                    shopList.Add("---------------------");
                    shopList.Add("Rent Products:");
                    string loanItemName = "";
                    int loanItemQuantity = 0;
                    int counter = 0;
                    while (reader3.Read())
                    {
                        if (loanItemName == reader3[0].ToString())
                        {
                            loanItemQuantity += Convert.ToInt32(reader3[1].ToString());
                        }
                        else
                        {
                            if (counter >= 1)
                            {
                                shopList.Add(loanItemName + " -" + " Quantity " + loanItemQuantity);
                                counter = 0;
                            }
                            loanItemName = reader3[0].ToString();
                            loanItemQuantity = Convert.ToInt32(reader3[1].ToString());
                            counter++;
                        }
                    }
                    shopList.Add(loanItemName + " -" + " Quantity " + loanItemQuantity);

                }

                return shopList;
            }
            catch
            {
                return shopList;
            }
            finally
            {
                connection.Close();
                connection2.Close();
                connection3.Close();
            }
        }
        public int GetVistorCount()
        {

            int vistorCount = 0;

            try
            {

                string sql = $@"SELECT count(*) FROM eventacc ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                reader.Read();
                vistorCount = int.Parse(reader[0].ToString());

                return vistorCount;
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
        public int GetPresentCount()
        {
            int presentCOunt = 0;
            try
            {

                string sql = $@"SELECT count(*) FROM eventacc where userStatus = 'in' ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                reader.Read();
                presentCOunt = int.Parse(reader[0].ToString());

                return presentCOunt;
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

                string sql = $@"SELECT sum(Quantity) FROM `invoice_user_shop` where ProductName='{product_name}' ;";
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
        public int GetRentQuantity(String product_name)
        {

            int Quantity = 0;

            try
            {

                string sql = $@"SELECT sum(Quantity) FROM `invoice_user_rentshop` where ProductName='{product_name}' ;";
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

        public int GetRentPrdouctPrice(String product_name)
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
        public int GetCampingsBooked()
        {
            int presentCOunt = 0;
            try
            {

                string sql = $@"SELECT count(*) FROM camping where Booked = '1' ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                reader.Read();
                presentCOunt = int.Parse(reader[0].ToString());

                return presentCOunt;
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
        public int GetCampingsNotBooked()
        {
            int presentCOunt = 0;
            try
            {

                string sql = $@"SELECT count(*) FROM camping where Booked = '0' ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                reader.Read();
                presentCOunt = int.Parse(reader[0].ToString());

                return presentCOunt;
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
        public int GetCampingStatus(int campingNo)
        {
            int status = -1;
            try
            {

                string sql = $@"SELECT Booked FROM camping where SpotID = '{campingNo}' ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return -1;
                }
                reader.Read();
                status = int.Parse(reader[0].ToString());

                return status;
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
        public List<string> GetCampingInfo(int campingNo)
        {
            List<string> names = new List<string>();
            try
            {

                string sql = $@"SELECT u.first_name FROM eventacc e JOIN user u ON (e.User_userID = u.idUser) where e.Camping_SpotID = '{campingNo}' ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    names.Add(reader[0].ToString());
                }
                return names;
            }
            catch
            {
                return null;

            }
            finally
            {
                connection.Close();
            }
        }
        public int GetTotalProductsSoldAndRent()
        {
            int totalRent = 0;
            int totalSold = 0;
            try
            {

                string sql = $@"SELECT SUM(Quantity) FROM invoice_user_rentshop;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                reader.Read();
                totalRent = int.Parse(reader[0].ToString());
                reader.Close();

                sql = $@"SELECT SUM(Quantity) FROM invoice_user_shop;";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                reader.Read();
                totalSold = int.Parse(reader[0].ToString());

                return totalRent + totalSold;
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
        public int GetTotalMoneySpent()
        {
            int total = 0;
            try
            {

                string sql = $@"SELECT SUM(SpentMoney) FROM eventacc;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                reader.Read();
                total = int.Parse(reader[0].ToString());

                return total;
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
        public int GetTotalBalance()
        {
            int total = 0;
            try
            {

                string sql = $@"SELECT SUM(balance) FROM eventacc;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                reader.Read();
                total = int.Parse(reader[0].ToString());

                return total;
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
        public int GetTotalAmountCampings()
        {
            int total = 0;
            try
            {

                string sql = $@"SELECT SUM(Booked*Price) FROM camping;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return 0;
                }
                reader.Read();
                total = int.Parse(reader[0].ToString());

                return total;
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

        public int GetRentShopMoneyEarned()
        {
            int CameraEarned = 0;
            int SelfieStickEarned = 0;
            int ChargerEarned = 0;
            int BackpackEarned = 0;

            try
            {
                string sql = $@"SELECT IFNULL(SUM(i.Quantity)*r.PriceForProduct,0) 
                             FROM rentshop_products r RIGHT JOIN invoice_user_rentshop i 
                             ON (r.ProductName = i.ProductName) WHERE r.ProductName = 'Charger';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChargerEarned =Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                sql = $@"SELECT IFNULL(SUM(i.Quantity)*r.PriceForProduct,0) 
                             FROM rentshop_products r RIGHT JOIN invoice_user_rentshop i 
                             ON (r.ProductName = i.ProductName) WHERE r.ProductName = 'Camera';";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CameraEarned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                sql = $@"SELECT IFNULL(SUM(i.Quantity)*r.PriceForProduct,0) 
                             FROM rentshop_products r RIGHT JOIN invoice_user_rentshop i 
                             ON (r.ProductName = i.ProductName) WHERE r.ProductName = 'SelfieStick';";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SelfieStickEarned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                sql = $@"SELECT IFNULL(SUM(i.Quantity)*r.PriceForProduct,0) 
                             FROM rentshop_products r RIGHT JOIN invoice_user_rentshop i 
                             ON (r.ProductName = i.ProductName) WHERE r.ProductName = 'Backpack';";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BackpackEarned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                int AmountEarned = ChargerEarned + SelfieStickEarned + CameraEarned + BackpackEarned;
                return AmountEarned;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public int GetFoodShopAmountEarned()
        {
            int BeersEarned = 0;
            int BurgersEarned = 0;
            int CocaColaEarned = 0;
            int IceCreamEaned = 0;
            int PancakesEarned = 0;
            int IceTeaEarned = 0;
            try
            {
                string sql = $@"SELECT IFNULL(SUM(i.Quantity)*s.PriceForProduct,0) 
                             FROM shopitems s RIGHT JOIN invoice_user_shop i 
                             ON (s.ProductName = i.ProductName) WHERE s.ProductName = 'Beer';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BeersEarned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                sql = $@"SELECT IFNULL(SUM(i.Quantity)*s.PriceForProduct,0) 
                             FROM shopitems s RIGHT JOIN invoice_user_shop i 
                             ON (s.ProductName = i.ProductName) WHERE s.ProductName = 'Burger';";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BurgersEarned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                sql = $@"SELECT IFNULL(SUM(i.Quantity)*s.PriceForProduct,0) 
                             FROM shopitems s RIGHT JOIN invoice_user_shop i 
                             ON (s.ProductName = i.ProductName) WHERE s.ProductName = 'Cola';";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CocaColaEarned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                sql = $@"SELECT IFNULL(SUM(i.Quantity)*s.PriceForProduct,0) 
                             FROM shopitems s RIGHT JOIN invoice_user_shop i 
                             ON (s.ProductName = i.ProductName) WHERE s.ProductName = 'Ice Cream';";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IceCreamEaned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                sql = $@"SELECT IFNULL(SUM(i.Quantity)*s.PriceForProduct,0) 
                             FROM shopitems s RIGHT JOIN invoice_user_shop i 
                             ON (s.ProductName = i.ProductName) WHERE s.ProductName = 'IceTea';";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IceTeaEarned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                sql = $@"SELECT IFNULL(SUM(i.Quantity)*s.PriceForProduct,0) 
                             FROM shopitems s RIGHT JOIN invoice_user_shop i 
                             ON (s.ProductName = i.ProductName) WHERE s.ProductName = 'Pancakes';";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PancakesEarned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                int amountEarned = BeersEarned + CocaColaEarned + IceCreamEaned + IceTeaEarned + PancakesEarned +BurgersEarned;
                return amountEarned;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public int GetSouvernirShopAmountEarned()
        {
            int ChainTagEarned = 0;
            int MagnetEarned = 0;
            int TshirtEarned = 0;;
            try
            {
                string sql = $@"SELECT IFNULL(SUM(i.Quantity)*s.PriceForProduct,0) 
                             FROM shopitems s RIGHT JOIN invoice_user_shop i 
                             ON (s.ProductName = i.ProductName) WHERE s.ProductName = 'Chain-Tag';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChainTagEarned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                sql = $@"SELECT IFNULL(SUM(i.Quantity)*s.PriceForProduct,0) 
                             FROM shopitems s RIGHT JOIN invoice_user_shop i 
                             ON (s.ProductName = i.ProductName) WHERE s.ProductName = 'Magnet';";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MagnetEarned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();

                sql = $@"SELECT IFNULL(SUM(i.Quantity)*s.PriceForProduct,0) 
                             FROM shopitems s RIGHT JOIN invoice_user_shop i 
                             ON (s.ProductName = i.ProductName) WHERE s.ProductName = 'T-Shirt';";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TshirtEarned = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();
                

                int amountEarned = ChainTagEarned + MagnetEarned + TshirtEarned;
                return amountEarned;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<string> GetProductsForSelling()
        {
            List<string> products = new List<string>();
            try
            {
                string sql = $@"SELECT ProductName 
                             FROM shopitems ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(reader[0].ToString());
                }
                reader.Close();
                return products;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public List<string> GetProductsForRenting()
        {
            List<string> products = new List<string>();
            try
            {
                string sql = $@"SELECT ProductName 
                             FROM rentshop_products;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(reader[0].ToString());
                }
                reader.Close();
                return products;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }




}
