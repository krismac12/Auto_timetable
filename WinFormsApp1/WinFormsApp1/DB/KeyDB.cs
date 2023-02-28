using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class KeyDB
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=sql12.freesqldatabase.com;port=3306;username=sql12598818;password=5nZGNzw9LH;database=sql12598818";

            MySqlConnection connection = new MySqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static bool Login(string Key)
        {
            bool login = true;
            MySqlConnection connection = GetConnection();
            try
            {

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                connection.Close();
            }
            /*string sql = "Select * From Users where PassKey = @key;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@key", MySqlDbType.VarChar).Value = Key;


            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    connection.Close();
                    login = true;
                }
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                return login;
            }
            connection.Close();*/
            login = true;
            return login;

        }
    }
}
