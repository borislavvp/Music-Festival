using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace EventEntrance
{
    class Datahelper
    {
        public MySqlConnection connection;
        //Variable to keep the user's id
        public int userId = -1;
        public Datahelper()
        {
            string connectionInfo = "server=studmysql01.fhict.local;" +
                               "database=dbi416657;" +
                               "user id=dbi416657;" +
                               "password=hera.fhict;" +
                               "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }
        //Checking if a visitor is existing in the databse with the given barcode
        public string isVistorExsist(string visitor_barcode)

        {

            string name = "";
            try
            {
                //First setting the user's id by the methond
                userId = GetUserIdWithBarcode(visitor_barcode);
                string sql = $@"SELECT first_name FROM user WHERE Barcode = '{visitor_barcode}' ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return "reader error";
                }
                while (reader.Read())
                {
                    name = reader[0].ToString();
                }

                if (name != "")
                {
                    return "yes";
                }
                else
                {
                    return "no";
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
        //Getting the user's id with the given barcode
        public int GetUserIdWithBarcode(string user_barcode)
        {
            try
            {

                string sql = $@"SELECT idUser FROM user where Barcode = '{user_barcode}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    userId = int.Parse(reader[0].ToString());
                }
                if (userId != -1)
                {
                    reader.Close();
                    return userId;
                }
                else
                {
                    reader.Close();
                    return -1;
                }

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
        //Getting the user's id with the RFID Code given
        public int GetUserIdWithRfid(string user_rfid)
        {
            try
            {

                string sql = $@"SELECT idUser FROM user where RFID = '{user_rfid}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    userId = int.Parse(reader[0].ToString());
                }
                if (userId != -1)
                {
                    reader.Close();
                    return userId;
                }
                else
                {
                    reader.Close();
                    return -1;
                }

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
        // Set the RFID Code to the user
        public string GiveRfid(string RFID)
        {

            try
            {

                string name = "";
                string sql = $@"SELECT first_name FROM user where RFID = '{RFID}';";
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
                    return "There is already a user with that RFID";
                }
                else
                {
                    reader.Close();
                    sql = $@"UPDATE user SET RFID = '{RFID}' WHERE idUser = '{userId}' ;";

                    command = new MySqlCommand(sql, connection);
                    int number = 0;
                    number = Convert.ToInt32(command.ExecuteNonQuery());
                    if (number != 0)
                    {
                        return "Checked in !";
                    }
                    else
                    {
                        return "Error Assigning RFID";
                    }
                }
            }
            catch
            {
                return "Error!";
            }
            finally
            {
                connection.Close();
            }
        }
        //Checks in the visitor
        public string CheckInVisitor()
        {
            try
            {
                //First we check if the user id is set
                if (userId != -1)
                {
                    // Then we check if the visitor is already in the event and if it is we stop
                    string status = "";
                    string sql = $@"SELECT userStatus FROM eventacc WHERE User_userID= '{userId}' ; ";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        status = reader[0].ToString();
                    }
                    if (status == "in")
                    {
                        return "in";
                    }
                    reader.Close();
                    // Set the visitor's status to in
                    sql = $@"UPDATE eventacc SET userStatus = 'in' WHERE User_userID= '{userId}' ; ";
                    command = new MySqlCommand(sql, connection);

                    int number = 0;

                    number = Convert.ToInt32(command.ExecuteNonQuery());
                    if (number != 0)
                    {
                        return "Checked";
                    }
                    else
                    {
                        return "Erorr";
                    }
                }
                else
                {
                    return "nouser";
                }

            }
            catch
            {
                return "Erorr connection";

            }
            finally
            {
                connection.Close();
            }


        }
        //Cheks out the visitor
        public string CheckOutVisitor(string rfid)
        {
            try
            {
                //First we set the visitor's id
                userId = GetUserIdWithRfid(rfid);
                //Then we check if the visitor's id is set correctly
                if (userId != -1)
                {
                    List<string> itemsLoaned = new List<string>();
                    string sql = $@"SELECT ProductName FROM invoice_user_rentshop WHERE EventAcc_UserID = '{userId}' AND Returned <> Quantity ; ";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        itemsLoaned.Add(reader[0].ToString());
                    }
                    reader.Close();
                    if (itemsLoaned.Count == 0)
                    {
                        //Then we check if the visitor is in the event
                        string status = "";
                        sql = $@"SELECT userStatus FROM eventacc WHERE User_userID= '{userId}' ; ";
                        command = new MySqlCommand(sql, connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            status = reader[0].ToString();
                        }
                        reader.Close();
                        if (status == "in")
                        {
                            sql = $@"UPDATE eventacc SET userStatus = 'out' WHERE User_userID= '{userId}' ; ";
                            command = new MySqlCommand(sql, connection);

                            int number = 0;

                            number = Convert.ToInt32(command.ExecuteNonQuery());
                            if (number != 0)
                            {
                                return "out";
                            }
                            else
                            {
                                return "Erorr!";
                            }

                        }
                        else
                        {
                            return "notin";
                        }
                    }
                    else
                    {
                        string items = "";
                        foreach (string item in itemsLoaned)
                        {
                            items += " " + item;
                        }
                        return items;
                    }
                }
                else
                {
                    return "nouser";
                }
            }
            catch
            {
                return "Erorr connection!";

            }
            finally
            {
                connection.Close();
            }
        }

        public string CheckOutVisitorInCaseOfLostRfid(int userID)
        {
            try
            {
                //Then we check if the visitor's id is set correctly
                if (userID != 0)
                {

                    //Then we check if the visitor is in the event
                    string status = "";
                    string sql = $@"SELECT userStatus FROM eventacc WHERE User_userID= '{userID}' ; ";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        status = reader[0].ToString();
                    }
                    reader.Close();
                    if (status == "in")
                    {
                        sql = $@"UPDATE eventacc SET userStatus = 'out' WHERE User_userID= '{userID}' ; ";
                        command = new MySqlCommand(sql, connection);

                        int number = 0;

                        number = Convert.ToInt32(command.ExecuteNonQuery());
                        if (number != 0)
                        {
                            return "out";
                        }
                        else
                        {
                            return "Erorr!";
                        }

                    }
                    else
                    {
                        return "notin";
                    }
                }
                else
                {
                    return "nouser";
                }
            }
            catch
            {
                return "Erorr connection!";

            }
            finally
            {
                connection.Close();
            }
        }

        //Adding a visitor the the database 
        public string AddCustomer(string fname, string nationality, string password, string email, string phone)
        {
            try
            {
                int newUserId = -1;
                string sql = $@"SELECT MAX(iduser) FROM user ; ";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    newUserId = Convert.ToInt32(reader[0].ToString()) + 1;
                }
                reader.Close();

                userId = newUserId;

                sql = $@"INSERT INTO user (idUser,first_name,nationality,email,password,phone) VALUES ('{newUserId}','{fname}', '{nationality}', '{email}', '{password}', '{phone}' )";

                command = new MySqlCommand(sql, connection);

                int nrOfRecordsChanged = command.ExecuteNonQuery();
                if (nrOfRecordsChanged > 0)
                {
                    return "added";
                }
                else
                {
                    return "Something happened";
                }
            }
            catch
            {
                return " error";
            }
            finally
            {
                connection.Close();
            }

        }
        //Adding the new account to the event
        public string addEventAccToTheNewUser()
        {
            try
            {
                //First we add it to the eventacc table to make the relation
                string sql = $@"INSERT INTO eventacc (User_userID,balance,SpentMoney,userStatus) VALUES ('{userId}', '0', '60' , 'in')";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                if (nrOfRecordsChanged > 0)
                {
                    //Then we add it to the tickets table to make the relation
                    sql = $@"INSERT INTO tickets (EventAcc_userID ,ticketType) VALUES ('{userId}', 'Regular')";
                    command = new MySqlCommand(sql, connection);
                    nrOfRecordsChanged = command.ExecuteNonQuery();
                    if (nrOfRecordsChanged > 0)
                    {
                        return "giverfid";
                    }
                    else
                    {
                        return "Error creating Event Account";
                    }
                }
                else
                {
                    return "Error Account Creating";
                }
            }
            catch
            {
                return " error";
            }
            finally
            {
                connection.Close();
            }
        }

        public string ChargeUserForTheTombola(string rfid)
        {
            try
            {
                userId = GetUserIdWithRfid(rfid);

                if (userId != 0)
                {
                    int spentMoney = -1;
                    string sql = $@"SELECT SpentMoney FROM eventacc WHERE User_userID = '{userId}' ; ";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        spentMoney = Convert.ToInt32(reader[0].ToString()) + 2;
                    }
                    reader.Close();

                    sql = $@"UPDATE eventacc SET SpentMoney = '{spentMoney}' WHERE User_userID= '{userId}' ; ";
                    command = new MySqlCommand(sql, connection);

                    int number = 0;

                    number = Convert.ToInt32(command.ExecuteNonQuery());
                    if (number != 0)
                    {
                        int EarnedMoneyFromTombola = -1;
                        sql = $@"SELECT EarnedMoney FROM tombolawinner; ";
                        command = new MySqlCommand(sql, connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            EarnedMoneyFromTombola = Convert.ToInt32(reader[0].ToString()) + 2;
                        }
                        reader.Close();

                        sql = $@"UPDATE tombolawinner SET EarnedMoney = '{EarnedMoneyFromTombola}'; ";
                        command = new MySqlCommand(sql, connection);

                        int num = 0;

                        num = Convert.ToInt32(command.ExecuteNonQuery());
                        if (num != 0)
                        {
                            return "updated";
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
                    return "nouser";
                }
            }
            catch
            {
                return "Erorr connection!";
            }
            finally
            {
                connection.Close();
            }
        }

       

        public string ReturnBalanceToUser(string rfid)
        {
            try
            {
                userId = GetUserIdWithRfid(rfid);
                if (userId != 0)
                {
                    int balance = -1;
                    string sql = $@"SELECT balance FROM eventacc WHERE User_userID = '{userId}' ; ";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        balance = Convert.ToInt32(reader[0].ToString());
                    }
                    reader.Close();
                    sql = $@"UPDATE eventacc SET balance = '0' WHERE User_userID = '{userId}' ; ";
                    command = new MySqlCommand(sql, connection);

                    int number = 0;

                    number = Convert.ToInt32(command.ExecuteNonQuery());
                    if (number != 0)
                    {
                        sql = $@"UPDATE user SET RFID = NULL , Barcode = NULL WHERE idUser = '{userId}' ; ";
                        command = new MySqlCommand(sql, connection);

                        number = Convert.ToInt32(command.ExecuteNonQuery());
                        if (number != 0)
                        {
                            if (balance > 0)
                            {
                                return "Successfully returned " + balance + "$";
                            }
                            else
                            {
                                return "This user doesn't have any money left";
                            }
                        }
                        else
                        {
                            return "Erorr";
                        }
                    }
                    else
                    {
                        return "Erorr";
                    }
                }
                else
                {
                    return "nouser";
                }
            }
            catch
            {
                return "Erorr";
            }
            finally
            {
                connection.Close();
            }
        }
    }

}