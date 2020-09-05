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
    public partial class delete_borrow_details : Form
    {
        // database connection from config.cs
        config conf = new config();

        public delete_borrow_details()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Enter Search Id", "SARASAVI LIBRARY::Delete  Borrow Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox5.Focus();
                    return;
                }
                else
                {

                    // 
                    DataRow ReadData = conf.FetchRec("Borrow_Details", "Id", textBox5.Text);
                    //MessageBox.Show(ReadData[1].ToString());

                    if (ReadData == null)
                    {
                        MessageBox.Show("Borrow Id not Found!");
                    }
                    else {
                        // show details from database table
                        dateTimePicker1.Value = DateTime.Parse(ReadData[1].ToString());
                        dateTimePicker2.Value = DateTime.Parse(ReadData[2].ToString());
                        textBox1.Text = ReadData[3].ToString();
                        textBox2.Text = ReadData[4].ToString();
                        textBox3.Text = ReadData[5].ToString();

                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = conf.DeleteRecord("Borrow_details", "Id", textBox5.Text);  // write your SQL command here
             // delete details from database table
           dateTimePicker1.Text = ""; 
           dateTimePicker2.Text = "";
           textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            MessageBox.Show(status);

            {

                if
                        (status == "Success")
                {
                    MessageBox.Show("Records Deleted Successfull", "SARASAVI LIBRARY::Delete Borrow Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Records Deleted Failed!", "SARASAVI LIBRARY::Delete Borrow Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
