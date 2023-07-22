namespace Emikon.Parkon.UI.Win.test.Views.UsersCollectionView {
    partial class UsersCollectionView {
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
			this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.labelControl = new DevExpress.XtraEditors.LabelControl();
			this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemGrid = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
			// 
            // windowsUIButtonPanel
            // 
            this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel.EnableImageTransparency = true;
            this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
			this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(60, 60);
            this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 60);
																this.windowsUIButtonPanel.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("New", null, "New;Size32x32;GrayScaled"));
						
								this.windowsUIButtonPanel.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Edit", null, "Edit;Size32x32;GrayScaled"));
						
								this.windowsUIButtonPanel.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", null, "Edit/Delete;Size32x32;GrayScaled"));
						
										this.windowsUIButtonPanel.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Refresh", null, "Refresh;Size32x32;GrayScaled"));
						
	
			this.windowsUIButtonPanel.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUISeparator());
			this.windowsUIButtonPanel.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", null, "Preview;Size32x32;GrayScaled"));
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Padding = new System.Windows.Forms.Padding(0, 3, 13, 6);
            this.labelControl.Text = "Users";
			// 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(5, 116);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(779, 311);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowGroup = false;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsMenu.EnableColumnMenu = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
			this.usersCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usersCollectionViewBindingSource.DataSource = typeof(Emikon.Parkon.Model.Users);
			this.gridControl.DataSource = usersCollectionViewBindingSource;

			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters parameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
						//
			//Title1
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Title1PopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Title1PopulateColumnParameters.FieldName = "Title1";
            Title1PopulateColumnParameters.Path = "Title1.Name";
			parameters.CustomColumnParameters.Add(Title1PopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters Title1PopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Title1PopulateColumnParameters_NotGenerate.FieldName = "TitleId";
		    Title1PopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Title1PopulateColumnParameters_NotGenerate);
									//
			//User_Authorization2
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Authorization2PopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Authorization2PopulateColumnParameters.FieldName = "User_Authorization2";
            User_Authorization2PopulateColumnParameters.Path = "User_Authorization2.SysCode";
			parameters.CustomColumnParameters.Add(User_Authorization2PopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Authorization2PopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Authorization2PopulateColumnParameters_NotGenerate.FieldName = "AutrizationId";
		    User_Authorization2PopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_Authorization2PopulateColumnParameters_NotGenerate);
									//
			//User_Department1
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Department1PopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Department1PopulateColumnParameters.FieldName = "User_Department1";
            User_Department1PopulateColumnParameters.Path = "User_Department1.Name";
			parameters.CustomColumnParameters.Add(User_Department1PopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Department1PopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Department1PopulateColumnParameters_NotGenerate.FieldName = "DepartmentId";
		    User_Department1PopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_Department1PopulateColumnParameters_NotGenerate);
									//
			//User_Level1
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Level1PopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Level1PopulateColumnParameters.FieldName = "User_Level1";
            User_Level1PopulateColumnParameters.Path = "User_Level1.SysCode";
			parameters.CustomColumnParameters.Add(User_Level1PopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Level1PopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Level1PopulateColumnParameters_NotGenerate.FieldName = "LevelsId";
		    User_Level1PopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_Level1PopulateColumnParameters_NotGenerate);
									//
			//User_Online1
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Online1PopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Online1PopulateColumnParameters.FieldName = "User_Online1";
            User_Online1PopulateColumnParameters.Path = "User_Online1.Name";
			parameters.CustomColumnParameters.Add(User_Online1PopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Online1PopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Online1PopulateColumnParameters_NotGenerate.FieldName = "OnlineId";
		    User_Online1PopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_Online1PopulateColumnParameters_NotGenerate);
									//
			//Users2
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Users2PopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Users2PopulateColumnParameters.FieldName = "Users2";
            Users2PopulateColumnParameters.Path = "Users2.NameFirst";
			parameters.CustomColumnParameters.Add(Users2PopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters Users2PopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Users2PopulateColumnParameters_NotGenerate.FieldName = "UserId";
		    Users2PopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Users2PopulateColumnParameters_NotGenerate);
										
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_ContactPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_ContactPopulateColumnParameters_NotVisible.FieldName = "Customer_Contact";
		    Customer_ContactPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Customer_ContactPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_TypePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_TypePopulateColumnParameters_NotVisible.FieldName = "Customer_Type";
		    Customer_TypePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Customer_TypePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersPopulateColumnParameters_NotVisible.FieldName = "Customers";
		    CustomersPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(CustomersPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters KeywordPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            KeywordPopulateColumnParameters_NotVisible.FieldName = "Keyword";
		    KeywordPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(KeywordPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters LicensesPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            LicensesPopulateColumnParameters_NotVisible.FieldName = "Licenses";
		    LicensesPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(LicensesPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_DetailPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_DetailPopulateColumnParameters_NotVisible.FieldName = "Project_Detail";
		    Project_DetailPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Project_DetailPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_RevPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_RevPopulateColumnParameters_NotVisible.FieldName = "Project_Rev";
		    Project_RevPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Project_RevPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ProjectsPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ProjectsPopulateColumnParameters_NotVisible.FieldName = "Projects";
		    ProjectsPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(ProjectsPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressPopulateColumnParameters_NotVisible.FieldName = "Store_Address";
		    Store_AddressPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_AddressPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressColPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressColPopulateColumnParameters_NotVisible.FieldName = "Store_AddressCol";
		    Store_AddressColPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_AddressColPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressPosPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressPosPopulateColumnParameters_NotVisible.FieldName = "Store_AddressPos";
		    Store_AddressPosPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_AddressPosPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressRowPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressRowPopulateColumnParameters_NotVisible.FieldName = "Store_AddressRow";
		    Store_AddressRowPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_AddressRowPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressZonePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressZonePopulateColumnParameters_NotVisible.FieldName = "Store_AddressZone";
		    Store_AddressZonePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_AddressZonePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_BrandPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_BrandPopulateColumnParameters_NotVisible.FieldName = "Store_Brand";
		    Store_BrandPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_BrandPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_LocationPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_LocationPopulateColumnParameters_NotVisible.FieldName = "Store_Location";
		    Store_LocationPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_LocationPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_LogsPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_LogsPopulateColumnParameters_NotVisible.FieldName = "Store_Logs";
		    Store_LogsPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_LogsPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_OutActionPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_OutActionPopulateColumnParameters_NotVisible.FieldName = "Store_OutAction";
		    Store_OutActionPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_OutActionPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductPopulateColumnParameters_NotVisible.FieldName = "Store_Product";
		    Store_ProductPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_ProductPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductGroupPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductGroupPopulateColumnParameters_NotVisible.FieldName = "Store_ProductGroup";
		    Store_ProductGroupPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_ProductGroupPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductTypePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductTypePopulateColumnParameters_NotVisible.FieldName = "Store_ProductType";
		    Store_ProductTypePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_ProductTypePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductUnitPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductUnitPopulateColumnParameters_NotVisible.FieldName = "Store_ProductUnit";
		    Store_ProductUnitPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_ProductUnitPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_WarehousePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_WarehousePopulateColumnParameters_NotVisible.FieldName = "Store_Warehouse";
		    Store_WarehousePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_WarehousePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_WarehouseOutPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_WarehouseOutPopulateColumnParameters_NotVisible.FieldName = "Store_WarehouseOut";
		    Store_WarehouseOutPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_WarehouseOutPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_ContactPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_ContactPopulateColumnParameters_NotVisible.FieldName = "Supplier_Contact";
		    Supplier_ContactPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Supplier_ContactPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_SectionPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_SectionPopulateColumnParameters_NotVisible.FieldName = "Supplier_Section";
		    Supplier_SectionPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Supplier_SectionPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_TypePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_TypePopulateColumnParameters_NotVisible.FieldName = "Supplier_Type";
		    Supplier_TypePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Supplier_TypePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SuppliersPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SuppliersPopulateColumnParameters_NotVisible.FieldName = "Suppliers";
		    SuppliersPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(SuppliersPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters TitlePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            TitlePopulateColumnParameters_NotVisible.FieldName = "Title";
		    TitlePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(TitlePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Title1PopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Title1PopulateColumnParameters_NotVisible.FieldName = "Title1";
		    Title1PopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Title1PopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_AccessPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_AccessPopulateColumnParameters_NotVisible.FieldName = "User_Access";
		    User_AccessPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_AccessPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Access1PopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Access1PopulateColumnParameters_NotVisible.FieldName = "User_Access1";
		    User_Access1PopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_Access1PopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_AuthorizationPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_AuthorizationPopulateColumnParameters_NotVisible.FieldName = "User_Authorization";
		    User_AuthorizationPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_AuthorizationPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Authorization1PopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Authorization1PopulateColumnParameters_NotVisible.FieldName = "User_Authorization1";
		    User_Authorization1PopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_Authorization1PopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Authorization2PopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Authorization2PopulateColumnParameters_NotVisible.FieldName = "User_Authorization2";
		    User_Authorization2PopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_Authorization2PopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_DepartmentPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_DepartmentPopulateColumnParameters_NotVisible.FieldName = "User_Department";
		    User_DepartmentPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_DepartmentPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Department1PopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Department1PopulateColumnParameters_NotVisible.FieldName = "User_Department1";
		    User_Department1PopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_Department1PopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_LevelPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_LevelPopulateColumnParameters_NotVisible.FieldName = "User_Level";
		    User_LevelPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_LevelPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Level1PopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Level1PopulateColumnParameters_NotVisible.FieldName = "User_Level1";
		    User_Level1PopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_Level1PopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_LogsPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_LogsPopulateColumnParameters_NotVisible.FieldName = "User_Logs";
		    User_LogsPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_LogsPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_OnlinePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_OnlinePopulateColumnParameters_NotVisible.FieldName = "User_Online";
		    User_OnlinePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_OnlinePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Online1PopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Online1PopulateColumnParameters_NotVisible.FieldName = "User_Online1";
		    User_Online1PopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(User_Online1PopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Users1PopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Users1PopulateColumnParameters_NotVisible.FieldName = "Users1";
		    Users1PopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Users1PopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Users2PopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Users2PopulateColumnParameters_NotVisible.FieldName = "Users2";
		    Users2PopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Users2PopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ZonePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ZonePopulateColumnParameters_NotVisible.FieldName = "Zone";
		    ZonePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(ZonePopulateColumnParameters_NotVisible);
			 
			this.gridView.PopulateColumns(typeof(Emikon.Parkon.Model.Users),parameters);
		    // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Emikon.Parkon.UI.Win.test.ViewModels.UsersCollectionViewModel);
			// 
            // layoutControl
            // 
            layoutControl.Controls.AddRange(new System.Windows.Forms.Control[] { this.labelControl, this.gridControl });
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Root = this.layoutControlGroup;
            //
            // itemLabel
            //
            this.itemLabel.Control = this.labelControl;
            this.itemLabel.TextVisible = false;
            this.itemLabel.Name = "itemLabel";
			this.itemLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(0);
            //
            // itemGrid
            //
            this.itemGrid.Control = this.gridControl;
            this.itemGrid.TextVisible = false;
            this.itemGrid.Name = "itemGrid";
			this.itemGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0);
            //
            // layoutControlGroup
            //
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Add(itemLabel);
            this.layoutControlGroup.Add(itemGrid);
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.TextVisible = false;
			this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0);
			//
			//UsersCollectionView
			//
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.windowsUIButtonPanel);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "UsersCollectionView";
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
		}
		
        #endregion

		private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private System.Windows.Forms.BindingSource usersCollectionViewBindingSource;
		private	DevExpress.XtraEditors.LabelControl labelControl;
		private	DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
		private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem itemLabel;
        private DevExpress.XtraLayout.LayoutControlItem itemGrid;
	}
}
