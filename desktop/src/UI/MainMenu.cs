using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_UnLock_Click(object sender, EventArgs e) //Button for Only File Locker form open
        {
            this.Hide();
            form_FileLocker fl = new form_FileLocker();
            fl.ShowDialog();
            this.Close();
        }

        private void btn_Lock_Click(object sender, EventArgs e) //Button for Only Folder Locker Form Open
        {
            this.Hide();
            form_FolderLock fl = new form_FolderLock();
            fl.ShowDialog();
            this.Close();
        }

        private void btn_HighSecurity_Click(object sender, EventArgs e) //Button For High Level Sucurity Form Open
        {
            this.Hide();
            form_HighSecurity hs = new form_HighSecurity();
            hs.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e) // Button For Displaying the Locked Folders
        {
            this.Hide();
            DataDisplay dd = new DataDisplay();
            dd.ShowDialog();
            this.Close();
        }
        

        private void button3_Click(object sender, EventArgs e) // Button for Exit
        {
            this.Close();
        }

        //Password Changing!!
        private void button4_Click(object sender, EventArgs e) // Button for seting a new password
        {
            this.Hide();
            form_SetPassword sp = new form_SetPassword();
            sp.ShowDialog();
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
       

       
    }
}
