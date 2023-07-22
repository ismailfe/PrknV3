using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Prkn.Common.Design.Controls;
using Prkn.Common.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prkn.UI.Win.Functions
{
    public class FormOpen
    {

        public static void PopUp_Add(Form form, object obj)
        {
            //// Finish BarManager initialization (to allow its further customization on the form load)
            //BarManager barManager1 = new BarManager();
            
            //DevExpress.XtraBars.PopupMenu menu = new DevExpress.XtraBars.PopupMenu();
            //menu.Manager = barManager1;
            ////barManager1.Images = imageCollection1;
            //BarButtonItem itemCopy = new BarButtonItem(barManager1, "Copy", 0);
            //BarButtonItem itemPaste = new BarButtonItem(barManager1, "Paste", 1);
            //BarButtonItem itemRefresh = new BarButtonItem(barManager1, "Refresh", 2);
            //menu.AddItems(new BarItem[] { itemCopy, itemPaste, itemRefresh });
            //// Create a separator before the Refresh item.
            //itemRefresh.Links[0].BeginGroup = true;
            //// Process item clicks.
            ////barManager1.ItemClick += BarManager1_ItemClick;
            //// Associate the popup menu with the form.
            //barManager1.SetPopupContextMenu(form, menu);

            //((ComboBoxEdit)obj).PopupContextMenuOnRibbonControl

            ////Point p = new Point(50, 50);
            ////p = form;
            ////menu.ShowPopup(p, form);
        }
        private void BarManager1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XtraMessageBox.Show(e.Item.Caption + " item clicked");
        }


        public static void PopupAdd(List<Object> AddObj)
        {
            for (int i = 0; i < AddObj.Count; i++)
            {
                ((MyComboBoxEdit)AddObj[i]).Cursor = Cursors.Hand;
                ((MyComboBoxEdit)AddObj[i]).MouseDown += (sender, EventArgs) => { MouseDownForRightClick(sender, EventArgs, ShowDialogFormSec.CreateProjectFrom); };
            }
        }

        private static void MouseDownForRightClick(object sender, MouseEventArgs e, ShowDialogFormSec formsec)
        {
            if (e.Button == MouseButtons.Right)
            {

            }
        }

        //public static void Od_CustomerForm()
        //{
        //    CustomerForm frm = new CustomerForm();
        //    frm.ShowDialog();
        //}
        //public static void Od_CustomerSectionForm()
        //{
        //    CustomerSectionForm frm = new CustomerSectionForm();
        //    frm.ShowDialog();
        //}
        //public static void Od_CustomerContactForm()
        //{
        //    CustomerContactForm frm = new CustomerContactForm();
        //    frm.ShowDialog();
        //}

        //public static void Od_SupplierForm()
        //{
        //    SupplierForm frm = new SupplierForm();
        //    frm.ShowDialog();
        //}
        //public static void Od_SupplierSectionForm()
        //{
        //    SupplierSectionForm frm = new SupplierSectionForm();
        //    frm.ShowDialog();
        //}
        //public static void Od_SupplierContactForm()
        //{
        //    SupplierContactForm frm = new SupplierContactForm();
        //    frm.ShowDialog();
        //}

        //public static void Od_TitleForm()
        //{
        //    TitleForm frm = new TitleForm();
        //    frm.ShowDialog();
        //}
        //public static void PopMenuEdit_ItemClick(ShowDialogFormSec secim)
        //{
        //    switch (secim)
        //    {
        //        case ShowDialogFormSec.CustomerForm:
        //            Od_CustomerForm();
        //            break;
        //        case ShowDialogFormSec.CustomerSectionForm:
        //            Od_CustomerSectionForm();
        //            break;
        //        case ShowDialogFormSec.CustomerContactForm:
        //            Od_CustomerContactForm();
        //            break;
        //        default:
        //            break;
        //    }
        //}


        //public static void BtnAdd_Click(object sender, EventArgs e)
        //{
        //    Cursor.Current = Cursors.AppStarting;
        //    switch (((SimpleButton)sender).Name)
        //    {
        //        case "btnAddCustomer":
        //            Od_CustomerForm();

        //            break;
        //        case "btnAddCustomerSection":
        //            Od_CustomerSectionForm();

        //            break;
        //        case "btnAddCustomerContact":
        //            Od_CustomerContactForm();
        //            break;

        //        case "btnAddTitle":
        //            Od_TitleForm();

        //            break;
        //        case "btnAddSupplier":
        //       //     Od_SupplierForm();

        //            break;
        //        case "btnAddSupplierSection":
        //      //      Od_SupplierSectionForm();

        //            break;
        //        case "btnAddSupplierContact":
        //         //   Od_SupplierContactForm();
        //            break;
        //    }

        //    Cursor.Current = Cursors.Default;
        //}
    }
}
