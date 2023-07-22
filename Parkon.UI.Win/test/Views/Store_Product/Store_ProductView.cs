using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.Store_ProductView{
    public partial class Store_ProductView : XtraUserControl {
        public Store_ProductView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.Store_ProductViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                store_ProductViewBindingSource, x => x.Entity, x => x.Update());
						#region Store_Warehouse Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_WarehouseGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Store_ProductStore_WarehouseDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_Warehouse,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_WarehouseGridView, "RowClick")
						 .EventToCommand(
						     x => x.Store_ProductStore_WarehouseDetails.Edit(null), x => x.Store_ProductStore_WarehouseDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_WarehouseGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_WarehousePopUpMenu.ShowPopup(Store_WarehouseGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Store_ProductStore_WarehouseDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_WarehouseGridControl, g => g.DataSource, x => x.Store_ProductStore_WarehouseDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_WarehouseNew, x => x.Store_ProductStore_WarehouseDetails.New());
																													fluentAPI.BindCommand(bbiStore_WarehouseEdit,x => x.Store_ProductStore_WarehouseDetails.Edit(null), x=>x.Store_ProductStore_WarehouseDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_WarehouseDelete,x => x.Store_ProductStore_WarehouseDetails.Delete(null), x=>x.Store_ProductStore_WarehouseDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_WarehouseRefresh, x => x.Store_ProductStore_WarehouseDetails.Refresh());
																	#endregion
						#region Store_WarehouseOut Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_WarehouseOutGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Store_ProductStore_WarehouseOutDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_WarehouseOut,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_WarehouseOutGridView, "RowClick")
						 .EventToCommand(
						     x => x.Store_ProductStore_WarehouseOutDetails.Edit(null), x => x.Store_ProductStore_WarehouseOutDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_WarehouseOutGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_WarehouseOutPopUpMenu.ShowPopup(Store_WarehouseOutGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Store_ProductStore_WarehouseOutDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_WarehouseOutGridControl, g => g.DataSource, x => x.Store_ProductStore_WarehouseOutDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_WarehouseOutNew, x => x.Store_ProductStore_WarehouseOutDetails.New());
																													fluentAPI.BindCommand(bbiStore_WarehouseOutEdit,x => x.Store_ProductStore_WarehouseOutDetails.Edit(null), x=>x.Store_ProductStore_WarehouseOutDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_WarehouseOutDelete,x => x.Store_ProductStore_WarehouseOutDetails.Delete(null), x=>x.Store_ProductStore_WarehouseOutDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_WarehouseOutRefresh, x => x.Store_ProductStore_WarehouseOutDetails.Refresh());
																	#endregion
									// Binding for Store_Address LookUp editor
			fluentAPI.SetBinding(Store_AddressLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStore_Address.Entities);
						// Binding for Store_Location LookUp editor
			fluentAPI.SetBinding(Store_LocationLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStore_Location.Entities);
						// Binding for Store_ProductGroup LookUp editor
			fluentAPI.SetBinding(Store_ProductGroupLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStore_ProductGroup.Entities);
						// Binding for Store_ProductType LookUp editor
			fluentAPI.SetBinding(Store_ProductTypeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStore_ProductType.Entities);
						// Binding for Store_ProductUnit LookUp editor
			fluentAPI.SetBinding(Store_ProductUnitLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStore_ProductUnit.Entities);
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
