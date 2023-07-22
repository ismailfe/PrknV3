using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.UsersView{
    public partial class UsersView : XtraUserControl {
        public UsersView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.UsersViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                usersViewBindingSource, x => x.Entity, x => x.Update());
						#region Customer_Contact Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Customer_ContactGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersCustomer_ContactDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Customer_Contact,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Customer_ContactGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersCustomer_ContactDetails.Edit(null), x => x.UsersCustomer_ContactDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Customer_ContactGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Customer_ContactPopUpMenu.ShowPopup(Customer_ContactGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersCustomer_ContactDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Customer_ContactGridControl, g => g.DataSource, x => x.UsersCustomer_ContactDetails.Entities);
			
														fluentAPI.BindCommand(bbiCustomer_ContactNew, x => x.UsersCustomer_ContactDetails.New());
																													fluentAPI.BindCommand(bbiCustomer_ContactEdit,x => x.UsersCustomer_ContactDetails.Edit(null), x=>x.UsersCustomer_ContactDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCustomer_ContactDelete,x => x.UsersCustomer_ContactDetails.Delete(null), x=>x.UsersCustomer_ContactDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCustomer_ContactRefresh, x => x.UsersCustomer_ContactDetails.Refresh());
																	#endregion
						#region Customer_Type Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Customer_TypeGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersCustomer_TypeDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Customer_Type,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Customer_TypeGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersCustomer_TypeDetails.Edit(null), x => x.UsersCustomer_TypeDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Customer_TypeGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Customer_TypePopUpMenu.ShowPopup(Customer_TypeGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersCustomer_TypeDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Customer_TypeGridControl, g => g.DataSource, x => x.UsersCustomer_TypeDetails.Entities);
			
														fluentAPI.BindCommand(bbiCustomer_TypeNew, x => x.UsersCustomer_TypeDetails.New());
																													fluentAPI.BindCommand(bbiCustomer_TypeEdit,x => x.UsersCustomer_TypeDetails.Edit(null), x=>x.UsersCustomer_TypeDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCustomer_TypeDelete,x => x.UsersCustomer_TypeDetails.Delete(null), x=>x.UsersCustomer_TypeDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCustomer_TypeRefresh, x => x.UsersCustomer_TypeDetails.Refresh());
																	#endregion
						#region Customers Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(CustomersGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersCustomersDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Customers,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(CustomersGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersCustomersDetails.Edit(null), x => x.UsersCustomersDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			CustomersGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    CustomersPopUpMenu.ShowPopup(CustomersGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersCustomersDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(CustomersGridControl, g => g.DataSource, x => x.UsersCustomersDetails.Entities);
			
														fluentAPI.BindCommand(bbiCustomersNew, x => x.UsersCustomersDetails.New());
																													fluentAPI.BindCommand(bbiCustomersEdit,x => x.UsersCustomersDetails.Edit(null), x=>x.UsersCustomersDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiCustomersDelete,x => x.UsersCustomersDetails.Delete(null), x=>x.UsersCustomersDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiCustomersRefresh, x => x.UsersCustomersDetails.Refresh());
																	#endregion
						#region Keyword Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(KeywordGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersKeywordDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Keyword,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(KeywordGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersKeywordDetails.Edit(null), x => x.UsersKeywordDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			KeywordGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    KeywordPopUpMenu.ShowPopup(KeywordGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersKeywordDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(KeywordGridControl, g => g.DataSource, x => x.UsersKeywordDetails.Entities);
			
														fluentAPI.BindCommand(bbiKeywordNew, x => x.UsersKeywordDetails.New());
																													fluentAPI.BindCommand(bbiKeywordEdit,x => x.UsersKeywordDetails.Edit(null), x=>x.UsersKeywordDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiKeywordDelete,x => x.UsersKeywordDetails.Delete(null), x=>x.UsersKeywordDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiKeywordRefresh, x => x.UsersKeywordDetails.Refresh());
																	#endregion
						#region Licenses Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(LicensesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersLicensesDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Licenses,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(LicensesGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersLicensesDetails.Edit(null), x => x.UsersLicensesDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			LicensesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    LicensesPopUpMenu.ShowPopup(LicensesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersLicensesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(LicensesGridControl, g => g.DataSource, x => x.UsersLicensesDetails.Entities);
			
														fluentAPI.BindCommand(bbiLicensesNew, x => x.UsersLicensesDetails.New());
																													fluentAPI.BindCommand(bbiLicensesEdit,x => x.UsersLicensesDetails.Edit(null), x=>x.UsersLicensesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiLicensesDelete,x => x.UsersLicensesDetails.Delete(null), x=>x.UsersLicensesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiLicensesRefresh, x => x.UsersLicensesDetails.Refresh());
																	#endregion
						#region Project_Detail Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Project_DetailGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersProject_DetailDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Project_Detail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Project_DetailGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersProject_DetailDetails.Edit(null), x => x.UsersProject_DetailDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Project_DetailGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Project_DetailPopUpMenu.ShowPopup(Project_DetailGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersProject_DetailDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Project_DetailGridControl, g => g.DataSource, x => x.UsersProject_DetailDetails.Entities);
			
														fluentAPI.BindCommand(bbiProject_DetailNew, x => x.UsersProject_DetailDetails.New());
																													fluentAPI.BindCommand(bbiProject_DetailEdit,x => x.UsersProject_DetailDetails.Edit(null), x=>x.UsersProject_DetailDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiProject_DetailDelete,x => x.UsersProject_DetailDetails.Delete(null), x=>x.UsersProject_DetailDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiProject_DetailRefresh, x => x.UsersProject_DetailDetails.Refresh());
																	#endregion
						#region Project_Rev Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Project_RevGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersProject_RevDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Project_Rev,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Project_RevGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersProject_RevDetails.Edit(null), x => x.UsersProject_RevDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Project_RevGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Project_RevPopUpMenu.ShowPopup(Project_RevGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersProject_RevDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Project_RevGridControl, g => g.DataSource, x => x.UsersProject_RevDetails.Entities);
			
														fluentAPI.BindCommand(bbiProject_RevNew, x => x.UsersProject_RevDetails.New());
																													fluentAPI.BindCommand(bbiProject_RevEdit,x => x.UsersProject_RevDetails.Edit(null), x=>x.UsersProject_RevDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiProject_RevDelete,x => x.UsersProject_RevDetails.Delete(null), x=>x.UsersProject_RevDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiProject_RevRefresh, x => x.UsersProject_RevDetails.Refresh());
																	#endregion
						#region Projects Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ProjectsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersProjectsDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Projects,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ProjectsGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersProjectsDetails.Edit(null), x => x.UsersProjectsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ProjectsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ProjectsPopUpMenu.ShowPopup(ProjectsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersProjectsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ProjectsGridControl, g => g.DataSource, x => x.UsersProjectsDetails.Entities);
			
														fluentAPI.BindCommand(bbiProjectsNew, x => x.UsersProjectsDetails.New());
																													fluentAPI.BindCommand(bbiProjectsEdit,x => x.UsersProjectsDetails.Edit(null), x=>x.UsersProjectsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiProjectsDelete,x => x.UsersProjectsDetails.Delete(null), x=>x.UsersProjectsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiProjectsRefresh, x => x.UsersProjectsDetails.Refresh());
																	#endregion
						#region Store_Address Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_AddressGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_AddressDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_Address,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_AddressGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_AddressDetails.Edit(null), x => x.UsersStore_AddressDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_AddressGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_AddressPopUpMenu.ShowPopup(Store_AddressGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_AddressDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_AddressGridControl, g => g.DataSource, x => x.UsersStore_AddressDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_AddressNew, x => x.UsersStore_AddressDetails.New());
																													fluentAPI.BindCommand(bbiStore_AddressEdit,x => x.UsersStore_AddressDetails.Edit(null), x=>x.UsersStore_AddressDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_AddressDelete,x => x.UsersStore_AddressDetails.Delete(null), x=>x.UsersStore_AddressDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_AddressRefresh, x => x.UsersStore_AddressDetails.Refresh());
																	#endregion
						#region Store_AddressCol Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_AddressColGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_AddressColDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_AddressCol,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_AddressColGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_AddressColDetails.Edit(null), x => x.UsersStore_AddressColDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_AddressColGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_AddressColPopUpMenu.ShowPopup(Store_AddressColGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_AddressColDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_AddressColGridControl, g => g.DataSource, x => x.UsersStore_AddressColDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_AddressColNew, x => x.UsersStore_AddressColDetails.New());
																													fluentAPI.BindCommand(bbiStore_AddressColEdit,x => x.UsersStore_AddressColDetails.Edit(null), x=>x.UsersStore_AddressColDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_AddressColDelete,x => x.UsersStore_AddressColDetails.Delete(null), x=>x.UsersStore_AddressColDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_AddressColRefresh, x => x.UsersStore_AddressColDetails.Refresh());
																	#endregion
						#region Store_AddressPos Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_AddressPosGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_AddressPosDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_AddressPos,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_AddressPosGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_AddressPosDetails.Edit(null), x => x.UsersStore_AddressPosDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_AddressPosGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_AddressPosPopUpMenu.ShowPopup(Store_AddressPosGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_AddressPosDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_AddressPosGridControl, g => g.DataSource, x => x.UsersStore_AddressPosDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_AddressPosNew, x => x.UsersStore_AddressPosDetails.New());
																													fluentAPI.BindCommand(bbiStore_AddressPosEdit,x => x.UsersStore_AddressPosDetails.Edit(null), x=>x.UsersStore_AddressPosDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_AddressPosDelete,x => x.UsersStore_AddressPosDetails.Delete(null), x=>x.UsersStore_AddressPosDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_AddressPosRefresh, x => x.UsersStore_AddressPosDetails.Refresh());
																	#endregion
						#region Store_AddressRow Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_AddressRowGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_AddressRowDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_AddressRow,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_AddressRowGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_AddressRowDetails.Edit(null), x => x.UsersStore_AddressRowDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_AddressRowGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_AddressRowPopUpMenu.ShowPopup(Store_AddressRowGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_AddressRowDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_AddressRowGridControl, g => g.DataSource, x => x.UsersStore_AddressRowDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_AddressRowNew, x => x.UsersStore_AddressRowDetails.New());
																													fluentAPI.BindCommand(bbiStore_AddressRowEdit,x => x.UsersStore_AddressRowDetails.Edit(null), x=>x.UsersStore_AddressRowDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_AddressRowDelete,x => x.UsersStore_AddressRowDetails.Delete(null), x=>x.UsersStore_AddressRowDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_AddressRowRefresh, x => x.UsersStore_AddressRowDetails.Refresh());
																	#endregion
						#region Store_AddressZone Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_AddressZoneGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_AddressZoneDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_AddressZone,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_AddressZoneGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_AddressZoneDetails.Edit(null), x => x.UsersStore_AddressZoneDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_AddressZoneGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_AddressZonePopUpMenu.ShowPopup(Store_AddressZoneGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_AddressZoneDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_AddressZoneGridControl, g => g.DataSource, x => x.UsersStore_AddressZoneDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_AddressZoneNew, x => x.UsersStore_AddressZoneDetails.New());
																													fluentAPI.BindCommand(bbiStore_AddressZoneEdit,x => x.UsersStore_AddressZoneDetails.Edit(null), x=>x.UsersStore_AddressZoneDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_AddressZoneDelete,x => x.UsersStore_AddressZoneDetails.Delete(null), x=>x.UsersStore_AddressZoneDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_AddressZoneRefresh, x => x.UsersStore_AddressZoneDetails.Refresh());
																	#endregion
						#region Store_Brand Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_BrandGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_BrandDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_Brand,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_BrandGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_BrandDetails.Edit(null), x => x.UsersStore_BrandDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_BrandGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_BrandPopUpMenu.ShowPopup(Store_BrandGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_BrandDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_BrandGridControl, g => g.DataSource, x => x.UsersStore_BrandDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_BrandNew, x => x.UsersStore_BrandDetails.New());
																													fluentAPI.BindCommand(bbiStore_BrandEdit,x => x.UsersStore_BrandDetails.Edit(null), x=>x.UsersStore_BrandDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_BrandDelete,x => x.UsersStore_BrandDetails.Delete(null), x=>x.UsersStore_BrandDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_BrandRefresh, x => x.UsersStore_BrandDetails.Refresh());
																	#endregion
						#region Store_Location Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_LocationGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_LocationDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_Location,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_LocationGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_LocationDetails.Edit(null), x => x.UsersStore_LocationDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_LocationGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_LocationPopUpMenu.ShowPopup(Store_LocationGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_LocationDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_LocationGridControl, g => g.DataSource, x => x.UsersStore_LocationDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_LocationNew, x => x.UsersStore_LocationDetails.New());
																													fluentAPI.BindCommand(bbiStore_LocationEdit,x => x.UsersStore_LocationDetails.Edit(null), x=>x.UsersStore_LocationDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_LocationDelete,x => x.UsersStore_LocationDetails.Delete(null), x=>x.UsersStore_LocationDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_LocationRefresh, x => x.UsersStore_LocationDetails.Refresh());
																	#endregion
						#region Store_Logs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_LogsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_LogsDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_Logs,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_LogsGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_LogsDetails.Edit(null), x => x.UsersStore_LogsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_LogsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_LogsPopUpMenu.ShowPopup(Store_LogsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_LogsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_LogsGridControl, g => g.DataSource, x => x.UsersStore_LogsDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_LogsNew, x => x.UsersStore_LogsDetails.New());
																													fluentAPI.BindCommand(bbiStore_LogsEdit,x => x.UsersStore_LogsDetails.Edit(null), x=>x.UsersStore_LogsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_LogsDelete,x => x.UsersStore_LogsDetails.Delete(null), x=>x.UsersStore_LogsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_LogsRefresh, x => x.UsersStore_LogsDetails.Refresh());
																	#endregion
						#region Store_OutAction Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_OutActionGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_OutActionDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_OutAction,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_OutActionGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_OutActionDetails.Edit(null), x => x.UsersStore_OutActionDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_OutActionGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_OutActionPopUpMenu.ShowPopup(Store_OutActionGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_OutActionDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_OutActionGridControl, g => g.DataSource, x => x.UsersStore_OutActionDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_OutActionNew, x => x.UsersStore_OutActionDetails.New());
																													fluentAPI.BindCommand(bbiStore_OutActionEdit,x => x.UsersStore_OutActionDetails.Edit(null), x=>x.UsersStore_OutActionDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_OutActionDelete,x => x.UsersStore_OutActionDetails.Delete(null), x=>x.UsersStore_OutActionDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_OutActionRefresh, x => x.UsersStore_OutActionDetails.Refresh());
																	#endregion
						#region Store_Product Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_ProductGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_ProductDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_Product,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_ProductGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_ProductDetails.Edit(null), x => x.UsersStore_ProductDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_ProductGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_ProductPopUpMenu.ShowPopup(Store_ProductGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_ProductDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_ProductGridControl, g => g.DataSource, x => x.UsersStore_ProductDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_ProductNew, x => x.UsersStore_ProductDetails.New());
																													fluentAPI.BindCommand(bbiStore_ProductEdit,x => x.UsersStore_ProductDetails.Edit(null), x=>x.UsersStore_ProductDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_ProductDelete,x => x.UsersStore_ProductDetails.Delete(null), x=>x.UsersStore_ProductDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_ProductRefresh, x => x.UsersStore_ProductDetails.Refresh());
																	#endregion
						#region Store_ProductGroup Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_ProductGroupGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_ProductGroupDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_ProductGroup,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_ProductGroupGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_ProductGroupDetails.Edit(null), x => x.UsersStore_ProductGroupDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_ProductGroupGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_ProductGroupPopUpMenu.ShowPopup(Store_ProductGroupGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_ProductGroupDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_ProductGroupGridControl, g => g.DataSource, x => x.UsersStore_ProductGroupDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_ProductGroupNew, x => x.UsersStore_ProductGroupDetails.New());
																													fluentAPI.BindCommand(bbiStore_ProductGroupEdit,x => x.UsersStore_ProductGroupDetails.Edit(null), x=>x.UsersStore_ProductGroupDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_ProductGroupDelete,x => x.UsersStore_ProductGroupDetails.Delete(null), x=>x.UsersStore_ProductGroupDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_ProductGroupRefresh, x => x.UsersStore_ProductGroupDetails.Refresh());
																	#endregion
						#region Store_ProductType Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_ProductTypeGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_ProductTypeDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_ProductType,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_ProductTypeGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_ProductTypeDetails.Edit(null), x => x.UsersStore_ProductTypeDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_ProductTypeGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_ProductTypePopUpMenu.ShowPopup(Store_ProductTypeGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_ProductTypeDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_ProductTypeGridControl, g => g.DataSource, x => x.UsersStore_ProductTypeDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_ProductTypeNew, x => x.UsersStore_ProductTypeDetails.New());
																													fluentAPI.BindCommand(bbiStore_ProductTypeEdit,x => x.UsersStore_ProductTypeDetails.Edit(null), x=>x.UsersStore_ProductTypeDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_ProductTypeDelete,x => x.UsersStore_ProductTypeDetails.Delete(null), x=>x.UsersStore_ProductTypeDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_ProductTypeRefresh, x => x.UsersStore_ProductTypeDetails.Refresh());
																	#endregion
						#region Store_ProductUnit Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_ProductUnitGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_ProductUnitDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_ProductUnit,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_ProductUnitGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_ProductUnitDetails.Edit(null), x => x.UsersStore_ProductUnitDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_ProductUnitGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_ProductUnitPopUpMenu.ShowPopup(Store_ProductUnitGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_ProductUnitDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_ProductUnitGridControl, g => g.DataSource, x => x.UsersStore_ProductUnitDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_ProductUnitNew, x => x.UsersStore_ProductUnitDetails.New());
																													fluentAPI.BindCommand(bbiStore_ProductUnitEdit,x => x.UsersStore_ProductUnitDetails.Edit(null), x=>x.UsersStore_ProductUnitDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_ProductUnitDelete,x => x.UsersStore_ProductUnitDetails.Delete(null), x=>x.UsersStore_ProductUnitDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_ProductUnitRefresh, x => x.UsersStore_ProductUnitDetails.Refresh());
																	#endregion
						#region Store_Warehouse Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_WarehouseGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_WarehouseDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_Warehouse,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_WarehouseGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_WarehouseDetails.Edit(null), x => x.UsersStore_WarehouseDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_WarehouseGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_WarehousePopUpMenu.ShowPopup(Store_WarehouseGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_WarehouseDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_WarehouseGridControl, g => g.DataSource, x => x.UsersStore_WarehouseDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_WarehouseNew, x => x.UsersStore_WarehouseDetails.New());
																													fluentAPI.BindCommand(bbiStore_WarehouseEdit,x => x.UsersStore_WarehouseDetails.Edit(null), x=>x.UsersStore_WarehouseDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_WarehouseDelete,x => x.UsersStore_WarehouseDetails.Delete(null), x=>x.UsersStore_WarehouseDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_WarehouseRefresh, x => x.UsersStore_WarehouseDetails.Refresh());
																	#endregion
						#region Store_WarehouseOut Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Store_WarehouseOutGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStore_WarehouseOutDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Store_WarehouseOut,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Store_WarehouseOutGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersStore_WarehouseOutDetails.Edit(null), x => x.UsersStore_WarehouseOutDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Store_WarehouseOutGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Store_WarehouseOutPopUpMenu.ShowPopup(Store_WarehouseOutGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersStore_WarehouseOutDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Store_WarehouseOutGridControl, g => g.DataSource, x => x.UsersStore_WarehouseOutDetails.Entities);
			
														fluentAPI.BindCommand(bbiStore_WarehouseOutNew, x => x.UsersStore_WarehouseOutDetails.New());
																													fluentAPI.BindCommand(bbiStore_WarehouseOutEdit,x => x.UsersStore_WarehouseOutDetails.Edit(null), x=>x.UsersStore_WarehouseOutDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiStore_WarehouseOutDelete,x => x.UsersStore_WarehouseOutDetails.Delete(null), x=>x.UsersStore_WarehouseOutDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiStore_WarehouseOutRefresh, x => x.UsersStore_WarehouseOutDetails.Refresh());
																	#endregion
						#region Supplier_Contact Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Supplier_ContactGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersSupplier_ContactDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Supplier_Contact,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Supplier_ContactGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersSupplier_ContactDetails.Edit(null), x => x.UsersSupplier_ContactDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Supplier_ContactGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Supplier_ContactPopUpMenu.ShowPopup(Supplier_ContactGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersSupplier_ContactDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Supplier_ContactGridControl, g => g.DataSource, x => x.UsersSupplier_ContactDetails.Entities);
			
														fluentAPI.BindCommand(bbiSupplier_ContactNew, x => x.UsersSupplier_ContactDetails.New());
																													fluentAPI.BindCommand(bbiSupplier_ContactEdit,x => x.UsersSupplier_ContactDetails.Edit(null), x=>x.UsersSupplier_ContactDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSupplier_ContactDelete,x => x.UsersSupplier_ContactDetails.Delete(null), x=>x.UsersSupplier_ContactDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSupplier_ContactRefresh, x => x.UsersSupplier_ContactDetails.Refresh());
																	#endregion
						#region Supplier_Section Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Supplier_SectionGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersSupplier_SectionDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Supplier_Section,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Supplier_SectionGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersSupplier_SectionDetails.Edit(null), x => x.UsersSupplier_SectionDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Supplier_SectionGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Supplier_SectionPopUpMenu.ShowPopup(Supplier_SectionGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersSupplier_SectionDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Supplier_SectionGridControl, g => g.DataSource, x => x.UsersSupplier_SectionDetails.Entities);
			
														fluentAPI.BindCommand(bbiSupplier_SectionNew, x => x.UsersSupplier_SectionDetails.New());
																													fluentAPI.BindCommand(bbiSupplier_SectionEdit,x => x.UsersSupplier_SectionDetails.Edit(null), x=>x.UsersSupplier_SectionDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSupplier_SectionDelete,x => x.UsersSupplier_SectionDetails.Delete(null), x=>x.UsersSupplier_SectionDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSupplier_SectionRefresh, x => x.UsersSupplier_SectionDetails.Refresh());
																	#endregion
						#region Supplier_Type Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Supplier_TypeGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersSupplier_TypeDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Supplier_Type,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Supplier_TypeGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersSupplier_TypeDetails.Edit(null), x => x.UsersSupplier_TypeDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Supplier_TypeGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Supplier_TypePopUpMenu.ShowPopup(Supplier_TypeGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersSupplier_TypeDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Supplier_TypeGridControl, g => g.DataSource, x => x.UsersSupplier_TypeDetails.Entities);
			
														fluentAPI.BindCommand(bbiSupplier_TypeNew, x => x.UsersSupplier_TypeDetails.New());
																													fluentAPI.BindCommand(bbiSupplier_TypeEdit,x => x.UsersSupplier_TypeDetails.Edit(null), x=>x.UsersSupplier_TypeDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSupplier_TypeDelete,x => x.UsersSupplier_TypeDetails.Delete(null), x=>x.UsersSupplier_TypeDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSupplier_TypeRefresh, x => x.UsersSupplier_TypeDetails.Refresh());
																	#endregion
						#region Suppliers Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SuppliersGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersSuppliersDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Suppliers,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SuppliersGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersSuppliersDetails.Edit(null), x => x.UsersSuppliersDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SuppliersGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SuppliersPopUpMenu.ShowPopup(SuppliersGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersSuppliersDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SuppliersGridControl, g => g.DataSource, x => x.UsersSuppliersDetails.Entities);
			
														fluentAPI.BindCommand(bbiSuppliersNew, x => x.UsersSuppliersDetails.New());
																													fluentAPI.BindCommand(bbiSuppliersEdit,x => x.UsersSuppliersDetails.Edit(null), x=>x.UsersSuppliersDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSuppliersDelete,x => x.UsersSuppliersDetails.Delete(null), x=>x.UsersSuppliersDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSuppliersRefresh, x => x.UsersSuppliersDetails.Refresh());
																	#endregion
						#region Title Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(TitleGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersTitleDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Title,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(TitleGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersTitleDetails.Edit(null), x => x.UsersTitleDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			TitleGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    TitlePopUpMenu.ShowPopup(TitleGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersTitleDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(TitleGridControl, g => g.DataSource, x => x.UsersTitleDetails.Entities);
			
														fluentAPI.BindCommand(bbiTitleNew, x => x.UsersTitleDetails.New());
																													fluentAPI.BindCommand(bbiTitleEdit,x => x.UsersTitleDetails.Edit(null), x=>x.UsersTitleDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiTitleDelete,x => x.UsersTitleDetails.Delete(null), x=>x.UsersTitleDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiTitleRefresh, x => x.UsersTitleDetails.Refresh());
																	#endregion
						#region User_Access Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(User_AccessGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersUser_AccessDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.User_Access,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(User_AccessGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersUser_AccessDetails.Edit(null), x => x.UsersUser_AccessDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			User_AccessGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    User_AccessPopUpMenu.ShowPopup(User_AccessGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersUser_AccessDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(User_AccessGridControl, g => g.DataSource, x => x.UsersUser_AccessDetails.Entities);
			
														fluentAPI.BindCommand(bbiUser_AccessNew, x => x.UsersUser_AccessDetails.New());
																													fluentAPI.BindCommand(bbiUser_AccessEdit,x => x.UsersUser_AccessDetails.Edit(null), x=>x.UsersUser_AccessDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiUser_AccessDelete,x => x.UsersUser_AccessDetails.Delete(null), x=>x.UsersUser_AccessDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiUser_AccessRefresh, x => x.UsersUser_AccessDetails.Refresh());
																	#endregion
						#region User_Access1 Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(User_Access1GridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersUser_Access1Details.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.User_Access,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(User_Access1GridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersUser_Access1Details.Edit(null), x => x.UsersUser_Access1Details.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			User_Access1GridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    User_Access1PopUpMenu.ShowPopup(User_Access1GridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersUser_Access1Details collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(User_Access1GridControl, g => g.DataSource, x => x.UsersUser_Access1Details.Entities);
			
														fluentAPI.BindCommand(bbiUser_Access1New, x => x.UsersUser_Access1Details.New());
																													fluentAPI.BindCommand(bbiUser_Access1Edit,x => x.UsersUser_Access1Details.Edit(null), x=>x.UsersUser_Access1Details.SelectedEntity);
																								fluentAPI.BindCommand(bbiUser_Access1Delete,x => x.UsersUser_Access1Details.Delete(null), x=>x.UsersUser_Access1Details.SelectedEntity);
																			fluentAPI.BindCommand(bbiUser_Access1Refresh, x => x.UsersUser_Access1Details.Refresh());
																	#endregion
						#region User_Authorization Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(User_AuthorizationGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersUser_AuthorizationDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.User_Authorization,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(User_AuthorizationGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersUser_AuthorizationDetails.Edit(null), x => x.UsersUser_AuthorizationDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			User_AuthorizationGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    User_AuthorizationPopUpMenu.ShowPopup(User_AuthorizationGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersUser_AuthorizationDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(User_AuthorizationGridControl, g => g.DataSource, x => x.UsersUser_AuthorizationDetails.Entities);
			
														fluentAPI.BindCommand(bbiUser_AuthorizationNew, x => x.UsersUser_AuthorizationDetails.New());
																													fluentAPI.BindCommand(bbiUser_AuthorizationEdit,x => x.UsersUser_AuthorizationDetails.Edit(null), x=>x.UsersUser_AuthorizationDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiUser_AuthorizationDelete,x => x.UsersUser_AuthorizationDetails.Delete(null), x=>x.UsersUser_AuthorizationDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiUser_AuthorizationRefresh, x => x.UsersUser_AuthorizationDetails.Refresh());
																	#endregion
						#region User_Authorization1 Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(User_Authorization1GridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersUser_Authorization1Details.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.User_Authorization,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(User_Authorization1GridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersUser_Authorization1Details.Edit(null), x => x.UsersUser_Authorization1Details.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			User_Authorization1GridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    User_Authorization1PopUpMenu.ShowPopup(User_Authorization1GridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersUser_Authorization1Details collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(User_Authorization1GridControl, g => g.DataSource, x => x.UsersUser_Authorization1Details.Entities);
			
														fluentAPI.BindCommand(bbiUser_Authorization1New, x => x.UsersUser_Authorization1Details.New());
																													fluentAPI.BindCommand(bbiUser_Authorization1Edit,x => x.UsersUser_Authorization1Details.Edit(null), x=>x.UsersUser_Authorization1Details.SelectedEntity);
																								fluentAPI.BindCommand(bbiUser_Authorization1Delete,x => x.UsersUser_Authorization1Details.Delete(null), x=>x.UsersUser_Authorization1Details.SelectedEntity);
																			fluentAPI.BindCommand(bbiUser_Authorization1Refresh, x => x.UsersUser_Authorization1Details.Refresh());
																	#endregion
						#region User_Department Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(User_DepartmentGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersUser_DepartmentDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.User_Department,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(User_DepartmentGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersUser_DepartmentDetails.Edit(null), x => x.UsersUser_DepartmentDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			User_DepartmentGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    User_DepartmentPopUpMenu.ShowPopup(User_DepartmentGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersUser_DepartmentDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(User_DepartmentGridControl, g => g.DataSource, x => x.UsersUser_DepartmentDetails.Entities);
			
														fluentAPI.BindCommand(bbiUser_DepartmentNew, x => x.UsersUser_DepartmentDetails.New());
																													fluentAPI.BindCommand(bbiUser_DepartmentEdit,x => x.UsersUser_DepartmentDetails.Edit(null), x=>x.UsersUser_DepartmentDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiUser_DepartmentDelete,x => x.UsersUser_DepartmentDetails.Delete(null), x=>x.UsersUser_DepartmentDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiUser_DepartmentRefresh, x => x.UsersUser_DepartmentDetails.Refresh());
																	#endregion
						#region User_Level Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(User_LevelGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersUser_LevelDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.User_Level,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(User_LevelGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersUser_LevelDetails.Edit(null), x => x.UsersUser_LevelDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			User_LevelGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    User_LevelPopUpMenu.ShowPopup(User_LevelGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersUser_LevelDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(User_LevelGridControl, g => g.DataSource, x => x.UsersUser_LevelDetails.Entities);
			
														fluentAPI.BindCommand(bbiUser_LevelNew, x => x.UsersUser_LevelDetails.New());
																													fluentAPI.BindCommand(bbiUser_LevelEdit,x => x.UsersUser_LevelDetails.Edit(null), x=>x.UsersUser_LevelDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiUser_LevelDelete,x => x.UsersUser_LevelDetails.Delete(null), x=>x.UsersUser_LevelDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiUser_LevelRefresh, x => x.UsersUser_LevelDetails.Refresh());
																	#endregion
						#region User_Logs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(User_LogsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersUser_LogsDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.User_Logs,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(User_LogsGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersUser_LogsDetails.Edit(null), x => x.UsersUser_LogsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			User_LogsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    User_LogsPopUpMenu.ShowPopup(User_LogsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersUser_LogsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(User_LogsGridControl, g => g.DataSource, x => x.UsersUser_LogsDetails.Entities);
			
														fluentAPI.BindCommand(bbiUser_LogsNew, x => x.UsersUser_LogsDetails.New());
																													fluentAPI.BindCommand(bbiUser_LogsEdit,x => x.UsersUser_LogsDetails.Edit(null), x=>x.UsersUser_LogsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiUser_LogsDelete,x => x.UsersUser_LogsDetails.Delete(null), x=>x.UsersUser_LogsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiUser_LogsRefresh, x => x.UsersUser_LogsDetails.Refresh());
																	#endregion
						#region User_Online Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(User_OnlineGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersUser_OnlineDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.User_Online,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(User_OnlineGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersUser_OnlineDetails.Edit(null), x => x.UsersUser_OnlineDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			User_OnlineGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    User_OnlinePopUpMenu.ShowPopup(User_OnlineGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersUser_OnlineDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(User_OnlineGridControl, g => g.DataSource, x => x.UsersUser_OnlineDetails.Entities);
			
														fluentAPI.BindCommand(bbiUser_OnlineNew, x => x.UsersUser_OnlineDetails.New());
																													fluentAPI.BindCommand(bbiUser_OnlineEdit,x => x.UsersUser_OnlineDetails.Edit(null), x=>x.UsersUser_OnlineDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiUser_OnlineDelete,x => x.UsersUser_OnlineDetails.Delete(null), x=>x.UsersUser_OnlineDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiUser_OnlineRefresh, x => x.UsersUser_OnlineDetails.Refresh());
																	#endregion
						#region Users1 Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Users1GridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersUsers1Details.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Users,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Users1GridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersUsers1Details.Edit(null), x => x.UsersUsers1Details.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Users1GridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Users1PopUpMenu.ShowPopup(Users1GridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersUsers1Details collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Users1GridControl, g => g.DataSource, x => x.UsersUsers1Details.Entities);
			
														fluentAPI.BindCommand(bbiUsers1New, x => x.UsersUsers1Details.New());
																													fluentAPI.BindCommand(bbiUsers1Edit,x => x.UsersUsers1Details.Edit(null), x=>x.UsersUsers1Details.SelectedEntity);
																								fluentAPI.BindCommand(bbiUsers1Delete,x => x.UsersUsers1Details.Delete(null), x=>x.UsersUsers1Details.SelectedEntity);
																			fluentAPI.BindCommand(bbiUsers1Refresh, x => x.UsersUsers1Details.Refresh());
																	#endregion
						#region Zone Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ZoneGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersZoneDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Zone,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ZoneGridView, "RowClick")
						 .EventToCommand(
						     x => x.UsersZoneDetails.Edit(null), x => x.UsersZoneDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ZoneGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ZonePopUpMenu.ShowPopup(ZoneGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the UsersZoneDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ZoneGridControl, g => g.DataSource, x => x.UsersZoneDetails.Entities);
			
														fluentAPI.BindCommand(bbiZoneNew, x => x.UsersZoneDetails.New());
																													fluentAPI.BindCommand(bbiZoneEdit,x => x.UsersZoneDetails.Edit(null), x=>x.UsersZoneDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiZoneDelete,x => x.UsersZoneDetails.Delete(null), x=>x.UsersZoneDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiZoneRefresh, x => x.UsersZoneDetails.Refresh());
																	#endregion
									// Binding for Title1 LookUp editor
			fluentAPI.SetBinding(Title1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpTitle.Entities);
						// Binding for User_Authorization2 LookUp editor
			fluentAPI.SetBinding(User_Authorization2LookUpEdit.Properties, p => p.DataSource, x => x.LookUpUser_Authorization.Entities);
						// Binding for User_Department1 LookUp editor
			fluentAPI.SetBinding(User_Department1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpUser_Department.Entities);
						// Binding for User_Level1 LookUp editor
			fluentAPI.SetBinding(User_Level1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpUser_Level.Entities);
						// Binding for User_Online1 LookUp editor
			fluentAPI.SetBinding(User_Online1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpUser_Online.Entities);
						// Binding for Users2 LookUp editor
			fluentAPI.SetBinding(Users2LookUpEdit.Properties, p => p.DataSource, x => x.LookUpUsers.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
