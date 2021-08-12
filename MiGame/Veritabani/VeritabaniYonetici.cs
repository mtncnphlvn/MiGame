using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace MiGame
{
    class VeritabaniYonetici:Veritabani
    {
        MySqlConnection connection;

        public VeritabaniYonetici()
        {
            connection = new MySqlConnection("Server='" + server + "';Database='" + veritabani + "';Uid='" + root + "';Pwd='" + password + "';");
        }

        public MySqlConnection OpenConnection()
        {
            connection.Open();
            return connection;
        }
        public MySqlConnection CloseConnection()
        {
            connection.Close();
            return connection;
        }
    }
}
