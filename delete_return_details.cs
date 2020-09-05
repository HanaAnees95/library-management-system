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
    public partial class delete_return_details : Form
    {
        // database connection from config.cs
        config conf = new config();

        public delete_return_details()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Enter Search Id", "SARASAVI LIBRARY::Delete Return Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        // show details from database table
                        dateTimePicker2.Value = DateTime.Parse(ReadData[1].ToString());
                        textBox1.Text = ReadData[2].ToString();
                        textBox2.Text = ReadData[3].ToString();
                        textBox3.Text = ReadData[4].ToString();
                        textBox4.Text = ReadData[5].ToString();
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = conf.DeleteRecord("return_details", "Id", textBox5.Text);  // write your SQL command here

            // delete details from database table


            dateTimePicker2.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            MessageBox.Show(status);

            {

                if
                        (status == "Success")
                {
                    MessageBox.Show("Records Deleted Succesfull", "SARASAVI LIBRARY::Delete Return Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Records Deleted Failed!", "SARASAVI LIBRARY::Delete Return Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
        }

        private void delete_return_details_Load(object sender, EventArgs e)
        {

        }
    }
}
