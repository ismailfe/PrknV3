using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.Store_ProductUnitView{
    public partial class Store_ProductUnitView : XtraUserControl {
        public Store_ProductUnitView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.Store_ProductUnitViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                store_ProductUnitViewBindingSource, x => x.Entity, x => x.Update());
						#region Store_Product Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_ProductGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Store_ProductUnitStore_ProductDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_Product,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_ProductGridView, "RowClick")
						 .EventToCommand(
						     x => x.Store_ProductUnitStore_ProductDetails.Edit(null), x => x.Store_ProductUnitStore_ProductDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_ProductGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_ProductPopUpMenu.ShowPopup(Store_ProductGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Store_ProductUnitStore_ProductDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_ProductGridControl, g => g.DataSource, x => x.Store_ProductUnitStore_ProductDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_ProductNew, x => x.Store_ProductUnitStore_ProductDetails.New());
																													fluentAPI.BindCommand(bbiStore_ProductEdit,x => x.Store_ProductUnitStore_ProductDetails.Edit(null), x=>x.Store_ProductUnitStore_ProductDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_ProductDelete,x => x.Store_ProductUnitStore_ProductDetails.Delete(null), x=>x.Store_ProductUnitStore_ProductDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_ProductRefresh, x => x.Store_ProductUnitStore_ProductDetails.Refresh());
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
