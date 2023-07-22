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
using Emikon.Parkon.Common.Variables;
using Emikon.Parkon.Common;
using Emikon.Parkon.Common.Functions;

namespace Emikon.Parkon.UI.Win
{
    public partial class Form_User_PassGenerator : DevExpress.XtraEditors.XtraForm
    {
        public Form_User_PassGenerator()
        {
            InitializeComponent();
        }

        private void B_Sifrele_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_Veri.Text))
            {
                TB_CryptoVeri.Text = Crypto.Encrypt(TB_Veri.Text, Global.Str_ProjeCrypto);
            }
        }


        private void B_Coz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_CozulecekVeri.Text))
            {
                TB_CozulenVeri.Text = Crypto.Decrypt(TB_CozulecekVeri.Text, Global.Str_ProjeCrypto);
            }
        }
    }
}