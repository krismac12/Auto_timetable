using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace WinFormsApp1
{
    class KeyDB
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=schedix-db.cssjh7thmdbg.ap-southeast-2.rds.amazonaws.com; port =3306;username=admin;password=Schedix253!;database=AutoTable";

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
            bool login = false;
            MySqlConnection connection = GetConnection();
            try
            {

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            string sql = "Select * From Users where PassKey = @key;";
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
            connection.Close();
            return login;

        }
    }
}
