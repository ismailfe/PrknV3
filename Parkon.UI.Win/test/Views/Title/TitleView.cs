using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.TitleView{
    public partial class TitleView : XtraUserControl {
        public TitleView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.TitleViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                titleViewBindingSource, x => x.Entity, x => x.Update());
						#region Customer_Contact Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Customer_ContactGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.TitleCustomer_ContactDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Customer_Contact,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Customer_ContactGridView, "RowClick")
						 .EventToCommand(
						     x => x.TitleCustomer_ContactDetails.Edit(null), x => x.TitleCustomer_ContactDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Customer_ContactGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Customer_ContactPopUpMenu.ShowPopup(Customer_ContactGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the TitleCustomer_ContactDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Customer_ContactGridControl, g => g.DataSource, x => x.TitleCustomer_ContactDetails.Entities);
			
														fluentAPI.BindCommand(bbiCustomer_ContactNew, x => x.TitleCustomer_ContactDetails.New());
																													fluentAPI.BindCommand(bbiCustomer_ContactEdit,x => x.TitleCustomer_ContactDetails.Edit(null), x=>x.TitleCustomer_ContactDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCustomer_ContactDelete,x => x.TitleCustomer_ContactDetails.Delete(null), x=>x.TitleCustomer_ContactDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCustomer_ContactRefresh, x => x.TitleCustomer_ContactDetails.Refresh());
																	#endregion
						#region Supplier_Contact Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Supplier_ContactGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.TitleSupplier_ContactDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Supplier_Contact,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Supplier_ContactGridView, "RowClick")
						 .EventToCommand(
						     x => x.TitleSupplier_ContactDetails.Edit(null), x => x.TitleSupplier_ContactDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Supplier_ContactGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Supplier_ContactPopUpMenu.ShowPopup(Supplier_ContactGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the TitleSupplier_ContactDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Supplier_ContactGridControl, g => g.DataSource, x => x.TitleSupplier_ContactDetails.Entities);
			
														fluentAPI.BindCommand(bbiSupplier_ContactNew, x => x.TitleSupplier_ContactDetails.New());
																													fluentAPI.BindCommand(bbiSupplier_ContactEdit,x => x.TitleSupplier_ContactDetails.Edit(null), x=>x.TitleSupplier_ContactDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSupplier_ContactDelete,x => x.TitleSupplier_ContactDetails.Delete(null), x=>x.TitleSupplier_ContactDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSupplier_ContactRefresh, x => x.TitleSupplier_ContactDetails.Refresh());
																	#endregion
						#region Users1 Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Users1GridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.TitleUsers1Details.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Users,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Users1GridView, "RowClick")
						 .EventToCommand(
						     x => x.TitleUsers1Details.Edit(null), x => x.TitleUsers1Details.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Users1GridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Users1PopUpMenu.ShowPopup(Users1GridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the TitleUsers1Details collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Users1GridControl, g => g.DataSource, x => x.TitleUsers1Details.Entities);
			
														fluentAPI.BindCommand(bbiUsers1New, x => x.TitleUsers1Details.New());
																													fluentAPI.BindCommand(bbiUsers1Edit,x => x.TitleUsers1Details.Edit(null), x=>x.TitleUsers1Details.SelectedEntity);
																								fluentAPI.BindCommand(bbiUsers1Delete,x => x.TitleUsers1Details.Delete(null), x=>x.TitleUsers1Details.SelectedEntity);
																			fluentAPI.BindCommand(bbiUsers1Refresh, x => x.TitleUsers1Details.Refresh());
																	#endregion
									// Binding for Users LookUp editor
			fluentAPI.SetBinding(UsersLookUpEdit.Properties, p => p.DataSource, x => x.LookUpUsers.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
