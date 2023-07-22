using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.Customer_SectionView{
    public partial class Customer_SectionView : XtraUserControl {
        public Customer_SectionView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.Customer_SectionViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                customer_SectionViewBindingSource, x => x.Entity, x => x.Update());
						#region Projects Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ProjectsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.Customer_SectionProjectsDetails.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Projects,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ProjectsGridView, "RowClick")
						 .EventToCommand(
						     x => x.Customer_SectionProjectsDetails.Edit(null), x => x.Customer_SectionProjectsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ProjectsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ProjectsPopUpMenu.ShowPopup(ProjectsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the Customer_SectionProjectsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ProjectsGridControl, g => g.DataSource, x => x.Customer_SectionProjectsDetails.Entities);
			
														fluentAPI.BindCommand(bbiProjectsNew, x => x.Customer_SectionProjectsDetails.New());
																													fluentAPI.BindCommand(bbiProjectsEdit,x => x.Customer_SectionProjectsDetails.Edit(null), x=>x.Customer_SectionProjectsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiProjectsDelete,x => x.Customer_SectionProjectsDetails.Delete(null), x=>x.Customer_SectionProjectsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiProjectsRefresh, x => x.Customer_SectionProjectsDetails.Refresh());
																	#endregion
									// Binding for Customers LookUp editor
			fluentAPI.SetBinding(CustomersLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCustomers.Entities);
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
