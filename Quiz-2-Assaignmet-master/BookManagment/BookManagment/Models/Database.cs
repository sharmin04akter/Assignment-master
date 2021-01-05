using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagment.Models
{
    class Database
    {
        public Books Books { get; set; }

        public Database()
        {
            string connString= "Server=DESKTOP-S8F6A9P;Database=Book_info;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            Books = new Books(conn);
        }
    }
}
