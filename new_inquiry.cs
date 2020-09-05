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
    public partial class new_inquiry : Form
    {
        public new_inquiry()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }
        // database connection from config.cs
        config o = new config();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Enter Id", "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox4.Focus();
                return;
            }
            if (textBox1.Text == "")
            {

                MessageBox.Show("Enter Inquiry Number", "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox1.Focus();
                return;
            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter Inquiry By", "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                comboBox1.Focus();
                return;
            }

            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Enter Date", "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                dateTimePicker1.Focus();
                return;
            }

            if (comboBox2.Text == "")
            {
                MessageBox.Show("Enter Member Type", "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
               comboBox2.Focus();
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show(" Enter Member Id ", "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
               textBox3.Focus();
                return;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show(" Enter Member First Name ", "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox5.Focus();
                return;
            }

            if (textBox6.Text == "")
            {
                MessageBox.Show(" Enter Member Last Name ", "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox6.Focus();
                return;
            }

            if (textBox7.Text == "")
            {
                MessageBox.Show("Enter Contact Number ", "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox7.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter Message ", "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox2.Focus();
                return;
            }
            // add details to database table
            string SQL = "INSERT INTO add_inquiry (Id,inquiry_number,inquiry_by,date,member_type,first_name,last_name,contact_number,message,member_id) VALUES ('" + textBox4.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Value.Date.ToShortDateString() + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";

            string status = o.AddDBRec(SQL);

            if (status == "Success")
            {
                MessageBox.Show("Records Added Successfully", "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(String.Format("Records Added Failed! " ), "SARASAVI LIBRARY::Add Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
