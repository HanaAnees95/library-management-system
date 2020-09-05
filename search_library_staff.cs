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
    public partial class search_library_staff : Form
    {
        public search_library_staff()
        {
            InitializeComponent();
        }
        config o = new config();
        private void search_library_staff_Load(object sender, EventArgs e)
        {
            o.loadgrid("SELECT * FROM add_library_staff", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")
                {
                    o.loadgrid("SELECT * FROM add_library_staff", dataGridView1);
                }
                else
                {

                    o.loadgrid("SELECT * FROM add_library_staff WHERE   staff_number LIKE '" + textBox1.Text + "%' OR first_name LIKE '" + textBox1.Text + "%' OR last_name LIKE '" + textBox1.Text + "%' OR contact_number LIKE '" + textBox1.Text + "%' OR address LIKE '" + textBox1.Text + "%' OR gender LIKE '" + textBox1.Text + "%' OR date_of_birth LIKE '" + textBox1.Text + "%' OR password LIKE '" + textBox1.Text + "%' OR repeat_password LIKE '" + textBox1.Text + "%'", dataGridView1);
                }
            }
        }
    }
}
