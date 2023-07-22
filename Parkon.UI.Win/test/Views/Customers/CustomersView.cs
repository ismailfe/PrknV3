using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.CustomersView{
    public partial class CustomersView : XtraUserControl {
        public CustomersView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.CustomersViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                customersViewBindingSource, x => x.Entity, x => x.Update());
						#region Customer_Contact Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Customer_ContactGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.CustomersCustomer_ContactDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Customer_Contact,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Customer_ContactGridView, "RowClick")
						 .EventToCommand(
						     x => x.CustomersCustomer_ContactDetails.Edit(null), x => x.CustomersCustomer_ContactDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Customer_ContactGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Customer_ContactPopUpMenu.ShowPopup(Customer_ContactGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the CustomersCustomer_ContactDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Customer_ContactGridControl, g => g.DataSource, x => x.CustomersCustomer_ContactDetails.Entities);
			
														fluentAPI.BindCommand(bbiCustomer_ContactNew, x => x.CustomersCustomer_ContactDetails.New());
																													fluentAPI.BindCommand(bbiCustomer_ContactEdit,x => x.CustomersCustomer_ContactDetails.Edit(null), x=>x.CustomersCustomer_ContactDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCustomer_ContactDelete,x => x.CustomersCustomer_ContactDetails.Delete(null), x=>x.CustomersCustomer_ContactDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCustomer_ContactRefresh, x => x.CustomersCustomer_ContactDetails.Refresh());
																	#endregion
						#region Customer_Section Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Customer_SectionGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.CustomersCustomer_SectionDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Customer_Section,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Customer_SectionGridView, "RowClick")
						 .EventToCommand(
						     x => x.CustomersCustomer_SectionDetails.Edit(null), x => x.CustomersCustomer_SectionDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Customer_SectionGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Customer_SectionPopUpMenu.ShowPopup(Customer_SectionGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the CustomersCustomer_SectionDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Customer_SectionGridControl, g => g.DataSource, x => x.CustomersCustomer_SectionDetails.Entities);
			
														fluentAPI.BindCommand(bbiCustomer_SectionNew, x => x.CustomersCustomer_SectionDetails.New());
																													fluentAPI.BindCommand(bbiCustomer_SectionEdit,x => x.CustomersCustomer_SectionDetails.Edit(null), x=>x.CustomersCustomer_SectionDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCustomer_SectionDelete,x => x.CustomersCustomer_SectionDetails.Delete(null), x=>x.CustomersCustomer_SectionDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCustomer_SectionRefresh, x => x.CustomersCustomer_SectionDetails.Refresh());
																	#endregion
						#region Projects Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ProjectsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.CustomersProjectsDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Projects,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ProjectsGridView, "RowClick")
						 .EventToCommand(
						     x => x.CustomersProjectsDetails.Edit(null), x => x.CustomersProjectsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ProjectsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ProjectsPopUpMenu.ShowPopup(ProjectsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the CustomersProjectsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ProjectsGridControl, g => g.DataSource, x => x.CustomersProjectsDetails.Entities);
			
														fluentAPI.BindCommand(bbiProjectsNew, x => x.CustomersProjectsDetails.New());
																													fluentAPI.BindCommand(bbiProjectsEdit,x => x.CustomersProjectsDetails.Edit(null), x=>x.CustomersProjectsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiProjectsDelete,x => x.CustomersProjectsDetails.Delete(null), x=>x.CustomersProjectsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiProjectsRefresh, x => x.CustomersProjectsDetails.Refresh());
																	#endregion
									// Binding for Customer_Type LookUp editor
			fluentAPI.SetBinding(Customer_TypeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCustomer_Type.Entities);
						// Binding for Customers1 LookUp editor
			fluentAPI.SetBinding(Customers1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpCustomers.Entities);
						// Binding for Customers2 LookUp editor
			fluentAPI.SetBinding(Customers2LookUpEdit.Properties, p => p.DataSource, x => x.LookUpCustomers.Entities);
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
