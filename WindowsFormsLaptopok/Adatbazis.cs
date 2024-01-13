using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace WindowsFormsLaptopok
{

    internal class Adatbazis
    {
        MySqlConnection conn;
        MySqlCommand sql;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = ConfigurationManager.AppSettings.Get("databaseHost");
            sb.UserID = ConfigurationManager.AppSettings.Get("databaseUser");
            sb.Password = ConfigurationManager.AppSettings.Get("databasePassword");
            sb.Database = ConfigurationManager.AppSettings.Get("databaseName");
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            sql = conn.CreateCommand();
            try
            {
                kapcsolatnyit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatcsuk();
            }

        }
        void kapcsolatnyit()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }
        void kapcsolatcsuk()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        public List<Laptop> getAllLaptops()
        {
            List<Laptop> laptopok = new List<Laptop>();
            try
            {
                kapcsolatnyit();
                sql.CommandText = "SELECT * FROM laptopok";
                MySqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    ulong laptopId = (ulong)reader["laptopId"];
                    string marka = reader["marka"].ToString();
                    string modell = reader["modell"].ToString();
                    string szin = reader["szin"].ToString();
                    string processzor = reader["processzor"].ToString();
                    int memoria = (int)reader["memoria"];
                    int kepernyomeret = (int)reader["kepernyomeret"];
                    string felbontas = reader["felbontas"].ToString();
                    int merevlemezkapacitas = (int)reader["merevlemezkapacitas"];
                    int ar = (int)reader["ar"];
                    Laptop laptop = new Laptop(laptopId, marka, szin, processzor, memoria, kepernyomeret, felbontas, merevlemezkapacitas, ar, modell);
                    laptopok.Add(laptop);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatcsuk();
            }
            return laptopok;
        }
    }
}
