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
    public partial class update_borrow_details : Form
    {
        public update_borrow_details()
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
            string SQL = "UPDATE Borrow_Details SET " +
                "Borrow_Date = '" + dateTimePicker1.Value.Date.ToShortDateString() + "', " +
                "Return_Date= '" + dateTimePicker2.Value.Date.ToShortDateString() + "', " +
                "Status = '" + textBox1.Text + "', " +
                "Book_Id = '" + textBox2.Text + "', " +
                "Member_Id = '" + textBox3.Text +
               "' WHERE Id  ='" + textBox5.Text + "';";

            string responce = conf.RunUpdateQ(SQL);

            MessageBox.Show(responce);

            {

                if
                        (responce == "Success")
                {
                    MessageBox.Show("Records Updated Successfull", "SARASAVI LIBRARY::Update Borrow Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Records Updated Failed!", "SARASAVI LIBRARY::Update Borrow Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }


        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        // database connection from config.cs
        config conf = new config();
        private void update_borrow_details_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Enter Search Id", "SARASAVI LIBRARY::Update Borrow Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                        //MessageBox.Show(ReadData[1].ToString());


                        // show database table data
                        dateTimePicker1.Value = DateTime.Parse(ReadData[1].ToString());
                        dateTimePicker2.Value = DateTime.Parse(ReadData[2].ToString());
                        textBox1.Text = ReadData[3].ToString();
                        textBox2.Text = ReadData[3].ToString();
                        textBox3.Text = ReadData[3].ToString();
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
