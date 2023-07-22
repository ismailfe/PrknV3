using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Emikon.Parkon.UI.Win.Forms.General
{
    public partial class IslemOkForm : DevExpress.XtraEditors.XtraForm
    {
        string Detay;
        public IslemOkForm(string islemDetayi)
        {
            InitializeComponent();

            Detay = islemDetayi;

            DetayGoster();

            btnOK.Click += BtnOK_Click;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DetayGoster()
        {
            textBox1.Text = Detay;
        }



    }
}