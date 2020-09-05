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
    public partial class search_book : Form
    {
        public search_book()
        {
            InitializeComponent();
        }
        // database connection from config.cs
        config o = new config();
        private void search_book_Load(object sender, EventArgs e)
        {
            // show all columns  and details in database tables
            o.loadgrid("SELECT * FROM BOOK_DETAILS", dataGridView1);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           if (textBox1.Text == "")
            {
                o.loadgrid("SELECT * FROM BOOK_DETAILS", dataGridView1);
            }
           else
            {
                // search by
                o.loadgrid("SELECT * FROM BOOK_DETAILS  WHERE Book_Title LIKE '"+textBox1.Text+ "%' OR Accession_Number LIKE '" + textBox1.Text + "%' OR ISBN_NO LIKE '" + textBox1.Text + "%' OR Book_Type LIKE '" + textBox1.Text + "%' OR Book_Part LIKE '" + textBox1.Text + "%' OR Book_Classification LIKE '" + textBox1.Text + "%' OR Book_Publisher LIKE '" + textBox1.Text + "%' OR Book_Author LIKE '" + textBox1.Text + "%' OR Book_Part LIKE '" + textBox1.Text + "%'", dataGridView1);
            }
        }

        private void dataGridView1_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void search_book_Load_1(object sender, EventArgs e)
        {
            o.loadgrid("SELECT * FROM BOOK_DETAILS", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
