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
    public partial class add_books : Form
    {
        // database connection from config.cs
        config conf = new config();

        public add_books()
        {
            InitializeComponent();
        }

        private void add_books_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
 

         }
        config o = new config();
        private void button1_Click_1(object sender, EventArgs e)
        {
            // if else statement
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Accession Number", "SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {

                MessageBox.Show("Enter Book Title", "SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter ISBN NO", "SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox3.Focus();
                return;
            }

            if (textBox4.Text == "")
            {
                MessageBox.Show("Enter Book Author", "SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox4.Focus();
                return;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show("Enter Book Book Publisher", "SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                textBox5.Focus();
                return;
            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter Book Classification", "SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                comboBox1.Focus();
                return;
            }

            if (comboBox2.Text == "")
            {
                MessageBox.Show("Enter Book Part", "SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                comboBox2.Focus();
                return;
            }

            if (comboBox3.Text == "")
            {
                MessageBox.Show("Enter Book Type", "SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                comboBox3.Focus();
                return;
            }


            if (comboBox4.Text == "")
            {
                MessageBox.Show("Enter Status", "SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(String.Format("Records Added Failed! SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error));
                comboBox4.Focus();
                return;
            }
            int count = config.ReadCount1(textBox1.Text);

            if (count <= 9)

            {

                // add records to database table
                string SQL = "INSERT INTO BOOK_DETAILS (Accession_Number,Book_Title,ISBN_NO,Book_Author,Book_Publisher,Book_Classification,Book_Part,Book_Type,Status) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "')";

                string status = o.AddDBRec(SQL);

                if (status == "Success")
                {
                    MessageBox.Show("Records  Successfully Added", "SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(String.Format("Records Added Failed! "), "SARASAVI LIBRARY::Add Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (count == 10)
            {
                MessageBox.Show("Operation Failed!", "SARASAVI LIBRARY::Add  Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            private void button2_Click_1(object sender, EventArgs e)
            {
                // form close
                this.Close();
            }

            private void label1_Click_1(object sender, EventArgs e)
            {

            }

            private void label11_Click_1(object sender, EventArgs e)
            {

            }

            private void add_books_Load_1(object sender, EventArgs e)
            {

            }
        }
}

