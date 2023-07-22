namespace Emikon.Parkon.UI.Win.test.Views.Supplier_TypeView {
    partial class Supplier_TypeView {
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
						this.SuppliersGridControl = new DevExpress.XtraGrid.GridControl();
			this.SuppliersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.SuppliersBarManager = new DevExpress.XtraBars.BarManager();
			this.SuppliersBar = new DevExpress.XtraBars.Bar();
			this.SuppliersXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.SuppliersPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiSuppliersNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSuppliersEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSuppliersDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSuppliersRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.SuppliersBarManager)).BeginInit();
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
			this.supplier_TypeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.supplier_TypeViewBindingSource.DataSource = typeof(Emikon.Parkon.Model.Supplier_Type);
			this.dataLayoutControl1.DataSource = supplier_TypeViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//SuppliersGridControl
			//
			this.SuppliersGridControl.MainView = this.SuppliersGridView;
			this.SuppliersGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuppliersGridControl.Name = "SuppliersGridControl";
            this.SuppliersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SuppliersGridView});
			//
			//SuppliersGridView
			//
            this.SuppliersGridView.GridControl = this.SuppliersGridControl;
            this.SuppliersGridView.Name = "SuppliersGridView";
            this.SuppliersGridView.OptionsBehavior.Editable = false;
            this.SuppliersGridView.OptionsBehavior.ReadOnly = true;
			this.SuppliersGridView.OptionsView.ShowGroupPanel = false;
			//
			//SuppliersPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters SuppliersPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_ContactSuppliersChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_ContactSuppliersChildPopulateColumnParameters_NotVisible.FieldName = "Supplier_Contact";
		    Supplier_ContactSuppliersChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SuppliersPopulateColumnsParameters.CustomColumnParameters.Add(Supplier_ContactSuppliersChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_SectionSuppliersChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_SectionSuppliersChildPopulateColumnParameters_NotVisible.FieldName = "Supplier_Section";
		    Supplier_SectionSuppliersChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SuppliersPopulateColumnsParameters.CustomColumnParameters.Add(Supplier_SectionSuppliersChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_TypeSuppliersChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_TypeSuppliersChildPopulateColumnParameters_NotVisible.FieldName = "Supplier_Type";
		    Supplier_TypeSuppliersChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SuppliersPopulateColumnsParameters.CustomColumnParameters.Add(Supplier_TypeSuppliersChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersSuppliersChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersSuppliersChildPopulateColumnParameters_NotVisible.FieldName = "Users";
		    UsersSuppliersChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SuppliersPopulateColumnsParameters.CustomColumnParameters.Add(UsersSuppliersChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ZoneSuppliersChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ZoneSuppliersChildPopulateColumnParameters_NotVisible.FieldName = "Zone";
		    ZoneSuppliersChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SuppliersPopulateColumnsParameters.CustomColumnParameters.Add(ZoneSuppliersChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersSuppliersChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersSuppliersChildPopulateColumnParameters.FieldName = "UsersSuppliers";
            UsersSuppliersChildPopulateColumnParameters.Path = "Users.NameFirst";
			SuppliersPopulateColumnsParameters.CustomColumnParameters.Add(UsersSuppliersChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SuppliersSuppliersChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SuppliersSuppliersChildPopulateColumnParameters.FieldName = "SuppliersSuppliers";
            SuppliersSuppliersChildPopulateColumnParameters.Path = "Suppliers.Name";
			SuppliersPopulateColumnsParameters.CustomColumnParameters.Add(SuppliersSuppliersChildPopulateColumnParameters);
			 
		    this.SuppliersGridView.PopulateColumns(typeof(Emikon.Parkon.Model.Suppliers),SuppliersPopulateColumnsParameters);
			//
			//SuppliersBindingSource
			//
			System.Windows.Forms.BindingSource SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			SuppliersBindingSource.DataSource = typeof(Emikon.Parkon.Model.Suppliers);
            this.SuppliersGridControl.DataSource = SuppliersBindingSource;
			//
			//SuppliersXtraUserControl
			//
            this.SuppliersXtraUserControl.Controls.Add(SuppliersGridControl);
			this.SuppliersXtraUserControl.Name = "SuppliersXtraUserControl";
			this.SuppliersXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//SuppliersNew
			//
			this.bbiSuppliersNew.Caption = "New";
			this.bbiSuppliersNew.Name = "bbiSuppliersNew";
			this.bbiSuppliersNew.ImageUri.Uri = "New";
			this.bbiSuppliersNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SuppliersBarManager.Items.Add(this.bbiSuppliersNew);
			this.SuppliersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuppliersNew));
			this.SuppliersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuppliersNew));
						//
			//SuppliersEdit
			//
			this.bbiSuppliersEdit.Caption = "Edit";
			this.bbiSuppliersEdit.Name = "bbiSuppliersEdit";
			this.bbiSuppliersEdit.ImageUri.Uri = "Edit";
			this.bbiSuppliersEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SuppliersBarManager.Items.Add(this.bbiSuppliersEdit);
			this.SuppliersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuppliersEdit));
			this.SuppliersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuppliersEdit));
						//
			//SuppliersDelete
			//
			this.bbiSuppliersDelete.Caption = "Delete";
			this.bbiSuppliersDelete.Name = "bbiSuppliersDelete";
			this.bbiSuppliersDelete.ImageUri.Uri = "Delete";
			this.bbiSuppliersDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SuppliersBarManager.Items.Add(this.bbiSuppliersDelete);
			this.SuppliersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuppliersDelete));
			this.SuppliersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuppliersDelete));
						//
			//SuppliersRefresh
			//
			this.bbiSuppliersRefresh.Caption = "Refresh";
			this.bbiSuppliersRefresh.Name = "bbiSuppliersRefresh";
			this.bbiSuppliersRefresh.ImageUri.Uri = "Refresh";
			this.bbiSuppliersRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SuppliersBarManager.Items.Add(this.bbiSuppliersRefresh);
			this.SuppliersBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuppliersRefresh));
			this.SuppliersPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSuppliersRefresh));
						//
			//SuppliersBar
			//
			this.SuppliersBar.BarName = "Suppliers";
            this.SuppliersBar.DockCol = 0;
            this.SuppliersBar.DockRow = 0;
            this.SuppliersBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.SuppliersBar.OptionsBar.AllowQuickCustomization = false;
            this.SuppliersBar.OptionsBar.DrawDragBorder = false;
            this.SuppliersBar.Text = "Suppliers";
			//
			//SuppliersBarManager
			//
			this.SuppliersBarManager.AllowCustomization = false;
            this.SuppliersBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.SuppliersBar});
            this.SuppliersBarManager.Form = SuppliersXtraUserControl;
            this.SuppliersBarManager.MainMenu = this.SuppliersBar;
			// 
            // SuppliersPopUpMenu
            // 
            this.SuppliersPopUpMenu.Manager = this.SuppliersBarManager;
            this.SuppliersPopUpMenu.Name = "SuppliersPopUpMenu";
			//
			//SuppliersRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters SuppliersRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            SuppliersRetriveFieldParameters.FieldName = "Suppliers";
            SuppliersRetriveFieldParameters.ControlForField = SuppliersXtraUserControl;
			SuppliersRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(SuppliersRetriveFieldParameters);
									//
			//UsersLookUpEdit
			//
			this.UsersBindingSource.DataSource = typeof(Emikon.Parkon.Model.Users);
			this.UsersLookUpEdit.Properties.ValueMember = "Id"; 
			this.UsersLookUpEdit.Properties.DisplayMember = "NameFirst";
			this.UsersLookUpEdit.Properties.DataSource = this.UsersBindingSource;
			this.UsersLookUpEdit.Name = "UsersLookUpEdit";
			this.UsersLookUpEdit.DataBindings.Add("EditValue", supplier_TypeViewBindingSource, "UserId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
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
            this.mvvmContext.ViewModelType = typeof(Emikon.Parkon.UI.Win.test.ViewModels.Supplier_TypeViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Supplier_Type - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//Supplier_TypeView
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
            this.Name = "Supplier_TypeView";
						((System.ComponentModel.ISupportInitialize)(this.SuppliersBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource supplier_TypeViewBindingSource;
				private DevExpress.XtraGrid.GridControl SuppliersGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView SuppliersGridView;
		private DevExpress.XtraBars.BarManager SuppliersBarManager;
		private DevExpress.XtraBars.Bar SuppliersBar;
		private DevExpress.XtraEditors.XtraUserControl SuppliersXtraUserControl;
		private DevExpress.XtraBars.PopupMenu SuppliersPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiSuppliersNew;
				private DevExpress.XtraBars.BarButtonItem bbiSuppliersEdit;
				private DevExpress.XtraBars.BarButtonItem bbiSuppliersDelete;
				private DevExpress.XtraBars.BarButtonItem bbiSuppliersRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit UsersLookUpEdit;
		private System.Windows.Forms.BindingSource UsersBindingSource;
		 
	}
}
