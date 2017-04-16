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
    public partial class Form_Decryption : Form
    {
        public Form_Decryption()
        {
            InitializeComponent();
        }

        //browse the Encrypted File
        private void button_browse_lock_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Browse";
            open.Filter = "All Files (*.*)|*.*|Text File (*.txt)|*.txt|JPEG File (*.jpg)|*.jpg|MP4 (*.mp4)|*.mp4";

            if (open.ShowDialog() == DialogResult.OK)
            {

                textBox_newFileLoc.Text = open.FileName;

            }
            //textBox_encFileLoc.Text = open.FileName.Substring(0, textBox_newFileLoc.Text.Length - 1);

            MessageBox.Show("Please save The File Location where You want to Encrypt!", "Welcome!!", MessageBoxButtons.OK);

        }

        


        //To Decrypt the File----------------------------------------------------------------
        private void button_LockEncr_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccessClass dac = new DataAccessClass();
                Boolean s = dac.PassKey(textBox_uKey.Text);
                if (s == true)
                {
                    LogicClass lc1 = new LogicClass();
                    Boolean stat = lc1.DecryptingMethod(textBox_newFileLoc.Text);
                    if (stat)
                        MessageBox.Show("Decryption Succesful!", "Decryption", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Decryption Error!", "Error", MessageBoxButtons.OK);


                }
                else
                    MessageBox.Show("Wrong Password!", "Error", MessageBoxButtons.OK);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK);
            }

            DataAccessClass dc = new DataAccessClass();
            dc.DeleteFileLockList(textBox_newFileLoc.Text);
            //textBox_encFileLoc.Clear();
            textBox_newFileLoc.Clear();
            textBox_uKey.Clear();

        }

        //Get back to the Previous page
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_FileLocker fl = new form_FileLocker();
            fl.ShowDialog();
            this.Close();
        }

        


        private void textBox_newFileLoc_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void textBox_encFileLoc_TextChanged(object sender, EventArgs e)
        {
        }

        }
    }


