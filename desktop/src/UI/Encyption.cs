using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccess;
using BusinessLogic;
namespace WindowsFormsApplication1
{
    public partial class Form_Encyption : Form
    {
        public Form_Encyption()
        {
            InitializeComponent();
        }

        //Browse the file which to be encrypted
        private void btn_Browse1Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Browse";
            open.Filter = "All Files (*.*)|*.*|Text File (*.txt)|*.txt|JPEG File (*.jpg)|*.jpg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox_fLocation.Text = open.FileName;
            }

            //textBox_encFile.Text = textBox_fLocation.Text + "e";
            
            //MessageBox.Show("Please save The File Location where You want to Encrypt!", "Welcome!!", MessageBoxButtons.OK);
        }

      
       
        //Does The Encryption
       private void button_LockEncr_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessClass dt = new DataAccessClass();
                Boolean s = dt.PassKey(textBox_key.Text);
                if (s == true && textBox_key.Text == textBox_rKey.Text)
                {
                    LogicClass lc = new LogicClass();
                    Boolean stat = lc.EncryptingMethod(textBox_fLocation.Text);
                    if(stat)
                        MessageBox.Show("Encryption Succesful!", "Encryption", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Encryption Error....", "Error!", MessageBoxButtons.OK);                    
                }
                else
                {
                    MessageBox.Show("Wrong Password", "Error!", MessageBoxButtons.OK);
                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show("Invalid Input", "Error!!", MessageBoxButtons.OK);
            }
            DataAccessClass fll = new DataAccessClass();
            fll.InsertFileLockList(textBox_fLocation.Text);
            //textBox_encFile.Clear();
            textBox_fLocation.Clear();
            textBox_key.Clear();
            textBox_rKey.Clear();
            //textBox_key.Text = string.Empty;
        }

       
        //Get to the File Locking Window
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_FileLocker fl = new form_FileLocker();
            fl.ShowDialog();
            this.Close();
        }


        
        
        

        private void Form_LockFile_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox_fLocation_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_browse_lock_Click(object sender, EventArgs e)
        {


        }

        private void textBox_encFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
