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
using Emikon.Parkon.UI.Win.Forms.Base;
using Emikon.Parkon.Bll.Settings;
using Emikon.Parkon.Bll.User;

namespace Emikon.Parkon.UI.Win.Forms.User
{
    public partial class UserSystemLogsForm : BaseListEditFreeLayoutForm
    {
        public UserSystemLogsForm()
        {
            InitializeComponent();
            DataLayoutControl               = myDataLayoutControl1;
            Tablo                           = baseTablo;
            Navigator.NavigatableControl    = Tablo.GridControl;

            EventsLoad();
            EventsLoadForList();
         

            Text                = "Kullanıcı Sistem Logları";
            Tablo.ViewCaption   = Text;

            Tablo.GridControl.DataSource = UserSystemLogsBll.ListRefresh();
        }


    }
}