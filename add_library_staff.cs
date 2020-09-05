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
    public partial class add_library_staff : Form
    {
        public add_library_staff()
        {
            InitializeComponent();
        }
        // database connection from config.cs
        config o = new config();
        private void button1_Click(object sender, EventArgs e)
        {
            // if else statement
            if (textBox10.Text == "")
            {
                MessageBox.Show("Enter Staff Id", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox10.Focus();
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Staff Number", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter First Name", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter  Last Name", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox3.Focus();
                return;
            }

            if (textBox4.Text == "")
            {
                MessageBox.Show("Enter Contact Number", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox4.Focus();
                return;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show("Enter Address", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox5.Focus();
                return;
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter Gender ", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                comboBox1.Focus();
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Enter Date of Birth", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox6.Focus();
                return;
            }

            if (textBox7.Text == "")
            {
                MessageBox.Show("Enter Password", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox7.Focus();
                return;
            }

            if (textBox8.Text == "")
            {
                MessageBox.Show("Enter Repeat Password", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox8.Focus();
                return;
            }

            // add records to database table  
            string SQL = "INSERT INTO add_library_staff (Id,staff_number,first_name,last_name,contact_number,address,gender,date_of_birth,password,repeat_password) VALUES ('" + textBox10.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            string status = o.AddDBRec(SQL);

            if (status == "Success")
            {
                MessageBox.Show("Records Added Successfully", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Records Added Failed!", "SARASAVI LIBRARY::Add Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == textBox8.Text)
            {
                textBox8.BackColor = Color.Green;
            }
            else
            {
                textBox8.BackColor = Color.Pink;
            }
        }
    }
}