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
    public partial class search_inquiry : Form
    {
        public search_inquiry()
        {
            InitializeComponent();
        }
        // database connection from config.cs
        config o = new config();
        private void search_inquiry_Load(object sender, EventArgs e)
        {
            // show all columns  and details in database tables
            o.loadgrid("SELECT * FROM add_inquiry", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")
                {
                    o.loadgrid("SELECT * FROM add_inquiry", dataGridView1);
                }
                else
                {

                    // search by
                    o.loadgrid("SELECT * FROM add_inquiry  WHERE    inquiry_number LIKE '" + textBox1.Text + "%' OR inquiry_by LIKE '" + textBox1.Text + "%' OR date LIKE '" + textBox1.Text + "%' OR member_type LIKE '" + textBox1.Text + "%' OR  first_name LIKE '" + textBox1.Text + "%' OR last_name LIKE '" + textBox1.Text + "%' OR contact_number LIKE '" + textBox1.Text + "%' OR message LIKE '" + textBox1.Text + "%'", dataGridView1);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
