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
using Emikon.Parkon.Common.Enums;

namespace Emikon.Parkon.UI.Win.Forms.Store
{
    public partial class StoreAddressForm : BaseListEditForm
    {
        public StoreAddressForm()
        {
            _userScreen = UserScreen.StokAyarlar;
            Yukle();

            InitializeComponent();
        }
    }
}