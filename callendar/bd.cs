using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callendar
{
    internal class bd
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;ssername=root;password=root;database=aut");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

        }

        public void ClosenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

        }


        public MySqlConnection getConnection()
        {
            return connection;
        }


    }
}
