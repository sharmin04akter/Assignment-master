using BookManagment.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagment.Views
{
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
            gridBooks.DataSource = BookController.GetAllBook();
           
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            dynamic book = BookController.GetBook(SearchBox.Text);
            
            if (book != null)
            {
                gridBooks.DataSource = BookController.GetBook(SearchBox.Text);
            }
            else
            {
                MessageBox.Show("Book can not be found");
            }
        }
    }
}
