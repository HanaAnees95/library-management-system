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
    public partial class update_inquiry : Form
    {
        public update_inquiry()
        {
            InitializeComponent();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }
        // database connection from config.cs
        config conf = new config();
        private void button1_Click(object sender, EventArgs e)
        {
            {
                // edit table data
                string SQL = "UPDATE add_inquiry SET " +
                    "inquiry_number = '" + textBox1.Text + "', " +
                    "inquiry_by= '" + comboBox1.Text + "', " +
                    "date = '" + dateTimePicker1.Value.Date.ToShortDateString() + "', " +
                    "member_type = '" + comboBox2.Text + "', " +
                    "first_name = '" + textBox5.Text + "', " +
                    "last_name = '" + textBox6.Text + "', " +
                    "contact_number = '" + textBox7.Text + "', " +
                    "message = '" + textBox2.Text + "', " +
                   "member_id = '" + textBox4.Text +
                    "' WHERE Id  ='" + textBox3.Text + "';";

                string responce = conf.RunUpdateQ(SQL);

                MessageBox.Show(responce);

                {

                    if
                            (responce == "Success")
                    {
                        MessageBox.Show("Records Updated Successfull", "SARASAVI LIBRARY::Update Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Records Updated Failed!", "SARASAVI LIBRARY::Update Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }


            }
        }

        private void update_inquiry_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Enter Search Id", "SARASAVI LIBRARY::Update Inquiry Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox3.Focus();
                    return;
                }
                else
                {

                    // 
                    DataRow ReadData = conf.FetchRec("add_inquiry", "Id", textBox3.Text);
                    //MessageBox.Show(ReadData[1].ToString());

                    if (ReadData == null)
                    {
                        MessageBox.Show("Inquiry Id not Found!");
                    }
                    else {

                        // show database table data
                        textBox1.Text = ReadData[1].ToString();
                        comboBox1.Text = ReadData[2].ToString();
                        dateTimePicker1.Value = DateTime.Parse(ReadData[3].ToString());
                        comboBox2.Text = ReadData[4].ToString();
                        textBox5.Text = ReadData[5].ToString();
                        textBox6.Text = ReadData[6].ToString();
                        textBox7.Text = ReadData[7].ToString();
                        textBox2.Text = ReadData[8].ToString();
                        textBox4.Text = ReadData[9].ToString();
                    }
                }
            }
        }
    }
}
