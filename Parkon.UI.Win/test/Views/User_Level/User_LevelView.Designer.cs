namespace Emikon.Parkon.UI.Win.test.Views.User_LevelView {
    partial class User_LevelView {
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
						this.Users1GridControl = new DevExpress.XtraGrid.GridControl();
			this.Users1GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Users1BarManager = new DevExpress.XtraBars.BarManager();
			this.Users1Bar = new DevExpress.XtraBars.Bar();
			this.Users1XtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.Users1PopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiUsers1New = new DevExpress.XtraBars.BarButtonItem();
						this.bbiUsers1Edit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiUsers1Delete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiUsers1Refresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.Users1BarManager)).BeginInit();
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
			this.user_LevelViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.user_LevelViewBindingSource.DataSource = typeof(Emikon.Parkon.Model.User_Level);
			this.dataLayoutControl1.DataSource = user_LevelViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//Users1GridControl
			//
			this.Users1GridControl.MainView = this.Users1GridView;
			this.Users1GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Users1GridControl.Name = "Users1GridControl";
            this.Users1GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Users1GridView});
			//
			//Users1GridView
			//
            this.Users1GridView.GridControl = this.Users1GridControl;
            this.Users1GridView.Name = "Users1GridView";
            this.Users1GridView.OptionsBehavior.Editable = false;
            this.Users1GridView.OptionsBehavior.ReadOnly = true;
			this.Users1GridView.OptionsView.ShowGroupPanel = false;
			//
			//Users1PopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters Users1PopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_ContactUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_ContactUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Customer_Contact";
		    Customer_ContactUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Customer_ContactUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_TypeUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_TypeUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Customer_Type";
		    Customer_TypeUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Customer_TypeUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Customers";
		    CustomersUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(CustomersUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters KeywordUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            KeywordUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Keyword";
		    KeywordUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(KeywordUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters LicensesUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            LicensesUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Licenses";
		    LicensesUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(LicensesUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_DetailUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_DetailUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Project_Detail";
		    Project_DetailUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Project_DetailUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_RevUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_RevUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Project_Rev";
		    Project_RevUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Project_RevUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ProjectsUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ProjectsUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Projects";
		    ProjectsUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(ProjectsUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Address";
		    Store_AddressUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_AddressUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressColUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressColUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_AddressCol";
		    Store_AddressColUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_AddressColUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressPosUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressPosUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_AddressPos";
		    Store_AddressPosUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_AddressPosUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressRowUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressRowUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_AddressRow";
		    Store_AddressRowUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_AddressRowUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressZoneUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressZoneUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_AddressZone";
		    Store_AddressZoneUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_AddressZoneUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_BrandUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_BrandUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Brand";
		    Store_BrandUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_BrandUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_LocationUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_LocationUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Location";
		    Store_LocationUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_LocationUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_LogsUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_LogsUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Logs";
		    Store_LogsUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_LogsUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_OutActionUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_OutActionUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_OutAction";
		    Store_OutActionUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_OutActionUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Product";
		    Store_ProductUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductGroupUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductGroupUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_ProductGroup";
		    Store_ProductGroupUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductGroupUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductTypeUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductTypeUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_ProductType";
		    Store_ProductTypeUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductTypeUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductUnitUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductUnitUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_ProductUnit";
		    Store_ProductUnitUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_ProductUnitUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_WarehouseUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_WarehouseUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_Warehouse";
		    Store_WarehouseUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_WarehouseUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_WarehouseOutUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_WarehouseOutUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Store_WarehouseOut";
		    Store_WarehouseOutUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Store_WarehouseOutUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_ContactUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_ContactUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Supplier_Contact";
		    Supplier_ContactUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Supplier_ContactUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_SectionUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_SectionUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Supplier_Section";
		    Supplier_SectionUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Supplier_SectionUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Supplier_TypeUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Supplier_TypeUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Supplier_Type";
		    Supplier_TypeUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Supplier_TypeUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SuppliersUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SuppliersUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Suppliers";
		    SuppliersUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(SuppliersUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters TitleUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            TitleUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Title";
		    TitleUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(TitleUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Title1Users1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Title1Users1ChildPopulateColumnParameters_NotVisible.FieldName = "Title1";
		    Title1Users1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Title1Users1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_AccessUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_AccessUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Access";
		    User_AccessUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_AccessUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Access1Users1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Access1Users1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Access1";
		    User_Access1Users1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_Access1Users1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_AuthorizationUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_AuthorizationUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Authorization";
		    User_AuthorizationUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_AuthorizationUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Authorization1Users1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Authorization1Users1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Authorization1";
		    User_Authorization1Users1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_Authorization1Users1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Authorization2Users1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Authorization2Users1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Authorization2";
		    User_Authorization2Users1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_Authorization2Users1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_DepartmentUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_DepartmentUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Department";
		    User_DepartmentUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_DepartmentUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Department1Users1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Department1Users1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Department1";
		    User_Department1Users1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_Department1Users1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_LevelUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_LevelUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Level";
		    User_LevelUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_LevelUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Level1Users1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Level1Users1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Level1";
		    User_Level1Users1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_Level1Users1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_LogsUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_LogsUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Logs";
		    User_LogsUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_LogsUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_OnlineUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_OnlineUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Online";
		    User_OnlineUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_OnlineUsers1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters User_Online1Users1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            User_Online1Users1ChildPopulateColumnParameters_NotVisible.FieldName = "User_Online1";
		    User_Online1Users1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(User_Online1Users1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Users1Users1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Users1Users1ChildPopulateColumnParameters_NotVisible.FieldName = "Users1";
		    Users1Users1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Users1Users1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Users2Users1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Users2Users1ChildPopulateColumnParameters_NotVisible.FieldName = "Users2";
		    Users2Users1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Users2Users1ChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ZoneUsers1ChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ZoneUsers1ChildPopulateColumnParameters_NotVisible.FieldName = "Zone";
		    ZoneUsers1ChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(ZoneUsers1ChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersUsers1ChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersUsers1ChildPopulateColumnParameters.FieldName = "UsersUsers1";
            UsersUsers1ChildPopulateColumnParameters.Path = "Users.NameFirst";
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(UsersUsers1ChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Users1Users1ChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Users1Users1ChildPopulateColumnParameters.FieldName = "Users1Users1";
            Users1Users1ChildPopulateColumnParameters.Path = "Users1.NameFirst";
			Users1PopulateColumnsParameters.CustomColumnParameters.Add(Users1Users1ChildPopulateColumnParameters);
			 
		    this.Users1GridView.PopulateColumns(typeof(Emikon.Parkon.Model.Users),Users1PopulateColumnsParameters);
			//
			//Users1BindingSource
			//
			System.Windows.Forms.BindingSource Users1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			Users1BindingSource.DataSource = typeof(Emikon.Parkon.Model.Users);
            this.Users1GridControl.DataSource = Users1BindingSource;
			//
			//Users1XtraUserControl
			//
            this.Users1XtraUserControl.Controls.Add(Users1GridControl);
			this.Users1XtraUserControl.Name = "Users1XtraUserControl";
			this.Users1XtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//Users1New
			//
			this.bbiUsers1New.Caption = "New";
			this.bbiUsers1New.Name = "bbiUsers1New";
			this.bbiUsers1New.ImageUri.Uri = "New";
			this.bbiUsers1New.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Users1BarManager.Items.Add(this.bbiUsers1New);
			this.Users1Bar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers1New));
			this.Users1PopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers1New));
						//
			//Users1Edit
			//
			this.bbiUsers1Edit.Caption = "Edit";
			this.bbiUsers1Edit.Name = "bbiUsers1Edit";
			this.bbiUsers1Edit.ImageUri.Uri = "Edit";
			this.bbiUsers1Edit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Users1BarManager.Items.Add(this.bbiUsers1Edit);
			this.Users1Bar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers1Edit));
			this.Users1PopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers1Edit));
						//
			//Users1Delete
			//
			this.bbiUsers1Delete.Caption = "Delete";
			this.bbiUsers1Delete.Name = "bbiUsers1Delete";
			this.bbiUsers1Delete.ImageUri.Uri = "Delete";
			this.bbiUsers1Delete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Users1BarManager.Items.Add(this.bbiUsers1Delete);
			this.Users1Bar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers1Delete));
			this.Users1PopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers1Delete));
						//
			//Users1Refresh
			//
			this.bbiUsers1Refresh.Caption = "Refresh";
			this.bbiUsers1Refresh.Name = "bbiUsers1Refresh";
			this.bbiUsers1Refresh.ImageUri.Uri = "Refresh";
			this.bbiUsers1Refresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.Users1BarManager.Items.Add(this.bbiUsers1Refresh);
			this.Users1Bar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers1Refresh));
			this.Users1PopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiUsers1Refresh));
						//
			//Users1Bar
			//
			this.Users1Bar.BarName = "Users1";
            this.Users1Bar.DockCol = 0;
            this.Users1Bar.DockRow = 0;
            this.Users1Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Users1Bar.OptionsBar.AllowQuickCustomization = false;
            this.Users1Bar.OptionsBar.DrawDragBorder = false;
            this.Users1Bar.Text = "Users1";
			//
			//Users1BarManager
			//
			this.Users1BarManager.AllowCustomization = false;
            this.Users1BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.Users1Bar});
            this.Users1BarManager.Form = Users1XtraUserControl;
            this.Users1BarManager.MainMenu = this.Users1Bar;
			// 
            // Users1PopUpMenu
            // 
            this.Users1PopUpMenu.Manager = this.Users1BarManager;
            this.Users1PopUpMenu.Name = "Users1PopUpMenu";
			//
			//Users1RetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters Users1RetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            Users1RetriveFieldParameters.FieldName = "Users1";
            Users1RetriveFieldParameters.ControlForField = Users1XtraUserControl;
			Users1RetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(Users1RetriveFieldParameters);
									//
			//UsersLookUpEdit
			//
			this.UsersBindingSource.DataSource = typeof(Emikon.Parkon.Model.Users);
			this.UsersLookUpEdit.Properties.ValueMember = "Id"; 
			this.UsersLookUpEdit.Properties.DisplayMember = "NameFirst";
			this.UsersLookUpEdit.Properties.DataSource = this.UsersBindingSource;
			this.UsersLookUpEdit.Name = "UsersLookUpEdit";
			this.UsersLookUpEdit.DataBindings.Add("EditValue", user_LevelViewBindingSource, "UserId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
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
            this.mvvmContext.ViewModelType = typeof(Emikon.Parkon.UI.Win.test.ViewModels.User_LevelViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "User_Level - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//User_LevelView
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
            this.Name = "User_LevelView";
						((System.ComponentModel.ISupportInitialize)(this.Users1BarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource user_LevelViewBindingSource;
				private DevExpress.XtraGrid.GridControl Users1GridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView Users1GridView;
		private DevExpress.XtraBars.BarManager Users1BarManager;
		private DevExpress.XtraBars.Bar Users1Bar;
		private DevExpress.XtraEditors.XtraUserControl Users1XtraUserControl;
		private DevExpress.XtraBars.PopupMenu Users1PopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiUsers1New;
				private DevExpress.XtraBars.BarButtonItem bbiUsers1Edit;
				private DevExpress.XtraBars.BarButtonItem bbiUsers1Delete;
				private DevExpress.XtraBars.BarButtonItem bbiUsers1Refresh;
								private DevExpress.XtraEditors.GridLookUpEdit UsersLookUpEdit;
		private System.Windows.Forms.BindingSource UsersBindingSource;
		 
	}
}
