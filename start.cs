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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public static int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 10)
            {
                this.Dispose(false);
                login o = new login();
                o.Show(); 
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
