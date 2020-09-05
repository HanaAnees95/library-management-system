using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;



namespace sarasavi_library_management_system
{
    public class config
    {
        public static string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_test;Integrated Security=True;Pooling=False";


        public static SqlConnection con = new SqlConnection(str);

        public config()
        {
        }
        //{ 
            
        ////{
        ////    str = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_test;Integrated Security=True;Pooling=False";
        ////    con = new SqlConnection(str);
        ////    con.Open();
        ////    MessageBox.Show("Database Connected");
        ////    con.Close();
        //}

        public static string logmein(string UN, string PW)
        {
            string status = "";
            int count = 0;
            string returnid = "";
            


            string Sql = "SELECT Id FROM add_library_staff  WHERE first_name='" + UN + "' AND password='" + PW + "'";
            SqlCommand CheckCred = new SqlCommand(Sql, con );
            try
            {
                 con.Open();
                SqlDataReader ReadID = CheckCred.ExecuteReader();

                while (ReadID.Read())
                {
                    count = count + 1;
                    returnid = ReadID[0].ToString();
                }

                if (count == 1) { status = returnid; Program.firstname = UN; Program.password = returnid; }
                else if (count == 0) { status = "User not Found!"; }
                else { status = "error"; }
            }
            catch { status = "Exception!!!!!"; }
            finally { con.Close(); }

            return status;


        }
        // search
        public void loadgrid(string qry, DataGridView grid)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(qry, con);
            da.SelectCommand = cmd;
            da.Fill(ds);
            grid.DataSource = ds.Tables[0];
            da.Dispose();
            cmd.Dispose();
        }

       public DataRow FetchRec(string table, string column, string findwhat)
        {
            string SQL = "SELECT * FROM " + table + " WHERE " + column + " = '" + findwhat + "';";

            con.Open();
            SqlCommand FetchRec = new SqlCommand(SQL, con);
            SqlDataAdapter DA = new SqlDataAdapter();
            DataSet DS = new DataSet();
            DA.SelectCommand = FetchRec;
            DA.Fill(DS);
            DataTable DT = DS.Tables[0];
            DataRow DR;
            try
            {
                DR = DT.Rows[0];
                return DR;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            
        }


        // update
        public string RunUpdateQ(string SQL)
        {
            try
            {
                con.Open();
                SqlCommand RunUpdate = new SqlCommand(SQL, con);
                RunUpdate.ExecuteNonQuery();
                return "Success";

            
            }
            catch (Exception e)
            {
                return ("ERROR");         }
            finally
            {
                con.Close();
            }
        }

        // delete
        public string DeleteRecord(string table, string column, string row)
        {
            string status = "";
            string SQL = "DELETE FROM " + table + " WHERE " + column + "= '" + row + "';";
            try
            {
                con.Open();
                SqlCommand DeleteRecord = new SqlCommand(SQL, con);

                DeleteRecord.ExecuteNonQuery();
                status = "Success";
            }
            catch (Exception e)
            {
                status = e.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return status;
        }
        // save
        public string AddDBRec(string SQL)
        {
            string status = "";
            try
            {
                con.Open();

                SqlCommand insertRecord = new SqlCommand(SQL, con);

                insertRecord.ExecuteNonQuery();
                status = "Success";
            }



            catch (Exception e)
            {
                status = e.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return status;

        }

        public static int ReadCount(string Member_Id)

        {
            int count = 0;

            con.Open();


            //borrow count
            string SQL = "SELECT count(Id) as No_Books_Borrowed FROM Borrow_Details WHERE Status =  'Borrowed' AND Member_Id = '" + Member_Id + "';";
            SqlCommand getCount = new SqlCommand(SQL, con);


            try

            {
                SqlDataReader ReadCount = getCount.ExecuteReader();


                while (ReadCount.Read())
                {
                    count = int.Parse(ReadCount[0].ToString());

                }
                return count;

            }
            finally
            {
                con.Close();


            }
        }
        //book count
        public static int ReadCount1(string Accession_Number)

        {
            int count = 0;

            con.Open();

            string SQL = "SELECT count(Accession_Number) as No_Books FROM BOOK_DETAILS WHERE AND Accession_Number = '" + Accession_Number + "';";
            SqlCommand getCount = new SqlCommand(SQL, con);


            try

            {
                SqlDataReader ReadCount1 = getCount.ExecuteReader();


                while (ReadCount1.Read())
                {
                    count = int.Parse(ReadCount1[0].ToString());

                }
                return count;

            }
            finally
            {
                con.Close();


            }
        }
    }
}






