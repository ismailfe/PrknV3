using Prkn.Bll.Settings;
using Prkn.Common;
using Prkn.Common.Functions;
using Prkn.Common.Variables;
using Prkn.UI.Win.Functions;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Prkn.UI.Win
{
    public partial class UserLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void Form_UserLogin_Load(object sender, EventArgs e)
        {
            CheckUserLoginOK(CLS.UserLoginOK);
        }

        void CheckUserLoginOK(bool LoginOK)
        {
            LB_Status.Text = string.Empty;

            if (LoginOK)
            {
                TB_Password.UseSystemPasswordChar   = false;
                TB_Password.Enabled                 = true;
                TB_UserName.Enabled                 = true;
                CHB_RememberMe.Enabled              = true;

                if (CLS.OnlineUser != null)
                {
                    TB_UserName.Text = CLS.OnlineUser.UserName;
                    TB_Password.Text = CLS.OnlineUser.Pass;

                    bool.TryParse(SettingsBll.GetRememberMe(), out bool RememberMe);
                    CHB_RememberMe.Checked = RememberMe;
                }
         
                

                TB_Password.UseSystemPasswordChar   = true;
                TB_Password.Enabled                 = false;
                TB_UserName.Enabled                 = false;
                CHB_RememberMe.Enabled              = false;

                B_Logout.Visible                    = true;
            }
            else
            {
                TB_Password.Enabled         = true;
                TB_UserName.Enabled         = true;
                CHB_RememberMe.Enabled      = true;


                B_Logout.Visible = false;
            }
        }

        private void Form_UserLogin_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
        }
        public void Auto_Close()
        {
            Thread.Sleep(1500);
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void B_Login_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LB_Status.Text = string.Empty;

            var LoginStatus = UserLoginLogout.Login(TB_UserName.Text, TB_Password.Text, CHB_RememberMe.Checked);

            if (LoginStatus)
            {
                LB_Status.Text      = "Giriş Başarılı!";

                CheckUserLoginOK(CLS.UserLoginOK);

            }
            else
            {
                LB_Status.Text = "Hatalı kullanıcı adı veya şifre!";
            }

            Cursor.Current = Cursors.Default;
            Thread th = new Thread(Auto_Close);
            th.Start();
        }
        private void B_Cancel_Click(object sender, EventArgs e)
        {

        }
        private void TB_UserName_TextChanged(object sender, EventArgs e)
        {
            if (!CLS.UserLoginOK)
            {
                TB_Password.Clear();
            }
        }
        private void TB_Password_TextChanged(object sender, EventArgs e)
        {

        }
        private void CHB_RememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void B_Logout_Click(object sender, EventArgs e)
        {
            UserLoginLogout.Logout();
            CheckUserLoginOK(CLS.UserLoginOK);
        }


    }
}