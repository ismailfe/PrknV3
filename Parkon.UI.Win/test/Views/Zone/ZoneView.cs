using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.ZoneView{
    public partial class ZoneView : XtraUserControl {
        public ZoneView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.ZoneViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                zoneViewBindingSource, x => x.Entity, x => x.Update());
						#region Customer_Section Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Customer_SectionGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ZoneCustomer_SectionDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Customer_Section,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Customer_SectionGridView, "RowClick")
						 .EventToCommand(
						     x => x.ZoneCustomer_SectionDetails.Edit(null), x => x.ZoneCustomer_SectionDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Customer_SectionGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Customer_SectionPopUpMenu.ShowPopup(Customer_SectionGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ZoneCustomer_SectionDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Customer_SectionGridControl, g => g.DataSource, x => x.ZoneCustomer_SectionDetails.Entities);
			
														fluentAPI.BindCommand(bbiCustomer_SectionNew, x => x.ZoneCustomer_SectionDetails.New());
																													fluentAPI.BindCommand(bbiCustomer_SectionEdit,x => x.ZoneCustomer_SectionDetails.Edit(null), x=>x.ZoneCustomer_SectionDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCustomer_SectionDelete,x => x.ZoneCustomer_SectionDetails.Delete(null), x=>x.ZoneCustomer_SectionDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCustomer_SectionRefresh, x => x.ZoneCustomer_SectionDetails.Refresh());
																	#endregion
						#region Customers Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(CustomersGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ZoneCustomersDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Customers,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(CustomersGridView, "RowClick")
						 .EventToCommand(
						     x => x.ZoneCustomersDetails.Edit(null), x => x.ZoneCustomersDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			CustomersGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    CustomersPopUpMenu.ShowPopup(CustomersGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ZoneCustomersDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(CustomersGridControl, g => g.DataSource, x => x.ZoneCustomersDetails.Entities);
			
														fluentAPI.BindCommand(bbiCustomersNew, x => x.ZoneCustomersDetails.New());
																													fluentAPI.BindCommand(bbiCustomersEdit,x => x.ZoneCustomersDetails.Edit(null), x=>x.ZoneCustomersDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCustomersDelete,x => x.ZoneCustomersDetails.Delete(null), x=>x.ZoneCustomersDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCustomersRefresh, x => x.ZoneCustomersDetails.Refresh());
																	#endregion
						#region Supplier_Section Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Supplier_SectionGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ZoneSupplier_SectionDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Supplier_Section,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Supplier_SectionGridView, "RowClick")
						 .EventToCommand(
						     x => x.ZoneSupplier_SectionDetails.Edit(null), x => x.ZoneSupplier_SectionDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Supplier_SectionGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Supplier_SectionPopUpMenu.ShowPopup(Supplier_SectionGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ZoneSupplier_SectionDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Supplier_SectionGridControl, g => g.DataSource, x => x.ZoneSupplier_SectionDetails.Entities);
			
														fluentAPI.BindCommand(bbiSupplier_SectionNew, x => x.ZoneSupplier_SectionDetails.New());
																													fluentAPI.BindCommand(bbiSupplier_SectionEdit,x => x.ZoneSupplier_SectionDetails.Edit(null), x=>x.ZoneSupplier_SectionDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSupplier_SectionDelete,x => x.ZoneSupplier_SectionDetails.Delete(null), x=>x.ZoneSupplier_SectionDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSupplier_SectionRefresh, x => x.ZoneSupplier_SectionDetails.Refresh());
																	#endregion
						#region Suppliers Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SuppliersGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ZoneSuppliersDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Suppliers,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SuppliersGridView, "RowClick")
						 .EventToCommand(
						     x => x.ZoneSuppliersDetails.Edit(null), x => x.ZoneSuppliersDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SuppliersGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SuppliersPopUpMenu.ShowPopup(SuppliersGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ZoneSuppliersDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SuppliersGridControl, g => g.DataSource, x => x.ZoneSuppliersDetails.Entities);
			
														fluentAPI.BindCommand(bbiSuppliersNew, x => x.ZoneSuppliersDetails.New());
																													fluentAPI.BindCommand(bbiSuppliersEdit,x => x.ZoneSuppliersDetails.Edit(null), x=>x.ZoneSuppliersDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSuppliersDelete,x => x.ZoneSuppliersDetails.Delete(null), x=>x.ZoneSuppliersDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSuppliersRefresh, x => x.ZoneSuppliersDetails.Refresh());
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
