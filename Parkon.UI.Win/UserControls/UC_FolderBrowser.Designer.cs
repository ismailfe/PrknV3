namespace Prkn.UI.Win
{
    partial class UC_FolderBrowser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.Panel = new System.Windows.Forms.Panel();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.Pic_Sembol = new System.Windows.Forms.PictureBox();
            this.B_Ac = new System.Windows.Forms.Button();
            this.B_Link = new System.Windows.Forms.Button();
            this.B_Geri = new System.Windows.Forms.Button();
            this.LB_Baslik = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Sembol)).BeginInit();
            this.SuspendLayout();
            // 
            // WebBrowser
            // 
            this.WebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebBrowser.Location = new System.Drawing.Point(4, 27);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(358, 158);
            this.WebBrowser.TabIndex = 1;
            this.WebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Panel
            // 
            this.Panel.AllowDrop = true;
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.BtnKapat);
            this.Panel.Controls.Add(this.Pic_Sembol);
            this.Panel.Controls.Add(this.B_Ac);
            this.Panel.Controls.Add(this.B_Link);
            this.Panel.Controls.Add(this.B_Geri);
            this.Panel.Controls.Add(this.WebBrowser);
            this.Panel.Controls.Add(this.LB_Baslik);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(405, 190);
            this.Panel.TabIndex = 1;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.BackColor = System.Drawing.Color.Transparent;
            this.BtnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKapat.Location = new System.Drawing.Point(365, 2);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(37, 23);
            this.BtnKapat.TabIndex = 4;
            this.BtnKapat.Text = "X";
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // Pic_Sembol
            // 
            this.Pic_Sembol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_Sembol.Location = new System.Drawing.Point(365, 46);
            this.Pic_Sembol.Name = "Pic_Sembol";
            this.Pic_Sembol.Size = new System.Drawing.Size(37, 37);
            this.Pic_Sembol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Sembol.TabIndex = 3;
            this.Pic_Sembol.TabStop = false;
            // 
            // B_Ac
            // 
            this.B_Ac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Ac.BackColor = System.Drawing.Color.Transparent;
            this.B_Ac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Ac.Location = new System.Drawing.Point(365, 107);
            this.B_Ac.Name = "B_Ac";
            this.B_Ac.Size = new System.Drawing.Size(37, 26);
            this.B_Ac.TabIndex = 2;
            this.B_Ac.Text = "Aç";
            this.B_Ac.UseVisualStyleBackColor = false;
            this.B_Ac.Click += new System.EventHandler(this.B_Ac_Click);
            // 
            // B_Link
            // 
            this.B_Link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Link.BackColor = System.Drawing.Color.Transparent;
            this.B_Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Link.Location = new System.Drawing.Point(365, 134);
            this.B_Link.Name = "B_Link";
            this.B_Link.Size = new System.Drawing.Size(37, 26);
            this.B_Link.TabIndex = 2;
            this.B_Link.Text = "Link";
            this.B_Link.UseVisualStyleBackColor = false;
            this.B_Link.Click += new System.EventHandler(this.B_Link_Click);
            // 
            // B_Geri
            // 
            this.B_Geri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Geri.BackColor = System.Drawing.Color.Transparent;
            this.B_Geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Geri.Location = new System.Drawing.Point(365, 161);
            this.B_Geri.Name = "B_Geri";
            this.B_Geri.Size = new System.Drawing.Size(37, 26);
            this.B_Geri.TabIndex = 2;
            this.B_Geri.Text = "Geri";
            this.B_Geri.UseVisualStyleBackColor = false;
            this.B_Geri.Click += new System.EventHandler(this.B_Geri_Click);
            // 
            // LB_Baslik
            // 
            this.LB_Baslik.AllowDrop = true;
            this.LB_Baslik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LB_Baslik.Location = new System.Drawing.Point(0, 0);
            this.LB_Baslik.Name = "LB_Baslik";
            this.LB_Baslik.Size = new System.Drawing.Size(353, 25);
            this.LB_Baslik.TabIndex = 0;
            this.LB_Baslik.Text = "BAŞLIKLAR";
            this.LB_Baslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_Baslik.TextChanged += new System.EventHandler(this.LB_Baslik_TextChanged);
            // 
            // UC_FolderBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "UC_FolderBrowser";
            this.Size = new System.Drawing.Size(405, 190);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Sembol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.PictureBox Pic_Sembol;
        private System.Windows.Forms.Button B_Ac;
        private System.Windows.Forms.Button B_Link;
        private System.Windows.Forms.Button B_Geri;
        private System.Windows.Forms.Label LB_Baslik;
        private System.Windows.Forms.Button BtnKapat;
    }
}
