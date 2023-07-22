namespace Emikon.Parkon.UI.Win.test.Views.Store_ProductCollectionView {
    partial class Store_ProductCollectionView {
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
            this.labelControl.Text = "Store_Product";
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
			this.store_ProductCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.store_ProductCollectionViewBindingSource.DataSource = typeof(Emikon.Parkon.Model.Store_Product);
			this.gridControl.DataSource = store_ProductCollectionViewBindingSource;

			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters parameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
						//
			//Store_Address
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressPopulateColumnParameters.FieldName = "Store_Address";
            Store_AddressPopulateColumnParameters.Path = "Store_Address.SysCode";
			parameters.CustomColumnParameters.Add(Store_AddressPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressPopulateColumnParameters_NotGenerate.FieldName = "AddressId";
		    Store_AddressPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_AddressPopulateColumnParameters_NotGenerate);
									//
			//Store_Location
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_LocationPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_LocationPopulateColumnParameters.FieldName = "Store_Location";
            Store_LocationPopulateColumnParameters.Path = "Store_Location.Name";
			parameters.CustomColumnParameters.Add(Store_LocationPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_LocationPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_LocationPopulateColumnParameters_NotGenerate.FieldName = "LocationId";
		    Store_LocationPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_LocationPopulateColumnParameters_NotGenerate);
									//
			//Store_ProductGroup
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductGroupPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductGroupPopulateColumnParameters.FieldName = "Store_ProductGroup";
            Store_ProductGroupPopulateColumnParameters.Path = "Store_ProductGroup.Name";
			parameters.CustomColumnParameters.Add(Store_ProductGroupPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductGroupPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductGroupPopulateColumnParameters_NotGenerate.FieldName = "GroupId";
		    Store_ProductGroupPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_ProductGroupPopulateColumnParameters_NotGenerate);
									//
			//Store_ProductType
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductTypePopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductTypePopulateColumnParameters.FieldName = "Store_ProductType";
            Store_ProductTypePopulateColumnParameters.Path = "Store_ProductType.Name";
			parameters.CustomColumnParameters.Add(Store_ProductTypePopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductTypePopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductTypePopulateColumnParameters_NotGenerate.FieldName = "TypeId";
		    Store_ProductTypePopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_ProductTypePopulateColumnParameters_NotGenerate);
									//
			//Store_ProductUnit
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductUnitPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductUnitPopulateColumnParameters.FieldName = "Store_ProductUnit";
            Store_ProductUnitPopulateColumnParameters.Path = "Store_ProductUnit.Name";
			parameters.CustomColumnParameters.Add(Store_ProductUnitPopulateColumnParameters);
						DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_ProductUnitPopulateColumnParameters_NotGenerate = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_ProductUnitPopulateColumnParameters_NotGenerate.FieldName = "UnitId";
		    Store_ProductUnitPopulateColumnParameters_NotGenerate.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_ProductUnitPopulateColumnParameters_NotGenerate);
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
										
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_AddressPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_AddressPopulateColumnParameters_NotVisible.FieldName = "Store_Address";
		    Store_AddressPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_AddressPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_LocationPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_LocationPopulateColumnParameters_NotVisible.FieldName = "Store_Location";
		    Store_LocationPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_LocationPopulateColumnParameters_NotVisible);
				
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
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters UsersPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            UsersPopulateColumnParameters_NotVisible.FieldName = "Users";
		    UsersPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(UsersPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_WarehousePopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_WarehousePopulateColumnParameters_NotVisible.FieldName = "Store_Warehouse";
		    Store_WarehousePopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_WarehousePopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters Store_WarehouseOutPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            Store_WarehouseOutPopulateColumnParameters_NotVisible.FieldName = "Store_WarehouseOut";
		    Store_WarehouseOutPopulateColumnParameters_NotVisible.ColumnVisible = false;
			parameters.CustomColumnParameters.Add(Store_WarehouseOutPopulateColumnParameters_NotVisible);
			 
			this.gridView.PopulateColumns(typeof(Emikon.Parkon.Model.Store_Product),parameters);
		    // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Emikon.Parkon.UI.Win.test.ViewModels.Store_ProductCollectionViewModel);
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
			//Store_ProductCollectionView
			//
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.windowsUIButtonPanel);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "Store_ProductCollectionView";
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
		private System.Windows.Forms.BindingSource store_ProductCollectionViewBindingSource;
		private	DevExpress.XtraEditors.LabelControl labelControl;
		private	DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
		private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem itemLabel;
        private DevExpress.XtraLayout.LayoutControlItem itemGrid;
	}
}
