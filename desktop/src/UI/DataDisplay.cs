using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccess;

namespace WindowsFormsApplication1
{
    public partial class DataDisplay : Form
    {
        public DataDisplay()
        {
            InitializeComponent();
        }

        string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Md. Lutful\Documents\Visual Studio 2012\Projects\Final folder Locker_15_04_17\EncryptionData.mdf;Integrated Security=True;Connect Timeout=30";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
         SqlConnection con = new SqlConnection(cs);

            string query = "SELECT FolderLockList FROM tbl_locklist WHERE FolderLockList is not NULL";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT FileLockList FROM tbl_locklist WHERE FileLockList is not NULL";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void btn_high_Secured_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT FolderLockList From tbl_highfolder";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
