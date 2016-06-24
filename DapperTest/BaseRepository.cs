using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebApi1.Respositories
{
    public class BaseRepository
    {
        public static MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection("Data Source=172.0.0.1;Initial Catalog=dappertest;Persist Security Info=True;User ID=root;Password=ganggang");
            connection.Open();
            return connection;
        }
    }
}