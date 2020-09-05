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
    public partial class delete_library_member : Form
    {
        // database connection from config.cs
        config conf = new config();
        public delete_library_member()
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
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Enter Search Id", "SARASAVI LIBRARY::Delete Member Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox7.Focus();
                    return;
                }
                else
                {

                    // 
                    DataRow ReadData = conf.FetchRec("library_member", "Id", textBox7.Text);
                    //MessageBox.Show(ReadData[1].ToString());

                    if (ReadData == null)
                    {
                        MessageBox.Show("Member Id not Found!");
                    }
                    else {

                        // show details from database table
                        textBox1.Text = ReadData[1].ToString();
                        textBox2.Text = ReadData[2].ToString();
                        textBox3.Text = ReadData[3].ToString();
                        textBox4.Text = ReadData[4].ToString();
                        textBox5.Text = ReadData[5].ToString();
                        comboBox1.Text = ReadData[6].ToString();
                        textBox6.Text = ReadData[7].ToString();
                        textBox10.Text = ReadData[8].ToString();
                        comboBox2.Text = ReadData[9].ToString();
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = conf.DeleteRecord("library_member", "Id", textBox7.Text);  // write your SQL command here
            
            // delete details from database table

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
            textBox6.Clear();
            textBox10.Clear();
            comboBox2.Text = "";
            MessageBox.Show(status);

            {

                if
                        (status == "Success")
                {
                    MessageBox.Show("Records Deleted Succesfull", "SARASAVI LIBRARY::Delete Member Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Records Deleted Failed!", "SARASAVI LIBRARY::Delete Member Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
        }
    }
}
