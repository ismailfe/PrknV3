namespace Emikon.Parkon.UI.Win.test.Views.Store_ProductTypeView {
    partial class Store_ProductTypeView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.labelControl = new DevExpress.XtraEditors.LabelControl();
						this.Store_ProductGridControl = new DevExpress.XtraGrid.GridControl();
			this.Store_ProductGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Store_ProductBarManager = new DevExpress.XtraBars.BarManager();
			this.Store_ProductBar = new DevExpress.XtraBars.Bar();
			this.Store_ProductXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.Store_ProductPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiStore_ProductNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiStore_ProductEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiStore_ProductDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiStore_ProductRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.Store_ProductBarManager)).BeginInit();
									this.UsersLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
			this.SuspendLayout();
			// 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", null, "Backward;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1";
			// 
            // windowsUIButtonPanelMain
            // 
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
			this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
			this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", null, "Save;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", null, "SaveAndClose;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", null, "SaveAndNew;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset Changes", null, "Reset;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", null, "Edit/Delete;Size32x32;GrayScaled"));
						// 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.TextVisible = false;
			// 
            // dataLayoutControl1item.CommandPropertyName
            // 
            this.dataLayoutControl1.AllowCustomization = false;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.store_ProductTypeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.store_ProductTypeViewBindingSource.DataSource = typeof(Emikon.Parkon.Model.Store_ProductType);
			this.dataLayoutControl1.DataSource = store_ProductTypeViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//Store_ProductGridControl
			//
			this.Store_ProductGridControl.MainView = this.Store_ProductGridView;
			this.Store_ProductGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Store_ProductGridControl.Name = "Store_ProductGridControl";
            this.Store_ProductGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Store_ProductGridView});
			//
			//Store_ProductGridView
			//
            this.Store_ProductGridView.GridControl = this.Store_ProductGridControl;
            this.Store_ProductGridView.Name = "Store_ProductGridView";
            this.Store_ProductGridView.OptionsBehavior.Editable = false;
            this.Store_ProductGridView.OptionsBehavior.ReadOnly = true;
			this.Store_ProductGridView.OptionsView.ShowGroupPanel = false;
			//
			//Store_ProductPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters Store_ProductPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressStore_ProductChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressStore_ProductChildPopulateColumnParameters_NotVisible.FieldName = "Store_Address";
		    Store_AddressStore_ProductChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Store_ProductPopulateColumnsParameters.CustomColumnParameters.Add(Store_AddressStore_ProductChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_LocationStore_ProductChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_LocationStore_ProductChildPopulateColumnParameters_NotVisible.FieldName = "Store_Location";
		    Store_LocationStore_ProductChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Store_ProductPopulateColumnsParameters.CustomColumnParameters.Add(Store_LocationStore_ProductChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductGroupStore_ProductChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductGroupStore_ProductChildPopulateColumnParameters_NotVisible.FieldName = "Store_ProductGroup";
		    Store_ProductGroupStore_ProductChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Store_ProductPopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductGroupStore_ProductChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductTypeStore_ProductChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductTypeStore_ProductChildPopulateColumnParameters_NotVisible.FieldName = "Store_ProductType";
		    Store_ProductTypeStore_ProductChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Store_ProductPopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductTypeStore_ProductChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductUnitStore_ProductChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductUnitStore_ProductChildPopulateColumnParameters_NotVisible.FieldName = "Store_ProductUnit";
		    Store_ProductUnitStore_ProductChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Store_ProductPopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductUnitStore_ProductChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersStore_ProductChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersStore_ProductChildPopulateColumnParameters_NotVisible.FieldName = "Users";
		    UsersStore_ProductChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Store_ProductPopulateColumnsParameters.CustomColumnParameters.Add(UsersStore_ProductChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_WarehouseStore_ProductChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_WarehouseStore_ProductChildPopulateColumnParameters_NotVisible.FieldName = "Store_Warehouse";
		    Store_WarehouseStore_ProductChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Store_ProductPopulateColumnsParameters.CustomColumnParameters.Add(Store_WarehouseStore_ProductChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_WarehouseOutStore_ProductChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_WarehouseOutStore_ProductChildPopulateColumnParameters_NotVisible.FieldName = "Store_WarehouseOut";
		    Store_WarehouseOutStore_ProductChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Store_ProductPopulateColumnsParameters.CustomColumnParameters.Add(Store_WarehouseOutStore_ProductChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductStore_ProductChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductStore_ProductChildPopulateColumnParameters.FieldName = "Store_ProductStore_Product";
            Store_ProductStore_ProductChildPopulateColumnParameters.Path = "Store_Product.Name";
			Store_ProductPopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductStore_ProductChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersStore_ProductChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersStore_ProductChildPopulateColumnParameters.FieldName = "UsersStore_Product";
            UsersStore_ProductChildPopulateColumnParameters.Path = "Users.NameFirst";
			Store_ProductPopulateColumnsParameters.CustomColumnParameters.Add(UsersStore_ProductChildPopulateColumnParameters);
			 
		    this.Store_ProductGridView.PopulateColumns(typeof(Emikon.Parkon.Model.Store_Product),Store_ProductPopulateColumnsParameters);
			//
			//Store_ProductBindingSource
			//
			System.Windows.Forms.BindingSource Store_ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
			Store_ProductBindingSource.DataSource = typeof(Emikon.Parkon.Model.Store_Product);
            this.Store_ProductGridControl.DataSource = Store_ProductBindingSource;
			//
			//Store_ProductXtraUserControl
			//
            this.Store_ProductXtraUserControl.Controls.Add(Store_ProductGridControl);
			this.Store_ProductXtraUserControl.Name = "Store_ProductXtraUserControl";
			this.Store_ProductXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//Store_ProductNew
			//
			this.bbiStore_ProductNew.Caption = "New";
			this.bbiStore_ProductNew.Name = "bbiStore_ProductNew";
			this.bbiStore_ProductNew.ImageUri.Uri = "New";
			this.bbiStore_ProductNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Store_ProductBarManager.Items.Add(this.bbiStore_ProductNew);
			this.Store_ProductBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStore_ProductNew));
			this.Store_ProductPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStore_ProductNew));
						//
			//Store_ProductEdit
			//
			this.bbiStore_ProductEdit.Caption = "Edit";
			this.bbiStore_ProductEdit.Name = "bbiStore_ProductEdit";
			this.bbiStore_ProductEdit.ImageUri.Uri = "Edit";
			this.bbiStore_ProductEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Store_ProductBarManager.Items.Add(this.bbiStore_ProductEdit);
			this.Store_ProductBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStore_ProductEdit));
			this.Store_ProductPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStore_ProductEdit));
						//
			//Store_ProductDelete
			//
			this.bbiStore_ProductDelete.Caption = "Delete";
			this.bbiStore_ProductDelete.Name = "bbiStore_ProductDelete";
			this.bbiStore_ProductDelete.ImageUri.Uri = "Delete";
			this.bbiStore_ProductDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Store_ProductBarManager.Items.Add(this.bbiStore_ProductDelete);
			this.Store_ProductBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStore_ProductDelete));
			this.Store_ProductPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStore_ProductDelete));
						//
			//Store_ProductRefresh
			//
			this.bbiStore_ProductRefresh.Caption = "Refresh";
			this.bbiStore_ProductRefresh.Name = "bbiStore_ProductRefresh";
			this.bbiStore_ProductRefresh.ImageUri.Uri = "Refresh";
			this.bbiStore_ProductRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Store_ProductBarManager.Items.Add(this.bbiStore_ProductRefresh);
			this.Store_ProductBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStore_ProductRefresh));
			this.Store_ProductPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStore_ProductRefresh));
						//
			//Store_ProductBar
			//
			this.Store_ProductBar.BarName = "Store_Product";
            this.Store_ProductBar.DockCol = 0;
            this.Store_ProductBar.DockRow = 0;
            this.Store_ProductBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Store_ProductBar.OptionsBar.AllowQuickCustomization = false;
            this.Store_ProductBar.OptionsBar.DrawDragBorder = false;
            this.Store_ProductBar.Text = "Store_Product";
			//
			//Store_ProductBarManager
			//
			this.Store_ProductBarManager.AllowCustomization = false;
            this.Store_ProductBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Store_ProductBar});
            this.Store_ProductBarManager.Form = Store_ProductXtraUserControl;
            this.Store_ProductBarManager.MainMenu = this.Store_ProductBar;
			// 
            // Store_ProductPopUpMenu
            // 
            this.Store_ProductPopUpMenu.Manager = this.Store_ProductBarManager;
            this.Store_ProductPopUpMenu.Name = "Store_ProductPopUpMenu";
			//
			//Store_ProductRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters Store_ProductRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Store_ProductRetriveFieldParameters.FieldName = "Store_Product";
            Store_ProductRetriveFieldParameters.ControlForField = Store_ProductXtraUserControl;
			Store_ProductRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(Store_ProductRetriveFieldParameters);
									//
			//UsersLookUpEdit
			//
			this.UsersBindingSource.DataSource = typeof(Emikon.Parkon.Model.Users);
			this.UsersLookUpEdit.Properties.ValueMember = "Id"; 
			this.UsersLookUpEdit.Properties.DisplayMember = "NameFirst";
			this.UsersLookUpEdit.Properties.DataSource = this.UsersBindingSource;
			this.UsersLookUpEdit.Name = "UsersLookUpEdit";
			this.UsersLookUpEdit.DataBindings.Add("EditValue", store_ProductTypeViewBindingSource, "UserId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters UsersLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            UsersLookUpEditRetrieveFieldParameters.FieldName = "UserId";
            UsersLookUpEditRetrieveFieldParameters.ControlForField = this.UsersLookUpEdit;
			parameters.CustomListParameters.Add(UsersLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters UsersLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    UsersLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Users";
		    UsersLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(UsersLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Emikon.Parkon.UI.Win.test.ViewModels.Store_ProductTypeViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Store_ProductType - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//Store_ProductTypeView
			//
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "Store_ProductTypeView";
						((System.ComponentModel.ISupportInitialize)(this.Store_ProductBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource store_ProductTypeViewBindingSource;
				private DevExpress.XtraGrid.GridControl Store_ProductGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView Store_ProductGridView;
		private DevExpress.XtraBars.BarManager Store_ProductBarManager;
		private DevExpress.XtraBars.Bar Store_ProductBar;
		private DevExpress.XtraEditors.XtraUserControl Store_ProductXtraUserControl;
		private DevExpress.XtraBars.PopupMenu Store_ProductPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiStore_ProductNew;
				private DevExpress.XtraBars.BarButtonItem bbiStore_ProductEdit;
				private DevExpress.XtraBars.BarButtonItem bbiStore_ProductDelete;
				private DevExpress.XtraBars.BarButtonItem bbiStore_ProductRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit UsersLookUpEdit;
		private System.Windows.Forms.BindingSource UsersBindingSource;
		 
	}
}
