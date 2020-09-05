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
    public partial class update_return_details : Form
    {
        public update_return_details()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // edit table data
            string SQL = "UPDATE return_details SET " +
                "return_date = '" + dateTimePicker2.Value.Date.ToShortDateString() + "', " +
                "status = '" + textBox1.Text + "', " +
                 "book_id = '" + textBox2.Text + "', " +
                 "member_id = '" + textBox3.Text + "', " +
                 "borrow_id= '" + textBox4.Text + 
               "' WHERE Id  ='" + textBox5.Text + "';";

            string responce = conf.RunUpdateQ(SQL);

            MessageBox.Show(responce);
            {

                if
                        (responce == "Success")
                {
                    MessageBox.Show("Records Updated Successfull", "SARASAVI LIBRARY::Update Return Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Records Updated Failed!", "SARASAVI LIBRARY::Update Return Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }
        // database connection from config.cs
        config conf = new config();
        private void update_return_details_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Enter Search Id", "SARASAVI LIBRARY::Update Return Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox5.Focus();
                    return;
                }
                else
                {


                    // 
                    DataRow ReadData = conf.FetchRec("return_details", "Id", textBox5.Text);
                    //MessageBox.Show(ReadData[1].ToString());

                    if (ReadData == null)
                    {
                        MessageBox.Show("Return Id not Found!");
                    }
                    else {

                        // show database table data
                        dateTimePicker2.Value = DateTime.Parse(ReadData[1].ToString());
                        textBox1.Text = ReadData[2].ToString();
                        textBox2.Text = ReadData[3].ToString();
                        textBox3.Text = ReadData[4].ToString();
                        textBox4.Text = ReadData[5].ToString();

                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}


