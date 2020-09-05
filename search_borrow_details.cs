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
    public partial class search_borrow_details : Form
    {
        public search_borrow_details()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // database connection from config.cs
        config o = new config();
        private void search_borrow_details_Load(object sender, EventArgs e)
        {
            // show all columns  and details in database tables
            o.loadgrid("SELECT * FROM Borrow_Details ", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                {
                    if (textBox1.Text == "")
                    {
                        o.loadgrid("SELECT * FROM Borrow_Details", dataGridView1);
                    }
                    else
                    {

                        // search by
                        o.loadgrid("SELECT * FROM Borrow_Details WHERE  Borrow_Date LIKE '" + textBox1.Text + "%' OR Return_Date LIKE '" + textBox1.Text + "%' OR Status LIKE '" + textBox1.Text + "%'", dataGridView1);


                    }

                }
            }
        }
    }
}
