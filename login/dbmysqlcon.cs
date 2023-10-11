using MySql.Data.MySqlClient;
using System;

namespace login
{
    class dbmysqlcon
    {
        MySqlConnection connection = new MySqlConnection("server=sql11.freesqldatabase.com;port=3306;username=sql11472017;password=2vHmLNemcA;database=sql11472017");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }

}
