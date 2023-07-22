using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars.Navigation;

namespace Emikon.Parkon.UI.Win.test.Views.DB_EMKPRKNEntitiesView{
    public partial class DB_EMKPRKNEntitiesView : XtraUserControl {
        public DB_EMKPRKNEntitiesView() {
		     InitializeComponent();
			 if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
        }
        void InitializeNavigation() {
			DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            float fontSize = 10f;
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", fontSize);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = new System.Drawing.Font("Segoe UI", fontSize);

			tileBar.SelectionColorMode = SelectionColorMode.UseItemBackColor;
            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            DevExpress.Utils.MVVM.MVVMContext.RegisterFlyoutDialogService();
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.DB_EMKPRKNEntitiesViewModel>();
						tileBar.SelectedItem = tileBarItemCustomer_ContactCollectionView;

			            fluentAPI.BindCommand(tileBarItemCustomer_ContactCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			            fluentAPI.BindCommand(tileBarItemCustomer_SectionCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			            fluentAPI.BindCommand(tileBarItemCustomer_TypeCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			            fluentAPI.BindCommand(tileBarItemCustomersCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			            fluentAPI.BindCommand(tileBarItemKeywordCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			            fluentAPI.BindCommand(tileBarItemLicensesCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			            fluentAPI.BindCommand(tileBarItemProject_DetailCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
			            fluentAPI.BindCommand(tileBarItemProject_RevCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
			            fluentAPI.BindCommand(tileBarItemProjectsCollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
			            fluentAPI.BindCommand(tileBarItemStore_AddressCollectionView, (x, m) => x.Show(m), x => x.Modules[9]);
			            fluentAPI.BindCommand(tileBarItemStore_AddressColCollectionView, (x, m) => x.Show(m), x => x.Modules[10]);
			            fluentAPI.BindCommand(tileBarItemStore_AddressPosCollectionView, (x, m) => x.Show(m), x => x.Modules[11]);
			            fluentAPI.BindCommand(tileBarItemStore_AddressRowCollectionView, (x, m) => x.Show(m), x => x.Modules[12]);
			            fluentAPI.BindCommand(tileBarItemStore_AddressZoneCollectionView, (x, m) => x.Show(m), x => x.Modules[13]);
			            fluentAPI.BindCommand(tileBarItemStore_BrandCollectionView, (x, m) => x.Show(m), x => x.Modules[14]);
			            fluentAPI.BindCommand(tileBarItemStore_LocationCollectionView, (x, m) => x.Show(m), x => x.Modules[15]);
			            fluentAPI.BindCommand(tileBarItemStore_LogsCollectionView, (x, m) => x.Show(m), x => x.Modules[16]);
			            fluentAPI.BindCommand(tileBarItemStore_OutActionCollectionView, (x, m) => x.Show(m), x => x.Modules[17]);
			            fluentAPI.BindCommand(tileBarItemStore_ProductCollectionView, (x, m) => x.Show(m), x => x.Modules[18]);
			            fluentAPI.BindCommand(tileBarItemStore_ProductBlockCollectionView, (x, m) => x.Show(m), x => x.Modules[19]);
			            fluentAPI.BindCommand(tileBarItemStore_ProductGroupCollectionView, (x, m) => x.Show(m), x => x.Modules[20]);
			            fluentAPI.BindCommand(tileBarItemStore_ProductTypeCollectionView, (x, m) => x.Show(m), x => x.Modules[21]);
			            fluentAPI.BindCommand(tileBarItemStore_ProductUnitCollectionView, (x, m) => x.Show(m), x => x.Modules[22]);
			            fluentAPI.BindCommand(tileBarItemStore_WarehouseCollectionView, (x, m) => x.Show(m), x => x.Modules[23]);
			            fluentAPI.BindCommand(tileBarItemStore_WarehouseOutCollectionView, (x, m) => x.Show(m), x => x.Modules[24]);
			            fluentAPI.BindCommand(tileBarItemSupplier_ContactCollectionView, (x, m) => x.Show(m), x => x.Modules[25]);
			            fluentAPI.BindCommand(tileBarItemSupplier_SectionCollectionView, (x, m) => x.Show(m), x => x.Modules[26]);
			            fluentAPI.BindCommand(tileBarItemSupplier_TypeCollectionView, (x, m) => x.Show(m), x => x.Modules[27]);
			            fluentAPI.BindCommand(tileBarItemSuppliersCollectionView, (x, m) => x.Show(m), x => x.Modules[28]);
			            fluentAPI.BindCommand(tileBarItemtestCollectionView, (x, m) => x.Show(m), x => x.Modules[29]);
			            fluentAPI.BindCommand(tileBarItemTitleCollectionView, (x, m) => x.Show(m), x => x.Modules[30]);
			            fluentAPI.BindCommand(tileBarItemUser_AccessCollectionView, (x, m) => x.Show(m), x => x.Modules[31]);
			            fluentAPI.BindCommand(tileBarItemUser_AuthorizationCollectionView, (x, m) => x.Show(m), x => x.Modules[32]);
			            fluentAPI.BindCommand(tileBarItemUser_DepartmentCollectionView, (x, m) => x.Show(m), x => x.Modules[33]);
			            fluentAPI.BindCommand(tileBarItemUser_LevelCollectionView, (x, m) => x.Show(m), x => x.Modules[34]);
			            fluentAPI.BindCommand(tileBarItemUser_LogsCollectionView, (x, m) => x.Show(m), x => x.Modules[35]);
			            fluentAPI.BindCommand(tileBarItemUser_OnlineCollectionView, (x, m) => x.Show(m), x => x.Modules[36]);
			            fluentAPI.BindCommand(tileBarItemUsersCollectionView, (x, m) => x.Show(m), x => x.Modules[37]);
			            fluentAPI.BindCommand(tileBarItemZoneCollectionView, (x, m) => x.Show(m), x => x.Modules[38]);
						            // We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
		
        }
    }
}
