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
    public partial class update_member : Form
    {
        public update_member()
        {
            InitializeComponent();
        }
        // database connection from config.cs
        config conf = new config();
        private void update_member_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // edit table data
            string SQL = "UPDATE library_member SET " +
                "member_number= '" + textBox1.Text + "', " +
                "first_name= '" + textBox2.Text + "', " +
                "last_name = '" + textBox3.Text + "', " +
                "contact_number = '" + textBox4.Text + "', " +
                "address = '" + textBox5.Text + "', " +
                "gender ='" + comboBox2.Text + "', " +
               "date_of_birth ='" + textBox8.Text + "', " +
                "NIC_no ='" + textBox9.Text + "', " +
                "member_type ='" + comboBox1.Text + 
                "' WHERE Id  ='" + textBox6.Text + "';";

            string responce = conf.RunUpdateQ(SQL);

          //  MessageBox.Show(responce);
            {

                if
                        (responce == "Success")
                {
                    MessageBox.Show("Records Updated Successfull", "SARASAVI LIBRARY::Update Member Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Records Updated Failed!", "SARASAVI LIBRARY::Update Member Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }


        }


        private void button3_Click(object sender, EventArgs e)

        {
            {
                if (textBox6.Text == "")
                {
                    MessageBox.Show("Enter Search Id", "SARASAVI LIBRARY::Update Member Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox6.Focus();
                    return;
                }
                else
                {



                    DataRow ReadData = conf.FetchRec("library_member", "Id", textBox6.Text);
                    //MessageBox.Show(ReadData[1].ToString());

                    if (ReadData == null)
                    {
                        MessageBox.Show("Member Id not Found!");
                    }
                    else {
                        // show database table data
                        textBox1.Text = ReadData[1].ToString();
                        textBox2.Text = ReadData[2].ToString();
                        textBox3.Text = ReadData[3].ToString();
                        textBox4.Text = ReadData[4].ToString();
                        textBox5.Text = ReadData[5].ToString();
                        comboBox2.Text = ReadData[6].ToString();
                        textBox8.Text = ReadData[7].ToString();
                        textBox9.Text = ReadData[8].ToString();
                        comboBox1.Text = ReadData[9].ToString();

                    }
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
