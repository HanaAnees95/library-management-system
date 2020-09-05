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
    public partial class search_all_members : Form
    {
        public search_all_members()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        config o = new config();
        private void search_all_members_Load(object sender, EventArgs e)
        {
            o.loadgrid("SELECT * FROM library_visitor", dataGridView1);
           o.loadgrid("SELECT * FROM library_member", dataGridView1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")
                {
                    o.loadgrid("SELECT * FROM library_visitor", dataGridView1);
                   o.loadgrid("SELECT * FROM library_member", dataGridView1); 

                }
                else
                {
                   o.loadgrid("SELECT * FROM library_visitor WHERE   visitor_number LIKE '" + textBox1.Text + "%' OR first_name LIKE '" + textBox1.Text + "%' OR last_name LIKE '" + textBox1.Text + "%' OR contact_number LIKE '" + textBox1.Text + "%' OR address LIKE '" + textBox1.Text + "%' OR gender LIKE '" + textBox1.Text + "%' OR date_of_birth LIKE '" + textBox1.Text + "%' OR NIC_no LIKE '" + textBox1.Text + "%'", dataGridView1);
                    o.loadgrid("SELECT * FROM library_member WHERE   member_number LIKE '" + textBox1.Text + "%' OR first_name LIKE '" + textBox1.Text + "%' OR last_name LIKE '" + textBox1.Text + "%' OR contact_number LIKE '" + textBox1.Text + "%' OR address LIKE '" + textBox1.Text + "%' OR gender LIKE '" + textBox1.Text + "%' OR date_of_birth LIKE '" + textBox1.Text + "%'", dataGridView1);
                   
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
