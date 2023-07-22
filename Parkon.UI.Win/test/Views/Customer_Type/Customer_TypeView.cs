using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.Customer_TypeView{
    public partial class Customer_TypeView : XtraUserControl {
        public Customer_TypeView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.Customer_TypeViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                customer_TypeViewBindingSource, x => x.Entity, x => x.Update());
						#region Customers Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(CustomersGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Customer_TypeCustomersDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Customers,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(CustomersGridView, "RowClick")
						 .EventToCommand(
						     x => x.Customer_TypeCustomersDetails.Edit(null), x => x.Customer_TypeCustomersDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			CustomersGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    CustomersPopUpMenu.ShowPopup(CustomersGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Customer_TypeCustomersDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(CustomersGridControl, g => g.DataSource, x => x.Customer_TypeCustomersDetails.Entities);
			
														fluentAPI.BindCommand(bbiCustomersNew, x => x.Customer_TypeCustomersDetails.New());
																													fluentAPI.BindCommand(bbiCustomersEdit,x => x.Customer_TypeCustomersDetails.Edit(null), x=>x.Customer_TypeCustomersDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCustomersDelete,x => x.Customer_TypeCustomersDetails.Delete(null), x=>x.Customer_TypeCustomersDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCustomersRefresh, x => x.Customer_TypeCustomersDetails.Refresh());
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
