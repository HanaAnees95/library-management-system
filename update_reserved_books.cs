using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sarasavi_library_management_system
{
    public partial class update_reserved_books : Form
    {
        public update_reserved_books()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        // database connection from config.cs
        config conf = new config();
        private void update_reserved_books_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // edit table data
            string SQL = "UPDATE reserve_book SET " +
                "reservation_number= '" + textBox4.Text + "', " +
                "reserved_date= '" + dateTimePicker2.Value.Date.ToShortDateString() + "', " +
                "message = '" + textBox1.Text + "', " +
                "book_id = '" + textBox2.Text + "', " +
                "member_id = '" + textBox3.Text + 
                "' WHERE id  ='" + textBox5.Text + "';";

            string responce = conf.RunUpdateQ(SQL);

           MessageBox.Show(responce);
            {

                if
                        (responce == "Success")
                {
                    MessageBox.Show("Records Updated Successfull", "SARASAVI LIBRARY::Update Reserved Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Records Updated Failed!", "SARASAVI LIBRARY::Update Reserved Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }


        }



        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Enter Search Id", "SARASAVI LIBRARY::Update Reserved Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox5.Focus();
                    return;
                }
                else
                {


                    // 
                    DataRow ReadData = conf.FetchRec("reserve_book", "id", textBox5.Text);
                    //MessageBox.Show(ReadData[1].ToString());

                    if (ReadData == null)
                    {
                        MessageBox.Show("Reservation Id not Found!");
                    }
                    else {

                        // show database table data
                        textBox4.Text = ReadData[1].ToString();
                        dateTimePicker2.Value = DateTime.Parse(ReadData[2].ToString());
                        textBox1.Text = ReadData[3].ToString();
                        textBox2.Text = ReadData[4].ToString();
                        textBox3.Text = ReadData[5].ToString();
                    }
                }
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}