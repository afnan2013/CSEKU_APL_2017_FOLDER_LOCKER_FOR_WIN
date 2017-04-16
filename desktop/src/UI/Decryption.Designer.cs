namespace WindowsFormsApplication1
{
    partial class Form_Decryption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Decryption));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_newFileLoc = new System.Windows.Forms.TextBox();
            this.button_LockEncr = new System.Windows.Forms.Button();
            this.button_browse_lock = new System.Windows.Forms.Button();
            this.textBox_uKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 402);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_newFileLoc
            // 
            this.textBox_newFileLoc.BackColor = System.Drawing.Color.Black;
            this.textBox_newFileLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_newFileLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_newFileLoc.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox_newFileLoc.Location = new System.Drawing.Point(208, 167);
            this.textBox_newFileLoc.Name = "textBox_newFileLoc";
            this.textBox_newFileLoc.Size = new System.Drawing.Size(325, 21);
            this.textBox_newFileLoc.TabIndex = 28;
            // 
            // button_LockEncr
            // 
            this.button_LockEncr.BackColor = System.Drawing.Color.Black;
            this.button_LockEncr.CausesValidation = false;
            this.button_LockEncr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LockEncr.Location = new System.Drawing.Point(291, 270);
            this.button_LockEncr.Name = "button_LockEncr";
            this.button_LockEncr.Size = new System.Drawing.Size(75, 25);
            this.button_LockEncr.TabIndex = 27;
            this.button_LockEncr.Text = "Unlock";
            this.button_LockEncr.UseVisualStyleBackColor = false;
            this.button_LockEncr.Click += new System.EventHandler(this.button_LockEncr_Click);
            // 
            // button_browse_lock
            // 
            this.button_browse_lock.BackColor = System.Drawing.Color.Black;
            this.button_browse_lock.Location = new System.Drawing.Point(550, 167);
            this.button_browse_lock.Name = "button_browse_lock";
            this.button_browse_lock.Size = new System.Drawing.Size(75, 23);
            this.button_browse_lock.TabIndex = 26;
            this.button_browse_lock.Text = "Browse";
            this.button_browse_lock.UseVisualStyleBackColor = false;
            this.button_browse_lock.Click += new System.EventHandler(this.button_browse_lock_Click);
            // 
            // textBox_uKey
            // 
            this.textBox_uKey.BackColor = System.Drawing.Color.Black;
            this.textBox_uKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_uKey.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox_uKey.Location = new System.Drawing.Point(308, 220);
            this.textBox_uKey.Name = "textBox_uKey";
            this.textBox_uKey.PasswordChar = '*';
            this.textBox_uKey.Size = new System.Drawing.Size(191, 20);
            this.textBox_uKey.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(230, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Enter Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(17, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Encrypted File Location";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(550, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Decryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(657, 316);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_newFileLoc);
            this.Controls.Add(this.button_LockEncr);
            this.Controls.Add(this.button_browse_lock);
            this.Controls.Add(this.textBox_uKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.KeyPreview = true;
            this.Name = "Form_Decryption";
            this.Text = "Folder Locker - Unlock File";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_newFileLoc;
        private System.Windows.Forms.Button button_LockEncr;
        private System.Windows.Forms.Button button_browse_lock;
        private System.Windows.Forms.TextBox textBox_uKey;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}