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
    public partial class delete_inquiry : Form
    {
        // database connection from config.cs
        config conf = new config();

        public delete_inquiry()
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
            {
                string status = conf.DeleteRecord("add_inquiry", "Id", textBox3.Text);  // write your SQL command here

                // delete details from database table
                textBox1.Clear();
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                comboBox2.Text = "";
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox2.Clear();
                textBox4.Clear();


                MessageBox.Show(status);

                {

                    if
                            (status == "Success")
                    {
                        MessageBox.Show("Records Deleted Successfull!", "SARASAVI LIBRARY::Delete Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Records Deleted Failed!", "SARASAVI LIBRARY::Delete Book Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
            }
        }







        private void button3_Click(object sender, EventArgs e)

        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter Search Id", "SARASAVI LIBRARY::Delete  Inquiry  Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


                    // show details from database table
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
   