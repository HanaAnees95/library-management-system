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
    public partial class add_library_visitor : Form
    {
        public add_library_visitor()
        {
            InitializeComponent();
        }

        private void add_library_visitor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // database connection from config.cs
        config o = new config();
        private void button1_Click(object sender, EventArgs e)


        {
            // if else statement
            if (textBox7.Text == "")
            {
                MessageBox.Show("Enter visitor Id", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox7.Focus();
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Visitor Number", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter First Name", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter  Last Name", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox3.Focus();
                return;
            }

            if (textBox4.Text == "")
            {
                MessageBox.Show("Enter Contact Number", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox4.Focus();
                return;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show("Enter Address", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox5.Focus();
                return;
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter Gender", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                comboBox1.Focus();
                return;
            }

            if (textBox6.Text == "")
            {
                MessageBox.Show("Enter Date of Birth", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox6.Focus();
                return;
            }

            if (textBox10.Text == "")
            {
                MessageBox.Show("Enter NIC NO", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox10.Focus();
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Enter Member Type", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                comboBox2.Focus();
                return;
            }
            // add records to database table
            string SQL = "INSERT INTO library_visitor (Id,visitor_number,first_name,last_name,contact_number,address,gender,date_of_birth,NIC_no,member_type) VALUES ('" + textBox7.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3 + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox10.Text + "','" + comboBox2.Text + "')";
string status = o.AddDBRec(SQL);

            if (status == "Success")
            {
                MessageBox.Show("Records Added Successfully", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Records Added Failed!", "SARASAVI LIBRARY::Add Visitor Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }
    }
}
