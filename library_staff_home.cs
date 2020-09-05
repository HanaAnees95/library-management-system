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
    public partial class frmMain : Form
    {
        public frmMain(string a)
        {
            InitializeComponent();
            label1.Text = "Welcome!" + a;
            timer1.Start();

        }

        private void library_staff_home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // DateTime dt = DateTime.Now;
            // this.toolStripTextBox1.Text = dt.ToString();

            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;



            string time = "";
            
            if (hh < 10)
            {
                time += "0" + hh;


            }
            else
            {
                time += hh;
            }
            time +=  ":";

                if (mm  < 10)
            {
                time += "0" + mm;
            }
                else
            {
                time += mm;
            }
            time += ":";


            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            toolStripTextBox1.Text = time;
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_books a = new update_books();
            a.MdiParent = this;
            a.Show();
        }

        private void libraryStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void borrowBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void damagedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           search_book a = new search_book();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void savetoolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void opentoolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_books a = new add_books();
            a.MdiParent = this;
            a.Show();
        }

        private void allBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_books a = new view_books();
            a.MdiParent = this;
            a.Show();
        }

        private void deleteBooksToolStripMenuItem_Click(object sender, EventArgs e)
        
            {
                delete_books a = new delete_books();
                a.MdiParent = this;
                a.Show();
            }
        

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_library_member a = new add_library_member();
            a.MdiParent = this;
            a.Show();
        }

        private void newVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_library_visitor a = new add_library_visitor();
            a.MdiParent = this;
            a.Show();
        }

        private void existingMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
           update_member a = new update_member();
            a.MdiParent = this;
            a.Show();
        }

        private void existingMemberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delete_library_member a = new delete_library_member();
            a.MdiParent = this;
            a.Show();
        }

        private void existingVisitorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delete_visitor a = new delete_visitor();
            a.MdiParent = this;
            a.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_borrow_book a = new add_borrow_book();
            a.MdiParent = this;
            a.Show();
        }

        private void borrowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void updateBorrowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_borrow_details a = new update_borrow_details();
            a.MdiParent = this;
            a.Show();
        }

        private void deleteBorrowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_borrow_details a = new delete_borrow_details();
            a.MdiParent = this;
            a.Show();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           reserve_book_details a = new reserve_book_details();
            a.MdiParent = this;
            a.Show();
        }

        private void deleteReservedBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           delete_reserved_books a = new delete_reserved_books();
            a.MdiParent = this;
            a.Show();
        }

        private void updateReservedBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          reserve_book_details a = new reserve_book_details();
            a.MdiParent = this;
            a.Show();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
           add_library_staff a = new add_library_staff();
            a.MdiParent = this;
            a.Show();
        }

        private void deleteStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
           delete_library_staff a = new delete_library_staff();
            a.MdiParent = this;
            a.Show();
        }

        private void editStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
           update_library_staff a = new update_library_staff();
            a.MdiParent = this;
            a.Show();
        }

        private void existingMemberToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            search_member a = new search_member();
            a.MdiParent = this;
            a.Show();
        }

        private void existingVisitorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           search_visitor a = new search_visitor();
            a.MdiParent = this;
            a.Show();
        }

        private void referenceBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_book a = new search_book();
            a.MdiParent = this;
            a.Show();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
           search_book a = new search_book();
            a.MdiParent = this;
            a.Show();
        }

        private void searchStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_library_staff a = new search_library_staff();
            a.MdiParent = this;
            a.Show();
        }

        private void allToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            search_all_members a = new search_all_members();
            a.MdiParent = this;
            a.Show();
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void returnDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservedDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchReservedBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           search_reservation_detail a = new search_reservation_detail();
            a.MdiParent = this;
            a.Show();
        }

        private void uPDATEReserveBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_reserved_books a = new update_reserved_books();
            a.MdiParent = this;
            a.Show();
        }

        private void viewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           new_inquiry a = new new_inquiry();
            a.MdiParent = this;
            a.Show();
        }

        private void searchInquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           search_inquiry a =  new search_inquiry();
            a.MdiParent = this;
            a.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void allToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void allToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void searchBorrowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_borrow_details a = new search_borrow_details();
            a.MdiParent = this;
            a.Show();
        }

        private void addReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return_book_details a = new return_book_details();
            a.MdiParent = this;
            a.Show();
        }

        private void updateReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
           update_return_details a = new update_return_details();
            a.MdiParent = this;
            a.Show();
        }

        private void searchReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_return_details a = new search_return_details();
            a.MdiParent = this;
            a.Show();
        }

        private void deleteReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_return_details a = new delete_return_details();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void existingInquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
          update_inquiry a = new update_inquiry();
            a.MdiParent = this;
            a.Show();
        }

        private void deleteInquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_inquiry a = new delete_inquiry();
            a.MdiParent = this;
            a.Show();
        }

        private void existingVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_visitor a = new update_visitor();
            a.MdiParent = this;
            a.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
