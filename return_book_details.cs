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
    public partial class return_book_details : Form
    {
        public return_book_details()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        // database connection from config.cs
        config o = new config();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Enter Return Id", "SARASAVI LIBRARY:: Return Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox4.Focus();
                return;
            }

            if (dateTimePicker2.Text == "")
            {
                MessageBox.Show("Enter Return Date", "SARASAVI LIBRARY:: Return Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                dateTimePicker2.Focus();
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Status ", "SARASAVI LIBRARY:: Return Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter Book Id ", "SARASAVI LIBRARY:: Return Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox2.Focus();
                return;
            }


            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter Member Id", "SARASAVI LIBRARY:: Return Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox3.Focus();
                return;
            }


            if (textBox5.Text == "")
            {
                MessageBox.Show("Enter Borrow Id ", "SARASAVI LIBRARY:: Return Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox5.Focus();
                return;
            }

            // insert records to database tables

            string SQL = "INSERT INTO return_details (Id,return_date,status,book_id,member_id,borrow_id) VALUES ('" + textBox4.Text + "','" + dateTimePicker2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
            string status = o.AddDBRec(SQL);

            if (status == "Success")
            {
                MessageBox.Show("Records Added Successfull", "SARASAVI LIBRARY::Return Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Records Added Failed!", "SARASAVI LIBRARY::Return Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void return_book_details_Load(object sender, EventArgs e)
        {

        }
    }
}
