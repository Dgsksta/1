using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    internal class Connection
    {
        public static string connectionString = $@"
                                DataBase = up_959810;
                                DataSource = localhost;
                                user = root;
                                Password = Golovin17;
                                charset = utf8;";
        public static MySqlConnection myconnect;
        public static MySqlCommand MySqlCommand;
        public static MySqlDataAdapter MySqlDataAdapter;
        public static bool ConnectBD()
        {
            try
            {
                myconnect = new MySqlConnection(connectionString);
                myconnect.Open();
                MySqlCommand = new MySqlCommand();
                MySqlCommand.Connection = myconnect;
                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к бд");
                return false;
            }
        }
        public static bool CloseBD()
        {
            try
            {
                myconnect.Close();
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка закрытия бд");
                return false;
            }
        }
    }
}
