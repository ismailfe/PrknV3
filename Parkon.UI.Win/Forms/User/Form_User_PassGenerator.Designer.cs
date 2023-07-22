namespace Emikon.Parkon.UI.Win
{
    partial class Form_User_PassGenerator
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
            this.TB_CryptoVeri = new System.Windows.Forms.TextBox();
            this.TB_Veri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Sifrele = new System.Windows.Forms.Button();
            this.TB_CozulecekVeri = new System.Windows.Forms.TextBox();
            this.TB_CozulenVeri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Coz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_CryptoVeri
            // 
            this.TB_CryptoVeri.Location = new System.Drawing.Point(26, 71);
            this.TB_CryptoVeri.Multiline = true;
            this.TB_CryptoVeri.Name = "TB_CryptoVeri";
            this.TB_CryptoVeri.Size = new System.Drawing.Size(448, 75);
            this.TB_CryptoVeri.TabIndex = 0;
            // 
            // TB_Veri
            // 
            this.TB_Veri.Location = new System.Drawing.Point(26, 45);
            this.TB_Veri.Name = "TB_Veri";
            this.TB_Veri.Size = new System.Drawing.Size(367, 20);
            this.TB_Veri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şifrelenecek Veri";
            // 
            // B_Sifrele
            // 
            this.B_Sifrele.Location = new System.Drawing.Point(399, 42);
            this.B_Sifrele.Name = "B_Sifrele";
            this.B_Sifrele.Size = new System.Drawing.Size(75, 23);
            this.B_Sifrele.TabIndex = 2;
            this.B_Sifrele.Text = "şifrele";
            this.B_Sifrele.UseVisualStyleBackColor = true;
            this.B_Sifrele.Click += new System.EventHandler(this.B_Sifrele_Click);
            // 
            // TB_CozulecekVeri
            // 
            this.TB_CozulecekVeri.Location = new System.Drawing.Point(26, 218);
            this.TB_CozulecekVeri.Multiline = true;
            this.TB_CozulecekVeri.Name = "TB_CozulecekVeri";
            this.TB_CozulecekVeri.Size = new System.Drawing.Size(367, 75);
            this.TB_CozulecekVeri.TabIndex = 0;
            // 
            // TB_CozulenVeri
            // 
            this.TB_CozulenVeri.Location = new System.Drawing.Point(26, 299);
            this.TB_CozulenVeri.Name = "TB_CozulenVeri";
            this.TB_CozulenVeri.Size = new System.Drawing.Size(448, 20);
            this.TB_CozulenVeri.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çözülecek Veri";
            // 
            // B_Coz
            // 
            this.B_Coz.Location = new System.Drawing.Point(399, 216);
            this.B_Coz.Name = "B_Coz";
            this.B_Coz.Size = new System.Drawing.Size(75, 23);
            this.B_Coz.TabIndex = 2;
            this.B_Coz.Text = "Veri Çöz";
            this.B_Coz.UseVisualStyleBackColor = true;
            this.B_Coz.Click += new System.EventHandler(this.B_Coz_Click);
            // 
            // Form_User_PassGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 339);
            this.Controls.Add(this.B_Coz);
            this.Controls.Add(this.B_Sifrele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CozulenVeri);
            this.Controls.Add(this.TB_Veri);
            this.Controls.Add(this.TB_CozulecekVeri);
            this.Controls.Add(this.TB_CryptoVeri);
            this.Name = "Form_User_PassGenerator";
            this.Text = "Form_User_PassGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_CryptoVeri;
        private System.Windows.Forms.TextBox TB_Veri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Sifrele;
        private System.Windows.Forms.TextBox TB_CozulecekVeri;
        private System.Windows.Forms.TextBox TB_CozulenVeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Coz;
    }
}