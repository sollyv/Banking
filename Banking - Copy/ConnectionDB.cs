using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Banking
{
    internal class ConnectionDB
    {
        public string GetConnection()
        {
            string con = @"Data Source=LIBERTIES90\SQLEXPRESS;Initial Catalog=passwords;Integrated Security=True";
            return con;
        }
    }
}
