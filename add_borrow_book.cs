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
    public partial class add_borrow_book : Form
    {
        public add_borrow_book()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
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
            // if else statement
            if (textBox4.Text == "")
            {
                MessageBox.Show("Enter Borrow Id", "SARASAVI LIBRARY:: Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox4.Focus();
                return;
            }
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Enter Borrow Date ", "SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                dateTimePicker1.Focus();
                return;
            }
            if (dateTimePicker2.Text == "")
            {
                MessageBox.Show("Enter Return Date", "SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                dateTimePicker2.Focus();
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Status ", "SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox1.Focus();
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter Book Id ", "SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox3.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter Member Id ", "SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox2.Focus();
                return;
            }
            {


                int count = config.ReadCount(textBox2.Text);

                if (count <= 4)

                {
                    //code for add records to database


                   string SQL = "INSERT INTO Borrow_Details (Id,Borrow_Date,Return_Date,Status,Book_Id,Member_Id) VALUES ('" + textBox4.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )";
                    string status = o.AddDBRec(SQL);
                   


                    if (status == "Success")
                    {
                        MessageBox.Show("Records Added Successfull", "SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Records Added Failed!", "SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (count == 5)
                {
                        MessageBox.Show("Operation Failed!", "SARASAVI LIBRARY::Borrow Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
            }
        }
        
       
       
    }
    

