namespace Emikon.Parkon.UI.Win.test.Views.User_AuthorizationView {
    partial class User_AuthorizationView {
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
						this.Users2GridControl = new DevExpress.XtraGrid.GridControl();
			this.Users2GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Users2BarManager = new DevExpress.XtraBars.BarManager();
			this.Users2Bar = new DevExpress.XtraBars.Bar();
			this.Users2XtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.Users2PopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiUsers2New = new DevExpress.XtraBars.BarButtonItem();
						this.bbiUsers2Edit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiUsers2Delete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiUsers2Refresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.Users2BarManager)).BeginInit();
									this.UsersLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.Users1LookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.Users1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
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
			this.user_AuthorizationViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.user_AuthorizationViewBindingSource.DataSource = typeof(Emikon.Parkon.Model.User_Authorization);
			this.dataLayoutControl1.DataSource = user_AuthorizationViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//Users2GridControl
			//
			this.Users2GridControl.MainView = this.Users2GridView;
			this.Users2GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Users2GridControl.Name = "Users2GridControl";
            this.Users2GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Users2GridView});
			//
			//Users2GridView
			//
            this.Users2GridView.GridControl = this.Users2GridControl;
            this.Users2GridView.Name = "Users2GridView";
            this.Users2GridView.OptionsBehavior.Editable = false;
            this.Users2GridView.OptionsBehavior.ReadOnly = true;
			this.Users2GridView.OptionsView.ShowGroupPanel = false;
			//
			//Users2PopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters Users2PopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_ContactUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_ContactUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Customer_Contact";
		    Customer_ContactUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Customer_ContactUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_TypeUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_TypeUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Customer_Type";
		    Customer_TypeUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Customer_TypeUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Customers";
		    CustomersUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(CustomersUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters KeywordUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            KeywordUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Keyword";
		    KeywordUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(KeywordUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters LicensesUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            LicensesUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Licenses";
		    LicensesUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(LicensesUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_DetailUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_DetailUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Project_Detail";
		    Project_DetailUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Project_DetailUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_RevUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_RevUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Project_Rev";
		    Project_RevUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Project_RevUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ProjectsUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ProjectsUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Projects";
		    ProjectsUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(ProjectsUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Address";
		    Store_AddressUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_AddressUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressColUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressColUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_AddressCol";
		    Store_AddressColUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_AddressColUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressPosUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressPosUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_AddressPos";
		    Store_AddressPosUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_AddressPosUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressRowUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressRowUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_AddressRow";
		    Store_AddressRowUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_AddressRowUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressZoneUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressZoneUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_AddressZone";
		    Store_AddressZoneUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_AddressZoneUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_BrandUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_BrandUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Brand";
		    Store_BrandUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_BrandUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_LocationUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_LocationUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Location";
		    Store_LocationUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_LocationUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_LogsUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_LogsUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Logs";
		    Store_LogsUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_LogsUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_OutActionUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_OutActionUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_OutAction";
		    Store_OutActionUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_OutActionUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Product";
		    Store_ProductUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductGroupUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductGroupUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_ProductGroup";
		    Store_ProductGroupUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductGroupUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductTypeUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductTypeUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_ProductType";
		    Store_ProductTypeUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductTypeUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductUnitUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductUnitUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_ProductUnit";
		    Store_ProductUnitUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductUnitUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_WarehouseUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_WarehouseUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Warehouse";
		    Store_WarehouseUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_WarehouseUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_WarehouseOutUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_WarehouseOutUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Store_WarehouseOut";
		    Store_WarehouseOutUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Store_WarehouseOutUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_ContactUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_ContactUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Supplier_Contact";
		    Supplier_ContactUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Supplier_ContactUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_SectionUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_SectionUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Supplier_Section";
		    Supplier_SectionUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Supplier_SectionUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_TypeUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_TypeUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Supplier_Type";
		    Supplier_TypeUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Supplier_TypeUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SuppliersUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SuppliersUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Suppliers";
		    SuppliersUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(SuppliersUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters TitleUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            TitleUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Title";
		    TitleUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(TitleUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Title1Users2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Title1Users2ChildPopulateColumnParameters_NotVisible.FieldName = "Title1";
		    Title1Users2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Title1Users2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_AccessUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_AccessUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Access";
		    User_AccessUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_AccessUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Access1Users2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Access1Users2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Access1";
		    User_Access1Users2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_Access1Users2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_AuthorizationUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_AuthorizationUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Authorization";
		    User_AuthorizationUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_AuthorizationUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Authorization1Users2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Authorization1Users2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Authorization1";
		    User_Authorization1Users2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_Authorization1Users2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Authorization2Users2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Authorization2Users2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Authorization2";
		    User_Authorization2Users2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_Authorization2Users2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_DepartmentUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_DepartmentUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Department";
		    User_DepartmentUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_DepartmentUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Department1Users2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Department1Users2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Department1";
		    User_Department1Users2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_Department1Users2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_LevelUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_LevelUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Level";
		    User_LevelUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_LevelUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Level1Users2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Level1Users2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Level1";
		    User_Level1Users2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_Level1Users2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_LogsUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_LogsUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Logs";
		    User_LogsUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_LogsUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_OnlineUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_OnlineUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Online";
		    User_OnlineUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_OnlineUsers2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Online1Users2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Online1Users2ChildPopulateColumnParameters_NotVisible.FieldName = "User_Online1";
		    User_Online1Users2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(User_Online1Users2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Users1Users2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Users1Users2ChildPopulateColumnParameters_NotVisible.FieldName = "Users1";
		    Users1Users2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Users1Users2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Users2Users2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Users2Users2ChildPopulateColumnParameters_NotVisible.FieldName = "Users2";
		    Users2Users2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Users2Users2ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ZoneUsers2ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ZoneUsers2ChildPopulateColumnParameters_NotVisible.FieldName = "Zone";
		    ZoneUsers2ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(ZoneUsers2ChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersUsers2ChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersUsers2ChildPopulateColumnParameters.FieldName = "UsersUsers2";
            UsersUsers2ChildPopulateColumnParameters.Path = "Users.NameFirst";
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(UsersUsers2ChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Users1Users2ChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Users1Users2ChildPopulateColumnParameters.FieldName = "Users1Users2";
            Users1Users2ChildPopulateColumnParameters.Path = "Users1.NameFirst";
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Users1Users2ChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Users2Users2ChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Users2Users2ChildPopulateColumnParameters.FieldName = "Users2Users2";
            Users2Users2ChildPopulateColumnParameters.Path = "Users2.NameFirst";
			Users2PopulateColumnsParameters.CustomColumnParameters.Add(Users2Users2ChildPopulateColumnParameters);
			 
		    this.Users2GridView.PopulateColumns(typeof(Emikon.Parkon.Model.Users),Users2PopulateColumnsParameters);
			//
			//Users2BindingSource
			//
			System.Windows.Forms.BindingSource Users2BindingSource = new System.Windows.Forms.BindingSource(this.components);
			Users2BindingSource.DataSource = typeof(Emikon.Parkon.Model.Users);
            this.Users2GridControl.DataSource = Users2BindingSource;
			//
			//Users2XtraUserControl
			//
            this.Users2XtraUserControl.Controls.Add(Users2GridControl);
			this.Users2XtraUserControl.Name = "Users2XtraUserControl";
			this.Users2XtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//Users2New
			//
			this.bbiUsers2New.Caption = "New";
			this.bbiUsers2New.Name = "bbiUsers2New";
			this.bbiUsers2New.ImageUri.Uri = "New";
			this.bbiUsers2New.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Users2BarManager.Items.Add(this.bbiUsers2New);
			this.Users2Bar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers2New));
			this.Users2PopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers2New));
						//
			//Users2Edit
			//
			this.bbiUsers2Edit.Caption = "Edit";
			this.bbiUsers2Edit.Name = "bbiUsers2Edit";
			this.bbiUsers2Edit.ImageUri.Uri = "Edit";
			this.bbiUsers2Edit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Users2BarManager.Items.Add(this.bbiUsers2Edit);
			this.Users2Bar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers2Edit));
			this.Users2PopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers2Edit));
						//
			//Users2Delete
			//
			this.bbiUsers2Delete.Caption = "Delete";
			this.bbiUsers2Delete.Name = "bbiUsers2Delete";
			this.bbiUsers2Delete.ImageUri.Uri = "Delete";
			this.bbiUsers2Delete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Users2BarManager.Items.Add(this.bbiUsers2Delete);
			this.Users2Bar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers2Delete));
			this.Users2PopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers2Delete));
						//
			//Users2Refresh
			//
			this.bbiUsers2Refresh.Caption = "Refresh";
			this.bbiUsers2Refresh.Name = "bbiUsers2Refresh";
			this.bbiUsers2Refresh.ImageUri.Uri = "Refresh";
			this.bbiUsers2Refresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Users2BarManager.Items.Add(this.bbiUsers2Refresh);
			this.Users2Bar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers2Refresh));
			this.Users2PopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers2Refresh));
						//
			//Users2Bar
			//
			this.Users2Bar.BarName = "Users2";
            this.Users2Bar.DockCol = 0;
            this.Users2Bar.DockRow = 0;
            this.Users2Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Users2Bar.OptionsBar.AllowQuickCustomization = false;
            this.Users2Bar.OptionsBar.DrawDragBorder = false;
            this.Users2Bar.Text = "Users2";
			//
			//Users2BarManager
			//
			this.Users2BarManager.AllowCustomization = false;
            this.Users2BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Users2Bar});
            this.Users2BarManager.Form = Users2XtraUserControl;
            this.Users2BarManager.MainMenu = this.Users2Bar;
			// 
            // Users2PopUpMenu
            // 
            this.Users2PopUpMenu.Manager = this.Users2BarManager;
            this.Users2PopUpMenu.Name = "Users2PopUpMenu";
			//
			//Users2RetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters Users2RetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Users2RetriveFieldParameters.FieldName = "Users2";
            Users2RetriveFieldParameters.ControlForField = Users2XtraUserControl;
			Users2RetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(Users2RetriveFieldParameters);
									//
			//UsersLookUpEdit
			//
			this.UsersBindingSource.DataSource = typeof(Emikon.Parkon.Model.Users);
			this.UsersLookUpEdit.Properties.ValueMember = "Id"; 
			this.UsersLookUpEdit.Properties.DisplayMember = "NameFirst";
			this.UsersLookUpEdit.Properties.DataSource = this.UsersBindingSource;
			this.UsersLookUpEdit.Name = "UsersLookUpEdit";
			this.UsersLookUpEdit.DataBindings.Add("EditValue", user_AuthorizationViewBindingSource, "UserId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters UsersLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            UsersLookUpEditRetrieveFieldParameters.FieldName = "UserId";
            UsersLookUpEditRetrieveFieldParameters.ControlForField = this.UsersLookUpEdit;
			parameters.CustomListParameters.Add(UsersLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters UsersLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    UsersLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Users";
		    UsersLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(UsersLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//Users1LookUpEdit
			//
			this.Users1BindingSource.DataSource = typeof(Emikon.Parkon.Model.Users);
			this.Users1LookUpEdit.Properties.ValueMember = "Id"; 
			this.Users1LookUpEdit.Properties.DisplayMember = "NameFirst";
			this.Users1LookUpEdit.Properties.DataSource = this.Users1BindingSource;
			this.Users1LookUpEdit.Name = "Users1LookUpEdit";
			this.Users1LookUpEdit.DataBindings.Add("EditValue", user_AuthorizationViewBindingSource, "SetUserId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Users1LookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Users1LookUpEditRetrieveFieldParameters.FieldName = "SetUserId";
            Users1LookUpEditRetrieveFieldParameters.ControlForField = this.Users1LookUpEdit;
			parameters.CustomListParameters.Add(Users1LookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters Users1LookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    Users1LookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Users1";
		    Users1LookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(Users1LookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Emikon.Parkon.UI.Win.test.ViewModels.User_AuthorizationViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "User_Authorization - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//User_AuthorizationView
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
            this.Name = "User_AuthorizationView";
						((System.ComponentModel.ISupportInitialize)(this.Users2BarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource user_AuthorizationViewBindingSource;
				private DevExpress.XtraGrid.GridControl Users2GridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView Users2GridView;
		private DevExpress.XtraBars.BarManager Users2BarManager;
		private DevExpress.XtraBars.Bar Users2Bar;
		private DevExpress.XtraEditors.XtraUserControl Users2XtraUserControl;
		private DevExpress.XtraBars.PopupMenu Users2PopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiUsers2New;
				private DevExpress.XtraBars.BarButtonItem bbiUsers2Edit;
				private DevExpress.XtraBars.BarButtonItem bbiUsers2Delete;
				private DevExpress.XtraBars.BarButtonItem bbiUsers2Refresh;
								private DevExpress.XtraEditors.GridLookUpEdit UsersLookUpEdit;
		private System.Windows.Forms.BindingSource UsersBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit Users1LookUpEdit;
		private System.Windows.Forms.BindingSource Users1BindingSource;
		 
	}
}
