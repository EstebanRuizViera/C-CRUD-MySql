using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Modelo
{
    class Modelo
    {
            public static MySqlConnection GetConnection()
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=libros; Uid=root; pwd=1234;");

                conectar.Open();
                return conectar;
            }
       
    }
}
