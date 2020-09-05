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
    public partial class search_return_details : Form
    {
        public search_return_details()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        config o = new config();
        private void search_return_details_Load(object sender, EventArgs e)
        {
            o.loadgrid("SELECT * FROM return_details", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")
                {
                    o.loadgrid("SELECT * FROM return_details", dataGridView1);
                }
                else
                {
                    o.loadgrid("SELECT * FROM return_details  WHERE  return_date LIKE '" + textBox1.Text + "%' OR status LIKE '" + textBox1.Text + "%'",  dataGridView1);
                }
            }
        }
    }
}