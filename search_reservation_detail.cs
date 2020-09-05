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
    public partial class search_reservation_detail : Form
    {
        public search_reservation_detail()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        // database connection from config.cs
        config o = new config();
        private void search_inquiry_details_Load(object sender, EventArgs e)
        {
            // show all columns  and details in database tables
            o.loadgrid("SELECT * FROM  reserve_book", dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")
                {
                    o.loadgrid("SELECT * FROM reserve_book", dataGridView1);
                }
                else
                {

                    // search by
                    o.loadgrid("SELECT * FROM reserve_book  WHERE reservation_number LIKE '" + textBox1.Text + "%' OR reserved_date LIKE '" + textBox1.Text + "%' OR message LIKE '" + textBox1.Text + "%'", dataGridView1);
                }
            }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

