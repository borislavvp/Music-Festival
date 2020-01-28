using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DBConnectTest
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        string connectionInfo;
        string userIDs = "SELECT idUser FROM user WHERE first_name = 'asd'";

        public Form1()
        {
            InitializeComponent();
            connectionInfo = "server   = studmysql01.fhict.local;" +
                             "database = dbi416657;" +
                             "userid   = dbi416657;"  +
                             "password = asdasdasd1;" +
                             "connect timeout=30;";
           
            connection = new MySqlConnection(connectionInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand(userIDs, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0]);
            }
            connection.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
