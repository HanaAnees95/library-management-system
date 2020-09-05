using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace sarasavi_library_management_system
{
    public partial class view_books : Form
    {
        public view_books()
        {
            InitializeComponent();
        }
        config o = new config(); 
        private void view_books_Load(object sender, EventArgs e)
        {
            o.loadgrid("SELECT * FROM BOOK_DETAILS", dataGridView1);
        }
    }
}
