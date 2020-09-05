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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // form close
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string status = "";
            //status = config.loadgrid();
            status = config.logmein(UN.Text, PW.Text);

            if (status == "User not Found!")
            {
                MessageBox.Show("Login Failed! Invalid Username or Password!", "Sarasavi Library :: Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (status == "error")
            {
                MessageBox.Show("Something wrong! Try again ....!", "Sarasavi Library :: Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (status == "Exception!!!!!")
            {
                MessageBox.Show("Critical system Faliure! Cantact Support", "System Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmMain frm = new frmMain(UN.Text);
                this.Hide();
                frm.Show();
            }
        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }

        private void UN_TextChanged(object sender, EventArgs e)
        {

        }

        private void PW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

