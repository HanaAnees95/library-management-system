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
    public partial class update_library_staff : Form
    {
        public update_library_staff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // edit table data
            string SQL = "UPDATE add_library_staff SET " +
                "staff_number= '" + textBox1.Text + "', " +
                "first_name= '" + textBox2.Text + "', " +
                "last_name = '" + textBox3.Text + "', " +
                "contact_number = '" + textBox4.Text + "', " +
                "address = '" + textBox5.Text + "', " +
               "password ='" + textBox8.Text + "', " +
               "repeat_password ='" + textBox10.Text +
              "' WHERE Id  ='" + textBox6.Text + "';";

            string responce = conf.RunUpdateQ(SQL);

            MessageBox.Show(responce);
            {

                if
                        (responce == "Success")
                {
                    MessageBox.Show("Records Updated Successfull", "SARASAVI LIBRARY::Update Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Records Updated Failed!", "SARASAVI LIBRARY::Update Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }


        }

        // database connection from config.cs
        config conf = new config();
        private void update_library_staff_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox6.Text == "")
                {
                    MessageBox.Show("Enter Search Id", "SARASAVI LIBRARY::Update Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox6.Focus();
                    return;
                }
                else
                {


                    // 
                    DataRow ReadData = conf.FetchRec("add_library_staff", "Id", textBox6.Text);
                    //MessageBox.Show(ReadData[1].ToString());

                    if (ReadData == null)
                    {
                        MessageBox.Show("Staff Id not Found!");
                    }
                    else {

                        // show database table data
                        textBox1.Text = ReadData[1].ToString();
                        textBox2.Text = ReadData[2].ToString();
                        textBox3.Text = ReadData[3].ToString();
                        textBox4.Text = ReadData[4].ToString();
                        textBox5.Text = ReadData[5].ToString();
                        textBox8.Text = ReadData[6].ToString();
                        textBox10.Text = ReadData[7].ToString();


                    }
                }
            }
        }
    }
}


