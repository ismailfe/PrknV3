﻿using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.Store_AddressPosView{
    public partial class Store_AddressPosView : XtraUserControl {
        public Store_AddressPosView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.Store_AddressPosViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                store_AddressPosViewBindingSource, x => x.Entity, x => x.Update());
						#region Store_Address Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_AddressGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Store_AddressPosStore_AddressDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_Address,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_AddressGridView, "RowClick")
						 .EventToCommand(
						     x => x.Store_AddressPosStore_AddressDetails.Edit(null), x => x.Store_AddressPosStore_AddressDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_AddressGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_AddressPopUpMenu.ShowPopup(Store_AddressGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Store_AddressPosStore_AddressDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_AddressGridControl, g => g.DataSource, x => x.Store_AddressPosStore_AddressDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_AddressNew, x => x.Store_AddressPosStore_AddressDetails.New());
																													fluentAPI.BindCommand(bbiStore_AddressEdit,x => x.Store_AddressPosStore_AddressDetails.Edit(null), x=>x.Store_AddressPosStore_AddressDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_AddressDelete,x => x.Store_AddressPosStore_AddressDetails.Delete(null), x=>x.Store_AddressPosStore_AddressDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_AddressRefresh, x => x.Store_AddressPosStore_AddressDetails.Refresh());
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
