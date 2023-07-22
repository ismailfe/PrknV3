using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.ProjectsView{
    public partial class ProjectsView : XtraUserControl {
        public ProjectsView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.ProjectsViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                projectsViewBindingSource, x => x.Entity, x => x.Update());
						#region Project_Rev Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Project_RevGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ProjectsProject_RevDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Project_Rev,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Project_RevGridView, "RowClick")
						 .EventToCommand(
						     x => x.ProjectsProject_RevDetails.Edit(null), x => x.ProjectsProject_RevDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Project_RevGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Project_RevPopUpMenu.ShowPopup(Project_RevGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ProjectsProject_RevDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Project_RevGridControl, g => g.DataSource, x => x.ProjectsProject_RevDetails.Entities);
			
														fluentAPI.BindCommand(bbiProject_RevNew, x => x.ProjectsProject_RevDetails.New());
																													fluentAPI.BindCommand(bbiProject_RevEdit,x => x.ProjectsProject_RevDetails.Edit(null), x=>x.ProjectsProject_RevDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiProject_RevDelete,x => x.ProjectsProject_RevDetails.Delete(null), x=>x.ProjectsProject_RevDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiProject_RevRefresh, x => x.ProjectsProject_RevDetails.Refresh());
																	#endregion
									// Binding for Customer_Contact LookUp editor
			fluentAPI.SetBinding(Customer_ContactLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCustomer_Contact.Entities);
						// Binding for Customer_Section LookUp editor
			fluentAPI.SetBinding(Customer_SectionLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCustomer_Section.Entities);
						// Binding for Customers LookUp editor
			fluentAPI.SetBinding(CustomersLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCustomers.Entities);
						// Binding for Project_Detail LookUp editor
			fluentAPI.SetBinding(Project_DetailLookUpEdit.Properties, p => p.DataSource, x => x.LookUpProject_Detail.Entities);
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
