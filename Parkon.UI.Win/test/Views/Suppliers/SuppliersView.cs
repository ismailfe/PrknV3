using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.SuppliersView{
    public partial class SuppliersView : XtraUserControl {
        public SuppliersView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.SuppliersViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                suppliersViewBindingSource, x => x.Entity, x => x.Update());
						#region Supplier_Contact Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Supplier_ContactGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SuppliersSupplier_ContactDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Supplier_Contact,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Supplier_ContactGridView, "RowClick")
						 .EventToCommand(
						     x => x.SuppliersSupplier_ContactDetails.Edit(null), x => x.SuppliersSupplier_ContactDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Supplier_ContactGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Supplier_ContactPopUpMenu.ShowPopup(Supplier_ContactGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SuppliersSupplier_ContactDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Supplier_ContactGridControl, g => g.DataSource, x => x.SuppliersSupplier_ContactDetails.Entities);
			
														fluentAPI.BindCommand(bbiSupplier_ContactNew, x => x.SuppliersSupplier_ContactDetails.New());
																													fluentAPI.BindCommand(bbiSupplier_ContactEdit,x => x.SuppliersSupplier_ContactDetails.Edit(null), x=>x.SuppliersSupplier_ContactDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSupplier_ContactDelete,x => x.SuppliersSupplier_ContactDetails.Delete(null), x=>x.SuppliersSupplier_ContactDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSupplier_ContactRefresh, x => x.SuppliersSupplier_ContactDetails.Refresh());
																	#endregion
						#region Supplier_Section Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Supplier_SectionGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SuppliersSupplier_SectionDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Supplier_Section,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Supplier_SectionGridView, "RowClick")
						 .EventToCommand(
						     x => x.SuppliersSupplier_SectionDetails.Edit(null), x => x.SuppliersSupplier_SectionDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Supplier_SectionGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Supplier_SectionPopUpMenu.ShowPopup(Supplier_SectionGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SuppliersSupplier_SectionDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Supplier_SectionGridControl, g => g.DataSource, x => x.SuppliersSupplier_SectionDetails.Entities);
			
														fluentAPI.BindCommand(bbiSupplier_SectionNew, x => x.SuppliersSupplier_SectionDetails.New());
																													fluentAPI.BindCommand(bbiSupplier_SectionEdit,x => x.SuppliersSupplier_SectionDetails.Edit(null), x=>x.SuppliersSupplier_SectionDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSupplier_SectionDelete,x => x.SuppliersSupplier_SectionDetails.Delete(null), x=>x.SuppliersSupplier_SectionDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSupplier_SectionRefresh, x => x.SuppliersSupplier_SectionDetails.Refresh());
																	#endregion
									// Binding for Supplier_Type LookUp editor
			fluentAPI.SetBinding(Supplier_TypeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpSupplier_Type.Entities);
						// Binding for Users LookUp editor
			fluentAPI.SetBinding(UsersLookUpEdit.Properties, p => p.DataSource, x => x.LookUpUsers.Entities);
						// Binding for Zone LookUp editor
			fluentAPI.SetBinding(ZoneLookUpEdit.Properties, p => p.DataSource, x => x.LookUpZone.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
