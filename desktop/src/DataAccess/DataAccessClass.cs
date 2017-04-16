using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessClass
    {
        //string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Md. Lutful\Documents\Visual Studio 2012\Projects\FolderLocker_22_3_17\EncryptionData.mdf;Integrated Security=True;Connect Timeout=30";
        //string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Md. Lutful\Documents\Visual Studio 2012\Projects\ABC Locker_10_04_17\EncryptionData.mdf;Integrated Security=True;Connect Timeout=30";
        string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Md. Lutful\Documents\Visual Studio 2012\Projects\Final folder Locker_15_04_17\EncryptionData.mdf;Integrated Security=True;Connect Timeout=30";
        //string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\APL\ABC Locker_10_04_17\EncryptionData.mdf;Integrated Security=True;Connect Timeout=30";



        public Boolean LoginMethod(string key, string key2)
        {
            //Create SqlConnection
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_loginD WHERE Username = '" + key + "'and Password ='" + key2 + "'", con);
            //cmd.Parameters.AddWithValue("@username", textBox1.Text);
            //cmd.Parameters.AddWithValue("@password", textBox2.Text);
            con.Open();
            SqlDataReader dbr;
            dbr = cmd.ExecuteReader();

            int count = 0;
            //int count = ds.Tables[0].Rows.Count;
            //If count is equal to 1, than show frmMain form
            while (dbr.Read())
            {
                count++;
                break;

            }
            if (count == 1)
                return true;
            else
                return false;
        }
        
        public Boolean PassKey(String key) //method for Checking the Locking Password as Folder, File, High Security
        {


            //Create SqlConnection
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select * from tbl_Crypt where Password=@password", con);
            // cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", key);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            //If count is equal to 1, than show frmMain form
            if (count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void PassFolderInserting(string key)
        {
            SqlConnection con = new SqlConnection(cs);
            
           // SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Crypt values ('"+ key +"')", con);
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Crypt (Password) VALUES ('" + key + "')", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void PassFolderDelete(string key)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Crypt WHERE Password='"+ key +"'", con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void InsertFolderLockList(string key)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_locklist (FolderLockList) VALUES ('" + key+"')", con);

            //cmd.Parameters.AddWithValue("@fl1", key);
            //cmd.Parameters.AddWithValue("@fl2", key2);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeleteFolderLockList(string key)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "DELETE FROM tbl_locklist WHERE FolderLockList='"+key+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void InsertHighFolder(string key)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "INSERT INTO tbl_highfolder (FolderLockList) VALUES ('" + key + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeleteHighFolder(string key)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "DELETE FROM tbl_highfolder WHERE FolderLockList='" + key + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void InsertFileLockList(string key)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "INSERT INTO tbl_locklist (FileLockList) VALUES ('"+key+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeleteFileLockList(string key)
        {
            string path = key.Substring(0, key.Length - 1);
            SqlConnection con = new SqlConnection(cs);

            string query = "DELETE FROM tbl_locklist WHERE FileLockList='"+path+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void InsertNewUserId(string username, string password)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "INSERT INTO tbl_loginD (Username, Password) VALUES ('"+username+"','"+password+"')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
        }
        public void DeleteUserId(string password)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "DELETE FROM tbl_loginD WHERE Password='" + password + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public Boolean UserPassCheck(string key)
        {
            //Create SqlConnection
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select * from tbl_loginD where Password=@password", con);
            // cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", key);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            //If count is equal to 1, than show frmMain form
            if (count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
