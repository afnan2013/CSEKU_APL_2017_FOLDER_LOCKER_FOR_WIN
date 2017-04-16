using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace WindowsFormsApplication1
{
    public partial class form_FileLocker : Form
    {
        public form_FileLocker()
        {
            InitializeComponent();
        }

       
        //Go to the File Locking Window Or Encryption Window
        private void button_lock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Encyption f2 = new Form_Encyption();
            f2.ShowDialog();
            this.Close();
        }

        //Go to  the File Unlocking Window Or Decryption Window
        private void button_unlock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Decryption f3 = new Form_Decryption();
            f3.ShowDialog();
            this.Close();
        }

        //Go back to the mainmenu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void form_folderLocker_Load(object sender, EventArgs e)
        {

        }

        private void btn_SetPassword(object sender, EventArgs e)
        {
            
        }
        
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}
