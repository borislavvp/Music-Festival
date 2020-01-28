using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BackStage
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
        public string GetWinnerFirstName(string user_rfid)
        {
            try
            {
                userId = GetUserIdWithRfid(user_rfid);

                string name = "";
                string sql = $@"SELECT * FROM tombolawinner where UserID = '{userId}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return "error";
                }
                reader.Close();
                sql = $@"SELECT first_name FROM user where RFID = '{user_rfid}';";
                command = new MySqlCommand(sql, connection);
                reader = command.ExecuteReader();
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
        public string UpdateUserBalance(int award,int ID)
        {
            try
            {
                string sql = $@"SELECT * FROM eventacc where User_userID = '{ID}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return "error";
                }
                else
                {
                    reader.Close();
                    int balance = 0;
                    sql = $@"SELECT balance FROM eventacc where User_userID = '{ID}';";
                    command = new MySqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        balance = Convert.ToInt32(reader[0].ToString()) + award;
                    }
                    reader.Close();
                    sql = $@"UPDATE eventacc SET balance = '{balance}' WHERE User_userID= '{ID}' ; ";
                    command = new MySqlCommand(sql, connection);

                    int number = 0;

                    number = Convert.ToInt32(command.ExecuteNonQuery());
                    if (number != 0)
                    {
                        return "updated";
                    }
                    else
                    {
                        return "error";
                    }
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
