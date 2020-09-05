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
    public partial class reserve_book_details : Form
    {
        public reserve_book_details()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //config o = new config();
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
                
        //        string sql = "INSERT INTO reserve_book (reservation_number,reserved_date,message,member_id,book_id) VALUES ('" + textBox4.Text + "','" + dateTimePicker2.Value.Date.ToShortDateString() + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')";
        //        SqlCommand cmd = new SqlCommand(sql, o);
        //        cmd.ExecuteNonQuery();
        //        label7.ForeColor = Color.Green;
        //        label7.Text = "Data Stored";
        //    }
        //    catch (Exception x)
        //    {
        //        label7.ForeColor = Color.Red;
        //        label7.Text = x.Message;
        //    }
        //}

        private void button2_Click_1(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }

        private void reserve_book_details_Load(object sender, EventArgs e)
        {

        }
        // database connection from config.cs
        config o = new config();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Enter Reserve Id", "SARASAVI LIBRARY:: Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox5.Focus();
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Enter Reserve Number", "SARASAVI LIBRARY:: Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox4.Focus();
                return;
            }
        
            if (dateTimePicker2.Text == "")
            {
                MessageBox.Show ("Enter Reservation Date", "SARASAVI LIBRARY::Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show  (String.Format("Records Added Failed! SARASAVI LIBRARY::Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                dateTimePicker2.Focus();
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Message ", "SARASAVI LIBRARY::Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox1.Focus();
                return;
            }


            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter Book Id ", "SARASAVI LIBRARY::Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter Member Id ", "SARASAVI LIBRARY::Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Reserve Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox3.Focus();
                return;
            }
            // insert records to database tables

            string SQL = "INSERT INTO reserve_book (id,reservation_number,reserved_date,message,book_id,member_id) VALUES ('" + textBox5.Text + "', '" + textBox4.Text + "' ,'" + dateTimePicker2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            string status = o.AddDBRec(SQL);

            if (status == "Success")
            {
                MessageBox.Show("Records Added Successfull", "SARASAVI LIBRARY::Reservation Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Records Added Failed!", "SARASAVI LIBRARY::Reservation  Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }
    }
    }


