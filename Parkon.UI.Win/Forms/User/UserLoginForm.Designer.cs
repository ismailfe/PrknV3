namespace Prkn.UI.Win
{
    partial class UserLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Logout = new System.Windows.Forms.Button();
            this.CHB_RememberMe = new System.Windows.Forms.CheckBox();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.B_Login = new System.Windows.Forms.Button();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.LB_Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(85, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Merkezi Kullanıcı Yönetimi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.B_Logout);
            this.panel1.Controls.Add(this.CHB_RememberMe);
            this.panel1.Controls.Add(this.B_Cancel);
            this.panel1.Controls.Add(this.B_Login);
            this.panel1.Controls.Add(this.TB_Password);
            this.panel1.Controls.Add(this.TB_UserName);
            this.panel1.Controls.Add(this.LB_Status);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 182);
            this.panel1.TabIndex = 3;
            // 
            // B_Logout
            // 
            this.B_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B_Logout.Location = new System.Drawing.Point(198, 109);
            this.B_Logout.Name = "B_Logout";
            this.B_Logout.Size = new System.Drawing.Size(155, 43);
            this.B_Logout.TabIndex = 6;
            this.B_Logout.Text = "Oturumu Kapat";
            this.B_Logout.UseVisualStyleBackColor = true;
            this.B_Logout.Visible = false;
            this.B_Logout.Click += new System.EventHandler(this.B_Logout_Click);
            // 
            // CHB_RememberMe
            // 
            this.CHB_RememberMe.AutoSize = true;
            this.CHB_RememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CHB_RememberMe.Location = new System.Drawing.Point(140, 83);
            this.CHB_RememberMe.Name = "CHB_RememberMe";
            this.CHB_RememberMe.Size = new System.Drawing.Size(110, 24);
            this.CHB_RememberMe.TabIndex = 3;
            this.CHB_RememberMe.Text = "Beni Hatırla";
            this.CHB_RememberMe.UseVisualStyleBackColor = true;
            this.CHB_RememberMe.CheckedChanged += new System.EventHandler(this.CHB_RememberMe_CheckedChanged);
            // 
            // B_Cancel
            // 
            this.B_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B_Cancel.Location = new System.Drawing.Point(81, 109);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(98, 43);
            this.B_Cancel.TabIndex = 5;
            this.B_Cancel.Text = "İptal";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // B_Login
            // 
            this.B_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B_Login.Location = new System.Drawing.Point(198, 109);
            this.B_Login.Name = "B_Login";
            this.B_Login.Size = new System.Drawing.Size(98, 43);
            this.B_Login.TabIndex = 4;
            this.B_Login.Text = "Giriş";
            this.B_Login.UseVisualStyleBackColor = true;
            this.B_Login.Click += new System.EventHandler(this.B_Login_Click);
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_Password.Location = new System.Drawing.Point(140, 53);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(213, 26);
            this.TB_Password.TabIndex = 2;
            this.TB_Password.Text = "şifre";
            this.TB_Password.UseSystemPasswordChar = true;
            this.TB_Password.TextChanged += new System.EventHandler(this.TB_Password_TextChanged);
            // 
            // TB_UserName
            // 
            this.TB_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_UserName.Location = new System.Drawing.Point(140, 20);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(213, 26);
            this.TB_UserName.TabIndex = 1;
            this.TB_UserName.TextChanged += new System.EventHandler(this.TB_UserName_TextChanged);
            // 
            // LB_Status
            // 
            this.LB_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LB_Status.ForeColor = System.Drawing.Color.Red;
            this.LB_Status.Location = new System.Drawing.Point(5, 157);
            this.LB_Status.Name = "LB_Status";
            this.LB_Status.Size = new System.Drawing.Size(375, 20);
            this.LB_Status.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(102, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UserLoginForm
            // 
            this.AcceptButton = this.B_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.B_Cancel;
            this.ClientSize = new System.Drawing.Size(402, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLoginForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_UserLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_UserLogin_FormClosing);
            this.Load += new System.EventHandler(this.Form_UserLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.Button B_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_Status;
        public System.Windows.Forms.Button B_Logout;
        public System.Windows.Forms.CheckBox CHB_RememberMe;
        public System.Windows.Forms.TextBox TB_Password;
        public System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}