﻿using System;
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
    public partial class search_member : Form
    {
        public search_member()
        {
            InitializeComponent();
        }
        // database connection from config.cs
        config o = new config();
        private void search_member_Load(object sender, EventArgs e)
        {
            // show all columns  and details in database tables
            o.loadgrid("SELECT * FROM library_member", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")
                {
                    o.loadgrid("SELECT * FROM library_member", dataGridView1);
                }
                else
                {

                    // search by
                    o.loadgrid("SELECT * FROM library_member WHERE   member_number LIKE '" + textBox1.Text + "%' OR first_name LIKE '" + textBox1.Text + "%' OR last_name LIKE '" + textBox1.Text + "%' OR contact_number LIKE '" + textBox1.Text + "%' OR address LIKE '" + textBox1.Text + "%' OR gender LIKE '" + textBox1.Text + "%' OR date_of_birth LIKE '" + textBox1.Text + "%'", dataGridView1);

                }
            }
        }
    }
}