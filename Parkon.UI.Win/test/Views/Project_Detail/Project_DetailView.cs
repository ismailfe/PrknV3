using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.Project_DetailView{
    public partial class Project_DetailView : XtraUserControl {
        public Project_DetailView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.Project_DetailViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                project_DetailViewBindingSource, x => x.Entity, x => x.Update());
						#region Projects Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ProjectsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Project_DetailProjectsDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Projects,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ProjectsGridView, "RowClick")
						 .EventToCommand(
						     x => x.Project_DetailProjectsDetails.Edit(null), x => x.Project_DetailProjectsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ProjectsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ProjectsPopUpMenu.ShowPopup(ProjectsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Project_DetailProjectsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ProjectsGridControl, g => g.DataSource, x => x.Project_DetailProjectsDetails.Entities);
			
														fluentAPI.BindCommand(bbiProjectsNew, x => x.Project_DetailProjectsDetails.New());
																													fluentAPI.BindCommand(bbiProjectsEdit,x => x.Project_DetailProjectsDetails.Edit(null), x=>x.Project_DetailProjectsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiProjectsDelete,x => x.Project_DetailProjectsDetails.Delete(null), x=>x.Project_DetailProjectsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiProjectsRefresh, x => x.Project_DetailProjectsDetails.Refresh());
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
