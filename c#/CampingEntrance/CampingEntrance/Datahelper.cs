using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace CampingEntrance
{

    class Datahelper
    {
        public MySqlConnection connection;
        public int userId = -1;
        public List<string> spots;
        public Datahelper()
        {
            string connectionInfo = "server=studmysql01.fhict.local;" +
                               "database=dbi416657;" +
                               "user id=dbi416657;" +
                               "password=hera.fhict;" +
                               "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }

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

        public string GetUserFirstNameWithIdNumber(int id)
        {
            try
            {
                string name = "";
                string sql = $@"SELECT first_name FROM user where idUser = '{id}';";
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

        public string GetCampingStatusWithRfid(string user_rfid)
        {
            try
            {
                string exist = "";
                string status = "";
                string sql = $@"SELECT Camping_SpotID,CampingStatus FROM eventacc where User_userID = '{GetUserIdWithRfid(user_rfid)}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    exist = reader[0].ToString();
                    status = reader[1].ToString();
                }
                if (exist != "")
                {
                    if (status == "in")
                    {
                        reader.Close();
                        return "in";
                    }
                    else if (status == "out")
                    {
                        reader.Close();
                        return "out";
                    }
                    else
                    {
                        reader.Close();
                        return "booked camping spot "+ exist ;
                    }
                }
                else
                {
                    reader.Close();
                    return "nocamp";
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

        public string CheckInVisitor()
        {
            try
            {
                
                if (userId != -1)
                {
                
                    string campingStatus = "";
                    string exist = "";
                    string eventStatus = "";
                    string sql = $@"SELECT userStatus,Camping_SpotID,CampingStatus FROM eventacc WHERE User_userID= '{userId}' ; ";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        eventStatus = reader[0].ToString();
                        exist = reader[1].ToString();
                        campingStatus = reader[2].ToString();
                    }
                    if (eventStatus == "in")
                    {
                        if (exist != "")
                        {
                            if (campingStatus == "in")
                            {
                                return "in";
                            }
                        }
                        else
                        {
                            return "nocamp";
                        }
                    }
                    else
                    {
                        return "notatevent";
                    }
                    reader.Close();
                    // Set the visitor's status to in
                    sql = $@"UPDATE eventacc SET CampingStatus = 'in' WHERE User_userID= '{userId}' ; ";
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
                return "error";

            }
            finally
            {

                connection.Close();

            }
        }
        public string CheckOutVisitor()
        {
            try
            {

                if (userId != -1)
                {
                    // Then we check if the visitor is already in the event and if it is we stop
                    string campingStatus = "";
                    string exist = "";
                    string eventStatus = "";
                    string sql = $@"SELECT userStatus,Camping_SpotID,CampingStatus FROM eventacc WHERE User_userID= '{userId}' ; ";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        eventStatus = reader[0].ToString();
                        exist = reader[1].ToString();
                        campingStatus = reader[2].ToString();
                    }
                    if (eventStatus == "in")
                    {
                        if (exist != "")
                        {
                            if (campingStatus == "out")
                            {
                                return "out";
                            }
                        }
                        else
                        {
                            return "nocamp";
                        }
                    }
                    else
                    {
                        return "notatevent";
                    }
                    
                    reader.Close();
                    // Set the visitor's status to in
                    sql = $@"UPDATE eventacc SET CampingStatus = 'out' WHERE User_userID= '{userId}' ; ";
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
                return "error";

            }
            finally
            {

                connection.Close();

            }
        }
        public void CheckAvailableCampingSpots()
        {
            spots = new List<string>();
            try
            {
                
                string sql = $@"SELECT SpotID FROM camping WHERE Booked = '0';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    spots.Add(reader[0].ToString());
                }
                reader.Close();
            }
            catch
            {
                string error = "Error";
            }
            finally
            {
                connection.Close();
            }
        }


        public string RegisterCampingGroup(int visitor1Id,int visitor2Id,int visitor3Id,int visitor4Id,int visitor5Id,int visitor6Id,int spotId)
        {
            try
            {
                List<int> ids = new List<int>();
                ids.Add(visitor1Id);
                ids.Add(visitor2Id);
                ids.Add(visitor3Id);
                ids.Add(visitor4Id);
                ids.Add(visitor5Id);
                ids.Add(visitor6Id);

                string process = "";

                for (int i = 0; i < ids.Count(); i++)
                {
                    int visitorBalance = 0;
                    string sql = $@"SELECT balance FROM eventacc WHERE User_userID = '{ids[i]}';";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader[0].ToString() != "")
                        {
                            visitorBalance = Convert.ToInt32(reader[0].ToString());
                        }
                    }
                    reader.Close();
                    if (visitorBalance >= 50)
                    {
                        visitorBalance = visitorBalance - 50;
                        int moneySepntToAdd = 0;
                        sql = $@"SELECT SpentMoney FROM eventacc WHERE User_userID = '{ids[i]}';";
                        command = new MySqlCommand(sql, connection);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader[0].ToString() != "")
                            {
                                moneySepntToAdd = Convert.ToInt32(reader[0].ToString()) + 60;
                            }
                            else
                            {
                                moneySepntToAdd = 50;
                            }
                        }
                        reader.Close();
                        sql = $@"UPDATE eventacc SET CampingStatus = 'in',Camping_SpotID = '{spotId}'
                             WHERE User_userID = '{ids[i]}'; ";
                        command = new MySqlCommand(sql, connection);

                        int number = 0;

                        number = Convert.ToInt32(command.ExecuteNonQuery());
                        if (number != 0)
                        {
                            sql = $@"UPDATE eventacc SET SpentMoney = '{moneySepntToAdd}',balance = '{visitorBalance}' WHERE User_userID = '{ids[i]}'; ";
                            command = new MySqlCommand(sql, connection);

                            number = 0;

                            number = Convert.ToInt32(command.ExecuteNonQuery());
                            if (number != 0)
                            {
                                sql = $@"UPDATE camping SET Booked = '1' WHERE SpotID = '{spotId}'; ";
                                command = new MySqlCommand(sql, connection);

                                number = 0;

                                number = Convert.ToInt32(command.ExecuteNonQuery());
                                if (number != 0)
                                {
                                    process = "ok";
                                }
                                else
                                {
                                    process = "Error";
                                    break;
                                }
                            }
                            else
                            {
                                process = "Error";
                                break;
                            }
                        }
                        else
                        {
                            process = "Error";
                            break;
                        }
                    }
                    else
                    {
                        int count = 0;

                        for (int j = 0; j < i; j++)
                        {
                            if (ids[j] == ids[i])
                            {
                                count++;
                            }
                        }
                        connection.Close();
                        if (count == 0)
                        {
                            process += GetUserFirstNameWithIdNumber(ids[i]) + ",";
                        }
                    }
                }

                if (process == "ok")
                {
                    string sql = $@"UPDATE camping SET Booked = '1' WHERE SpotID = '{spotId}'; ";
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    int number = 0;

                    number = Convert.ToInt32(command.ExecuteNonQuery());
                    if (number != 0)
                    {
                        return "registered";
                    }
                    else
                    {
                        return process;
                    }
                }
                else if(process == "Error")
                {
                    return "Error";
                }
                else
                {
                    int end = process.LastIndexOf(',');

                    return process.Substring(0,end).Replace(","," and ") + " : not enough balance";
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
