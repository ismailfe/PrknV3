namespace Emikon.Parkon.UI.Win.test.Views.ProjectsCollectionView {
    partial class ProjectsCollectionView {
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
            this.labelControl.Text = "Projects";
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
			this.projectsCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.projectsCollectionViewBindingSource.DataSource = typeof(Emikon.Parkon.Model.Projects);
			this.gridControl.DataSource = projectsCollectionViewBindingSource;

			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters parameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
						//
			//Customer_Contact
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_ContactPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_ContactPopulateColumnParameters.FieldName = "Customer_Contact";
            Customer_ContactPopulateColumnParameters.Path = "Customer_Contact.NameFirst";
			parameters.CustomColumnParameters.Add(Customer_ContactPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_ContactPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_ContactPopulateColumnParameters_NotGenerate.FieldName = "CustomerContactId";
		    Customer_ContactPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Customer_ContactPopulateColumnParameters_NotGenerate);
									//
			//Customer_Section
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_SectionPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_SectionPopulateColumnParameters.FieldName = "Customer_Section";
            Customer_SectionPopulateColumnParameters.Path = "Customer_Section.Name";
			parameters.CustomColumnParameters.Add(Customer_SectionPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_SectionPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_SectionPopulateColumnParameters_NotGenerate.FieldName = "CustomerSectionId";
		    Customer_SectionPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Customer_SectionPopulateColumnParameters_NotGenerate);
									//
			//Customers
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersPopulateColumnParameters.FieldName = "Customers";
            CustomersPopulateColumnParameters.Path = "Customers.Name";
			parameters.CustomColumnParameters.Add(CustomersPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersPopulateColumnParameters_NotGenerate.FieldName = "CustomerId";
		    CustomersPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(CustomersPopulateColumnParameters_NotGenerate);
									//
			//Project_Detail
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_DetailPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_DetailPopulateColumnParameters.FieldName = "Project_Detail";
            Project_DetailPopulateColumnParameters.Path = "Project_Detail.Name";
			parameters.CustomColumnParameters.Add(Project_DetailPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_DetailPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_DetailPopulateColumnParameters_NotGenerate.FieldName = "ProjectDetailId";
		    Project_DetailPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Project_DetailPopulateColumnParameters_NotGenerate);
									//
			//Users
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersPopulateColumnParameters.FieldName = "Users";
            UsersPopulateColumnParameters.Path = "Users.NameFirst";
			parameters.CustomColumnParameters.Add(UsersPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersPopulateColumnParameters_NotGenerate.FieldName = "UserId";
		    UsersPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(UsersPopulateColumnParameters_NotGenerate);
										
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_ContactPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_ContactPopulateColumnParameters_NotVisible.FieldName = "Customer_Contact";
		    Customer_ContactPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Customer_ContactPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Customer_SectionPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Customer_SectionPopulateColumnParameters_NotVisible.FieldName = "Customer_Section";
		    Customer_SectionPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Customer_SectionPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters CustomersPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            CustomersPopulateColumnParameters_NotVisible.FieldName = "Customers";
		    CustomersPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(CustomersPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_DetailPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_DetailPopulateColumnParameters_NotVisible.FieldName = "Project_Detail";
		    Project_DetailPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Project_DetailPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Project_RevPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Project_RevPopulateColumnParameters_NotVisible.FieldName = "Project_Rev";
		    Project_RevPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Project_RevPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersPopulateColumnParameters_NotVisible.FieldName = "Users";
		    UsersPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(UsersPopulateColumnParameters_NotVisible);
			 
			this.gridView.PopulateColumns(typeof(Emikon.Parkon.Model.Projects),parameters);
		    // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Emikon.Parkon.UI.Win.test.ViewModels.ProjectsCollectionViewModel);
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
			//ProjectsCollectionView
			//
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.windowsUIButtonPanel);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "ProjectsCollectionView";
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
		private System.Windows.Forms.BindingSource projectsCollectionViewBindingSource;
		private	DevExpress.XtraEditors.LabelControl labelControl;
		private	DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
		private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem itemLabel;
        private DevExpress.XtraLayout.LayoutControlItem itemGrid;
	}
}
