using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SystemEnter
{
    class Datahelper
    {
        public MySqlConnection connection;
        //Variable to keep the user's id
        public int userId = -1;
        public int employeeId = -1;
        public Datahelper()
        {
            string connectionInfo = "server=studmysql01.fhict.local;" +
                               "database=dbi416657;" +
                               "user id=dbi416657;" +
                               "password=hera.fhict;" +
                               "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }
        public string registerWinner(int id)
        {
            try
            {
                if (id != 0)
                {
                    string sql = $@"UPDATE tombolawinner SET UserID = '{id}' WHERE 1 ; ";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    connection.Open();
                    int number = 0;

                    number = Convert.ToInt32(command.ExecuteNonQuery());
                    if (number != 0)
                    {
                        return "ok";
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
                return "Erorr";
            }
            finally
            {
                connection.Close();
            }
        }
        public List<string> GetJobIDs()
        {
            try
            {
                List<string> jobIds = new List<string>();
                string sql = $@"SELECT JOB_ID FROM jobs;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return null;
                }
                while (reader.Read())
                {
                    jobIds.Add(reader[0].ToString());
                }
                reader.Close();
                return jobIds;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public string RegisterEmployee(string first_name,string jobID,string email,int salary,string phone)
        {
            try
            {
                string sql = $@"SELECT MAX(EMPLOYEE_ID) FROM employees;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return "error";
                }
                while (reader.Read())
                {
                    employeeId = Convert.ToInt32(reader[0].ToString()) + 1;
                }
                reader.Close();
              
                sql = $@"INSERT INTO employees (EMPLOYEE_ID,FIRST_NAME,JOB_ID,PHONE_NUMBER,SALARY,EMAIL,HIRE_DATE)
                      VALUES ('{employeeId}', '{first_name}', '{jobID}', '{phone}' , '{salary}' , '{email}', '{System.DateTime.Today}')";
                command = new MySqlCommand(sql, connection);
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                if (nrOfRecordsChanged > 0)
                {
                    return "registered";
                }
                else
                {
                    return "error";
                }

            }
            catch (Exception)
            {
                return "error";
            }
            finally
            {
                connection.Close();
            }
        }

        public string GiveRfidToEmployee(string rfid)
        {
            try
            {
                string sql = $@"UPDATE employees SET RFID = '{rfid}' WHERE EMPLOYEE_ID = '{employeeId}' ;";

                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                int number = 0;
                number = Convert.ToInt32(command.ExecuteNonQuery());
                if (number != 0)
                {
                    return "ok";
                }
                else
                {
                    return "error";
                }
            }
            catch (Exception)
            {
                return "error";
            }
            finally
            {
                connection.Close();
            }
        }

        public string GetEmployeeName(string rfid)
        {
            try
            {
                string name = "";
                string sql = $@"SELECT FIRST_NAME FROM employees WHERE RFID = '{rfid}' ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return "error";
                }
                while (reader.Read())
                {
                    name = reader[0].ToString();
                }
                reader.Close();
                return name;
            }
            catch (Exception)
            {
                return "error";
            }
            finally
            {
                connection.Close();
            }
        }

        public string GetEmployeeJobId(string rfid)
        {
            try
            {
                string job_id = "";
                string sql = $@"SELECT JOB_ID FROM employees WHERE RFID = '{rfid}' ;";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    return "no";
                }
                while (reader.Read())
                {
                    job_id = reader[0].ToString();
                }
                reader.Close();
                return job_id;
            }
            catch (Exception)
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
