namespace Emikon.Parkon.UI.Win.test.Views.Customer_SectionView {
    partial class Customer_SectionView {
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
						this.ProjectsGridControl = new DevExpress.XtraGrid.GridControl();
			this.ProjectsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ProjectsBarManager = new DevExpress.XtraBars.BarManager();
			this.ProjectsBar = new DevExpress.XtraBars.Bar();
			this.ProjectsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.ProjectsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiProjectsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiProjectsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiProjectsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiProjectsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.ProjectsBarManager)).BeginInit();
									this.CustomersLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.ZoneLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.ZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
			this.customer_SectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customer_SectionViewBindingSource.DataSource = typeof(Emikon.Parkon.Model.Customer_Section);
			this.dataLayoutControl1.DataSource = customer_SectionViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//ProjectsGridControl
			//
			this.ProjectsGridControl.MainView = this.ProjectsGridView;
			this.ProjectsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsGridControl.Name = "ProjectsGridControl";
            this.ProjectsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ProjectsGridView});
			//
			//ProjectsGridView
			//
            this.ProjectsGridView.GridControl = this.ProjectsGridControl;
            this.ProjectsGridView.Name = "ProjectsGridView";
            this.ProjectsGridView.OptionsBehavior.Editable = false;
            this.ProjectsGridView.OptionsBehavior.ReadOnly = true;
			this.ProjectsGridView.OptionsView.ShowGroupPanel = false;
			//
			//ProjectsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters ProjectsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_ContactProjectsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_ContactProjectsChildPopulateColumnParameters_NotVisible.FieldName = "Customer_Contact";
		    Customer_ContactProjectsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ProjectsPopulateColumnsParameters.CustomColumnParameters.Add(Customer_ContactProjectsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_SectionProjectsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_SectionProjectsChildPopulateColumnParameters_NotVisible.FieldName = "Customer_Section";
		    Customer_SectionProjectsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ProjectsPopulateColumnsParameters.CustomColumnParameters.Add(Customer_SectionProjectsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersProjectsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersProjectsChildPopulateColumnParameters_NotVisible.FieldName = "Customers";
		    CustomersProjectsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ProjectsPopulateColumnsParameters.CustomColumnParameters.Add(CustomersProjectsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_DetailProjectsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_DetailProjectsChildPopulateColumnParameters_NotVisible.FieldName = "Project_Detail";
		    Project_DetailProjectsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ProjectsPopulateColumnsParameters.CustomColumnParameters.Add(Project_DetailProjectsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_RevProjectsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_RevProjectsChildPopulateColumnParameters_NotVisible.FieldName = "Project_Rev";
		    Project_RevProjectsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ProjectsPopulateColumnsParameters.CustomColumnParameters.Add(Project_RevProjectsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersProjectsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersProjectsChildPopulateColumnParameters_NotVisible.FieldName = "Users";
		    UsersProjectsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ProjectsPopulateColumnsParameters.CustomColumnParameters.Add(UsersProjectsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersProjectsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersProjectsChildPopulateColumnParameters.FieldName = "CustomersProjects";
            CustomersProjectsChildPopulateColumnParameters.Path = "Customers.Name";
			ProjectsPopulateColumnsParameters.CustomColumnParameters.Add(CustomersProjectsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ZoneProjectsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ZoneProjectsChildPopulateColumnParameters.FieldName = "ZoneProjects";
            ZoneProjectsChildPopulateColumnParameters.Path = "Zone.Name";
			ProjectsPopulateColumnsParameters.CustomColumnParameters.Add(ZoneProjectsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ProjectsProjectsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ProjectsProjectsChildPopulateColumnParameters.FieldName = "ProjectsProjects";
            ProjectsProjectsChildPopulateColumnParameters.Path = "Projects.Name";
			ProjectsPopulateColumnsParameters.CustomColumnParameters.Add(ProjectsProjectsChildPopulateColumnParameters);
			 
		    this.ProjectsGridView.PopulateColumns(typeof(Emikon.Parkon.Model.Projects),ProjectsPopulateColumnsParameters);
			//
			//ProjectsBindingSource
			//
			System.Windows.Forms.BindingSource ProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			ProjectsBindingSource.DataSource = typeof(Emikon.Parkon.Model.Projects);
            this.ProjectsGridControl.DataSource = ProjectsBindingSource;
			//
			//ProjectsXtraUserControl
			//
            this.ProjectsXtraUserControl.Controls.Add(ProjectsGridControl);
			this.ProjectsXtraUserControl.Name = "ProjectsXtraUserControl";
			this.ProjectsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//ProjectsNew
			//
			this.bbiProjectsNew.Caption = "New";
			this.bbiProjectsNew.Name = "bbiProjectsNew";
			this.bbiProjectsNew.ImageUri.Uri = "New";
			this.bbiProjectsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ProjectsBarManager.Items.Add(this.bbiProjectsNew);
			this.ProjectsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProjectsNew));
			this.ProjectsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProjectsNew));
						//
			//ProjectsEdit
			//
			this.bbiProjectsEdit.Caption = "Edit";
			this.bbiProjectsEdit.Name = "bbiProjectsEdit";
			this.bbiProjectsEdit.ImageUri.Uri = "Edit";
			this.bbiProjectsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ProjectsBarManager.Items.Add(this.bbiProjectsEdit);
			this.ProjectsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProjectsEdit));
			this.ProjectsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProjectsEdit));
						//
			//ProjectsDelete
			//
			this.bbiProjectsDelete.Caption = "Delete";
			this.bbiProjectsDelete.Name = "bbiProjectsDelete";
			this.bbiProjectsDelete.ImageUri.Uri = "Delete";
			this.bbiProjectsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ProjectsBarManager.Items.Add(this.bbiProjectsDelete);
			this.ProjectsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProjectsDelete));
			this.ProjectsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProjectsDelete));
						//
			//ProjectsRefresh
			//
			this.bbiProjectsRefresh.Caption = "Refresh";
			this.bbiProjectsRefresh.Name = "bbiProjectsRefresh";
			this.bbiProjectsRefresh.ImageUri.Uri = "Refresh";
			this.bbiProjectsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ProjectsBarManager.Items.Add(this.bbiProjectsRefresh);
			this.ProjectsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProjectsRefresh));
			this.ProjectsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProjectsRefresh));
						//
			//ProjectsBar
			//
			this.ProjectsBar.BarName = "Projects";
            this.ProjectsBar.DockCol = 0;
            this.ProjectsBar.DockRow = 0;
            this.ProjectsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ProjectsBar.OptionsBar.AllowQuickCustomization = false;
            this.ProjectsBar.OptionsBar.DrawDragBorder = false;
            this.ProjectsBar.Text = "Projects";
			//
			//ProjectsBarManager
			//
			this.ProjectsBarManager.AllowCustomization = false;
            this.ProjectsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.ProjectsBar});
            this.ProjectsBarManager.Form = ProjectsXtraUserControl;
            this.ProjectsBarManager.MainMenu = this.ProjectsBar;
			// 
            // ProjectsPopUpMenu
            // 
            this.ProjectsPopUpMenu.Manager = this.ProjectsBarManager;
            this.ProjectsPopUpMenu.Name = "ProjectsPopUpMenu";
			//
			//ProjectsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters ProjectsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            ProjectsRetriveFieldParameters.FieldName = "Projects";
            ProjectsRetriveFieldParameters.ControlForField = ProjectsXtraUserControl;
			ProjectsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(ProjectsRetriveFieldParameters);
									//
			//CustomersLookUpEdit
			//
			this.CustomersBindingSource.DataSource = typeof(Emikon.Parkon.Model.Customers);
			this.CustomersLookUpEdit.Properties.ValueMember = "Id"; 
			this.CustomersLookUpEdit.Properties.DisplayMember = "Name";
			this.CustomersLookUpEdit.Properties.DataSource = this.CustomersBindingSource;
			this.CustomersLookUpEdit.Name = "CustomersLookUpEdit";
			this.CustomersLookUpEdit.DataBindings.Add("EditValue", customer_SectionViewBindingSource, "CustomerId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters CustomersLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            CustomersLookUpEditRetrieveFieldParameters.FieldName = "CustomerId";
            CustomersLookUpEditRetrieveFieldParameters.ControlForField = this.CustomersLookUpEdit;
			parameters.CustomListParameters.Add(CustomersLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters CustomersLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    CustomersLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Customers";
		    CustomersLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(CustomersLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//ZoneLookUpEdit
			//
			this.ZoneBindingSource.DataSource = typeof(Emikon.Parkon.Model.Zone);
			this.ZoneLookUpEdit.Properties.ValueMember = "Id"; 
			this.ZoneLookUpEdit.Properties.DisplayMember = "Name";
			this.ZoneLookUpEdit.Properties.DataSource = this.ZoneBindingSource;
			this.ZoneLookUpEdit.Name = "ZoneLookUpEdit";
			this.ZoneLookUpEdit.DataBindings.Add("EditValue", customer_SectionViewBindingSource, "ZoneId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters ZoneLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            ZoneLookUpEditRetrieveFieldParameters.FieldName = "ZoneId";
            ZoneLookUpEditRetrieveFieldParameters.ControlForField = this.ZoneLookUpEdit;
			parameters.CustomListParameters.Add(ZoneLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters ZoneLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    ZoneLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Zone";
		    ZoneLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(ZoneLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Emikon.Parkon.UI.Win.test.ViewModels.Customer_SectionViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "Customer_Section - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//Customer_SectionView
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
            this.Name = "Customer_SectionView";
						((System.ComponentModel.ISupportInitialize)(this.ProjectsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource customer_SectionViewBindingSource;
				private DevExpress.XtraGrid.GridControl ProjectsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView ProjectsGridView;
		private DevExpress.XtraBars.BarManager ProjectsBarManager;
		private DevExpress.XtraBars.Bar ProjectsBar;
		private DevExpress.XtraEditors.XtraUserControl ProjectsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu ProjectsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiProjectsNew;
				private DevExpress.XtraBars.BarButtonItem bbiProjectsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiProjectsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiProjectsRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit CustomersLookUpEdit;
		private System.Windows.Forms.BindingSource CustomersBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit ZoneLookUpEdit;
		private System.Windows.Forms.BindingSource ZoneBindingSource;
		 
	}
}
