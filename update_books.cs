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
    public partial class update_books : Form
    {
        public update_books()
        {
            InitializeComponent();
        }


        // database connection from config.cs
        config conf = new config();
        private void update_books_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox6.Text == "")
                {
                    MessageBox.Show("Enter Search Id", "SARASAVI LIBRARY::Update Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox6.Focus();
                    return;
                }
                else
                {



                    DataRow ReadData = conf.FetchRec("BOOK_DETAILS", "ID", textBox6.Text);
                    //MessageBox.Show(ReadData[1].ToString());

                    if (ReadData == null)
                    {
                        MessageBox.Show("Book Id not Found!");
                    }
                    else {
                        // show database table data
                        textBox1.Text = ReadData[1].ToString();
                        textBox2.Text = ReadData[2].ToString();
                        textBox3.Text = ReadData[3].ToString();
                        textBox4.Text = ReadData[4].ToString();
                        textBox5.Text = ReadData[5].ToString();
                        comboBox1.Text = ReadData[6].ToString();
                        comboBox2.Text = ReadData[7].ToString();
                        comboBox3.Text = ReadData[8].ToString();
                        comboBox4.Text = ReadData[8].ToString();
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // edit table data
            string SQL = "UPDATE BOOK_DETAILS SET " +
                "Accession_Number = '" + textBox1.Text + "', " +
                "Book_Title= '" + textBox2.Text + "', " +
                "ISBN_No = '" + textBox3.Text + "', " +
                "Book_Author = '" + textBox4.Text + "', " +
                "Book_Publisher = '" + textBox5.Text + "', " +
                "Book_Classification = '" + comboBox1.Text + "', " +
                "Book_Part = '" + comboBox2.Text + "', " +
                "Book_Type = '" + comboBox3.Text + "', " +
                 "Status = '" + comboBox4.Text +
                "' WHERE ID='" + textBox6.Text + "';";

            string responce = conf.RunUpdateQ(SQL);

           MessageBox.Show(responce);
            {

                if
                        (responce == "Success")
                {
                    MessageBox.Show("Records Updated Successfull", "SARASAVI LIBRARY::Update Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Records Updated Failed!", "SARASAVI LIBRARY::Update Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
            