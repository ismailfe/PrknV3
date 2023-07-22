namespace Emikon.Parkon.UI.Win.Forms.Settings
{
    partial class SettingsForm
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
            this.txtSecilenProjeAnaDizin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btnPathProjeDizin = new System.Windows.Forms.Button();
            this.btnPathEskiParkonProjeDizin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEskiParkonProjeDizin = new System.Windows.Forms.TextBox();
            this.btnProjeDizinV1toV2Degistir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProjectCodeGenerate = new System.Windows.Forms.Button();
            this.txtSecilenTeklifAnaDizin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPathTeklifDizin = new System.Windows.Forms.Button();
            this.myMemoEdit1 = new Emikon.Parkon.Common.Design.Controls.MyMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSecilenProjeAnaDizin
            // 
            this.txtSecilenProjeAnaDizin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecilenProjeAnaDizin.Location = new System.Drawing.Point(90, 13);
            this.txtSecilenProjeAnaDizin.Name = "txtSecilenProjeAnaDizin";
            this.txtSecilenProjeAnaDizin.ReadOnly = true;
            this.txtSecilenProjeAnaDizin.Size = new System.Drawing.Size(303, 20);
            this.txtSecilenProjeAnaDizin.TabIndex = 3;
            this.txtSecilenProjeAnaDizin.Text = "D:\\Parkon-Projeler\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proje Dizini:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 36);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(288, 13);
            this.label33.TabIndex = 5;
            this.label33.Text = "Bilgi: ana dizin olarak \"D:\\Parkon-Projeler\" seçilmesi önerilir.";
            // 
            // btnPathProjeDizin
            // 
            this.btnPathProjeDizin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathProjeDizin.Location = new System.Drawing.Point(397, 12);
            this.btnPathProjeDizin.Name = "btnPathProjeDizin";
            this.btnPathProjeDizin.Size = new System.Drawing.Size(75, 23);
            this.btnPathProjeDizin.TabIndex = 6;
            this.btnPathProjeDizin.Text = "Dizin Seç";
            this.btnPathProjeDizin.UseVisualStyleBackColor = true;
            this.btnPathProjeDizin.Click += new System.EventHandler(this.B_PathProjeDizin_Click);
            // 
            // btnPathEskiParkonProjeDizin
            // 
            this.btnPathEskiParkonProjeDizin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathEskiParkonProjeDizin.Location = new System.Drawing.Point(923, 50);
            this.btnPathEskiParkonProjeDizin.Name = "btnPathEskiParkonProjeDizin";
            this.btnPathEskiParkonProjeDizin.Size = new System.Drawing.Size(75, 23);
            this.btnPathEskiParkonProjeDizin.TabIndex = 6;
            this.btnPathEskiParkonProjeDizin.Text = "Dizin Seç";
            this.btnPathEskiParkonProjeDizin.UseVisualStyleBackColor = true;
            this.btnPathEskiParkonProjeDizin.Click += new System.EventHandler(this.btnPathEskiParkonProjeDizin_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PARKON V1 => V2 verisyon değişimi ile birlikte proje referans numarası standardı " +
    "değiştirilmiştir.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "UYUMLULUK AYARLARI (Parkon V1 => V2)";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "V1 Proje Dizini:";
            // 
            // txtEskiParkonProjeDizin
            // 
            this.txtEskiParkonProjeDizin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEskiParkonProjeDizin.Location = new System.Drawing.Point(579, 52);
            this.txtEskiParkonProjeDizin.Name = "txtEskiParkonProjeDizin";
            this.txtEskiParkonProjeDizin.ReadOnly = true;
            this.txtEskiParkonProjeDizin.Size = new System.Drawing.Size(338, 20);
            this.txtEskiParkonProjeDizin.TabIndex = 3;
            this.txtEskiParkonProjeDizin.Text = "D:\\Parkon-Projeler-Deneme\\";
            // 
            // btnProjeDizinV1toV2Degistir
            // 
            this.btnProjeDizinV1toV2Degistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjeDizinV1toV2Degistir.Location = new System.Drawing.Point(502, 75);
            this.btnProjeDizinV1toV2Degistir.Name = "btnProjeDizinV1toV2Degistir";
            this.btnProjeDizinV1toV2Degistir.Size = new System.Drawing.Size(496, 38);
            this.btnProjeDizinV1toV2Degistir.TabIndex = 6;
            this.btnProjeDizinV1toV2Degistir.Text = "Parkon V1 formatındaki Proje Dizinini PARKON V2 olarak değiştir";
            this.btnProjeDizinV1toV2Degistir.UseVisualStyleBackColor = true;
            this.btnProjeDizinV1toV2Degistir.Click += new System.EventHandler(this.btnProjeDizinV1toV2Degistir_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PARKON V1 Projeler Dizini";
            // 
            // btnProjectCodeGenerate
            // 
            this.btnProjectCodeGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjectCodeGenerate.Location = new System.Drawing.Point(351, 534);
            this.btnProjectCodeGenerate.Name = "btnProjectCodeGenerate";
            this.btnProjectCodeGenerate.Size = new System.Drawing.Size(143, 23);
            this.btnProjectCodeGenerate.TabIndex = 8;
            this.btnProjectCodeGenerate.Text = "ProjectCode Generate";
            this.btnProjectCodeGenerate.UseVisualStyleBackColor = true;
            this.btnProjectCodeGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSecilenTeklifAnaDizin
            // 
            this.txtSecilenTeklifAnaDizin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecilenTeklifAnaDizin.Location = new System.Drawing.Point(90, 85);
            this.txtSecilenTeklifAnaDizin.Name = "txtSecilenTeklifAnaDizin";
            this.txtSecilenTeklifAnaDizin.ReadOnly = true;
            this.txtSecilenTeklifAnaDizin.Size = new System.Drawing.Size(303, 20);
            this.txtSecilenTeklifAnaDizin.TabIndex = 9;
            this.txtSecilenTeklifAnaDizin.Text = "D:\\Parkon-Teklifler\\";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Teklif Dizini:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bilgi: ana dizin olarak \"D:\\Parkon-Teklifler\" seçilmesi önerilir.";
            // 
            // btnPathTeklifDizin
            // 
            this.btnPathTeklifDizin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathTeklifDizin.Location = new System.Drawing.Point(397, 84);
            this.btnPathTeklifDizin.Name = "btnPathTeklifDizin";
            this.btnPathTeklifDizin.Size = new System.Drawing.Size(75, 23);
            this.btnPathTeklifDizin.TabIndex = 12;
            this.btnPathTeklifDizin.Text = "Dizin Seç";
            this.btnPathTeklifDizin.UseVisualStyleBackColor = true;
            this.btnPathTeklifDizin.Click += new System.EventHandler(this.btnPathTeklifDizin_Click);
            // 
            // myMemoEdit1
            // 
            this.myMemoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myMemoEdit1.EnterMoveNextControl = true;
            this.myMemoEdit1.Location = new System.Drawing.Point(500, 134);
            this.myMemoEdit1.Name = "myMemoEdit1";
            this.myMemoEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myMemoEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myMemoEdit1.Properties.MaxLength = 1050;
            this.myMemoEdit1.Size = new System.Drawing.Size(498, 423);
            this.myMemoEdit1.StatusBarComment = "Açıklama giriniz.";
            this.myMemoEdit1.TabIndex = 7;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 563);
            this.Controls.Add(this.txtSecilenTeklifAnaDizin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPathTeklifDizin);
            this.Controls.Add(this.btnProjectCodeGenerate);
            this.Controls.Add(this.myMemoEdit1);
            this.Controls.Add(this.txtEskiParkonProjeDizin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecilenProjeAnaDizin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.btnProjeDizinV1toV2Degistir);
            this.Controls.Add(this.btnPathEskiParkonProjeDizin);
            this.Controls.Add(this.btnPathProjeDizin);
            this.Name = "SettingsForm";
            this.Text = "Ayarlar - Klasör Ayarları";
            ((System.ComponentModel.ISupportInitialize)(this.myMemoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtSecilenProjeAnaDizin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnPathProjeDizin;
        private System.Windows.Forms.Button btnPathEskiParkonProjeDizin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEskiParkonProjeDizin;
        private System.Windows.Forms.Button btnProjeDizinV1toV2Degistir;
        private Common.Design.Controls.MyMemoEdit myMemoEdit1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProjectCodeGenerate;
        public System.Windows.Forms.TextBox txtSecilenTeklifAnaDizin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPathTeklifDizin;
    }
}