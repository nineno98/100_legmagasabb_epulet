using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace _100_legmagasabb_GUI
{
    class ConnectToDatabase
    {
        private string sqlStatement;
        MySqlConnection dbconn;
        
        MySqlDataReader reader;
        public ConnectToDatabase()
        {
            kapcsolat();
        }

        private void kapcsolat()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.Database = "epulet";
            sb.UserID = "root";
            sb.Password = "";

            dbconn = new MySqlConnection(sb.ToString());
        }

        public List<Epulet> EpuletekSelect()
        {
            List<Epulet> epuletek = new List<Epulet>();
            sqlStatement = "SELECT rang, nev, hely, magassag, magassag_ft, emelet, epitesi_ev FROM `epuletek` ORDER BY rang ASC;";

            try
            {
                dbconn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = dbconn;
                command.CommandText = sqlStatement;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Epulet ep = new Epulet(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetInt32(5), reader.GetInt32(6));
                    epuletek.Add(ep);
                }

                dbconn.Close();
                return epuletek;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
