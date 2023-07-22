using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Emikon.Parkon.UI.Win.test.Views.User_OnlineView{
    public partial class User_OnlineView : XtraUserControl {
        public User_OnlineView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Emikon.Parkon.UI.Win.test.ViewModels.User_OnlineViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                user_OnlineViewBindingSource, x => x.Entity, x => x.Update());
						#region Users1 Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(Users1GridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.User_OnlineUsers1Details.SelectedEntity,
                    args => args.Row as Emikon.Parkon.Model.Users,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(Users1GridView, "RowClick")
						 .EventToCommand(
						     x => x.User_OnlineUsers1Details.Edit(null), x => x.User_OnlineUsers1Details.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			Users1GridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    Users1PopUpMenu.ShowPopup(Users1GridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the User_OnlineUsers1Details collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(Users1GridControl, g => g.DataSource, x => x.User_OnlineUsers1Details.Entities);
			
														fluentAPI.BindCommand(bbiUsers1New, x => x.User_OnlineUsers1Details.New());
																													fluentAPI.BindCommand(bbiUsers1Edit,x => x.User_OnlineUsers1Details.Edit(null), x=>x.User_OnlineUsers1Details.SelectedEntity);
																								fluentAPI.BindCommand(bbiUsers1Delete,x => x.User_OnlineUsers1Details.Delete(null), x=>x.User_OnlineUsers1Details.SelectedEntity);
																			fluentAPI.BindCommand(bbiUsers1Refresh, x => x.User_OnlineUsers1Details.Refresh());
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
