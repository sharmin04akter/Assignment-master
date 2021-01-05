using BookManagment.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagment.Controllers
{
    class BookController
    {
        static Database db = new Database();

        public static ArrayList GetAllBook()
        {
            return db.Books.GetAllBook();
        }

        public static ArrayList GetBook(string username)
        {
            return db.Books.GetBook(username);
        }
    }
}
