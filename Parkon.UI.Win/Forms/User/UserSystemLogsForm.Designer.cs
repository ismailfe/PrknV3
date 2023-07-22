namespace Emikon.Parkon.UI.Win.Forms.User
{
    partial class UserSystemLogsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSystemLogsForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition11 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition12 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition13 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition14 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition15 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition16 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition17 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition18 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition19 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition20 = new DevExpress.XtraLayout.RowDefinition();
            this.baseGrid = new Emikon.Parkon.Common.Design.Grid.MyGridControl();
            this.baseTablo = new Emikon.Parkon.Common.Design.Grid.MyGridView();
            this.colId = new Emikon.Parkon.Common.Design.Grid.MyGridColumn();
            this.colCreateDatetime = new Emikon.Parkon.Common.Design.Grid.MyGridColumn();
            this.colOnlineUser = new Emikon.Parkon.Common.Design.Grid.MyGridColumn();
            this.colWorkArea = new Emikon.Parkon.Common.Design.Grid.MyGridColumn();
            this.colJob = new Emikon.Parkon.Common.Design.Grid.MyGridColumn();
            this.colOldVal = new Emikon.Parkon.Common.Design.Grid.MyGridColumn();
            this.colNewVal = new Emikon.Parkon.Common.Design.Grid.MyGridColumn();
            this.colStatus = new Emikon.Parkon.Common.Design.Grid.MyGridColumn();
            this.ColMessages = new Emikon.Parkon.Common.Design.Grid.MyGridColumn();
            this.myDataLayoutControl1 = new Emikon.Parkon.Common.Design.Controls.MyDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.BaseSplitContainer)).BeginInit();
            this.BaseSplitContainer.Panel1.SuspendLayout();
            this.BaseSplitContainer.Panel2.SuspendLayout();
            this.BaseSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlList)).BeginInit();
            this.baseLongNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.SuspendLayout();
            // 
            // Navigator
            // 
            this.Navigator.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Navigator.Appearance.Options.UseForeColor = true;
            this.Navigator.Buttons.Append.ImageIndex = 8;
            this.Navigator.Buttons.Append.Visible = false;
            this.Navigator.Buttons.CancelEdit.Visible = false;
            this.Navigator.Buttons.Edit.Visible = false;
            this.Navigator.Buttons.EndEdit.Visible = false;
            this.Navigator.Buttons.First.ImageIndex = 2;
            this.Navigator.Buttons.Last.ImageIndex = 5;
            this.Navigator.Buttons.Next.ImageIndex = 4;
            this.Navigator.Buttons.NextPage.ImageIndex = 6;
            this.Navigator.Buttons.Prev.ImageIndex = 3;
            this.Navigator.Buttons.PrevPage.ImageIndex = 1;
            this.Navigator.Buttons.Remove.ImageIndex = 9;
            this.Navigator.Buttons.Remove.Visible = false;
            this.Navigator.Size = new System.Drawing.Size(873, 24);
            // 
            // BaseSplitContainer
            // 
            // 
            // BaseSplitContainer.Panel1
            // 
            this.BaseSplitContainer.Panel1.Controls.Add(this.myDataLayoutControl1);
            this.BaseSplitContainer.Panel1Collapsed = true;
            // 
            // BaseSplitContainer.Panel2
            // 
            this.BaseSplitContainer.Panel2.Controls.Add(this.baseGrid);
            this.BaseSplitContainer.Size = new System.Drawing.Size(873, 411);
            this.BaseSplitContainer.SplitterDistance = 176;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.SearchEditItem.UseEditorPadding = false;
            this.ribbonControl.Size = new System.Drawing.Size(873, 108);
            // 
            // ribbonControlList
            // 
            this.ribbonControlList.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControlList.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControlList.SearchEditItem.EditWidth = 150;
            this.ribbonControlList.SearchEditItem.Id = -5000;
            this.ribbonControlList.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControlList.SearchEditItem.UseEditorPadding = false;
            this.ribbonControlList.Size = new System.Drawing.Size(873, 25);
            this.ribbonControlList.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // baseLongNavigator
            // 
            this.baseLongNavigator.Location = new System.Drawing.Point(0, 389);
            this.baseLongNavigator.Size = new System.Drawing.Size(873, 22);
            // 
            // baseGrid
            // 
            this.baseGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseGrid.Location = new System.Drawing.Point(3, 31);
            this.baseGrid.MainView = this.baseTablo;
            this.baseGrid.MenuManager = this.ribbonControl;
            this.baseGrid.Name = "baseGrid";
            this.baseGrid.Size = new System.Drawing.Size(867, 352);
            this.baseGrid.TabIndex = 9;
            this.baseGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.baseTablo});
            // 
            // baseTablo
            // 
            this.baseTablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.baseTablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.baseTablo.Appearance.FooterPanel.Options.UseFont = true;
            this.baseTablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.baseTablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.baseTablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.baseTablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.baseTablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.baseTablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.baseTablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.baseTablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCreateDatetime,
            this.colOnlineUser,
            this.colWorkArea,
            this.colJob,
            this.colOldVal,
            this.colNewVal,
            this.colStatus,
            this.ColMessages});
            this.baseTablo.GridControl = this.baseGrid;
            this.baseTablo.Name = "baseTablo";
            this.baseTablo.OptionsMenu.EnableColumnMenu = false;
            this.baseTablo.OptionsMenu.EnableFooterMenu = false;
            this.baseTablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.baseTablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.baseTablo.OptionsPrint.AutoWidth = false;
            this.baseTablo.OptionsPrint.PrintFooter = false;
            this.baseTablo.OptionsPrint.PrintGroupFooter = false;
            this.baseTablo.OptionsView.ColumnAutoWidth = false;
            this.baseTablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.baseTablo.OptionsView.RowAutoHeight = true;
            this.baseTablo.OptionsView.ShowAutoFilterRow = true;
            this.baseTablo.OptionsView.ShowGroupPanel = false;
            this.baseTablo.OptionsView.ShowViewCaption = true;
            this.baseTablo.StatusBarComment = null;
            this.baseTablo.StatusBarShortcut = null;
            this.baseTablo.StatusBarShortcutComment = null;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.StatusBarComment = null;
            this.colId.StatusBarShortcut = null;
            this.colId.StatusBarShortcutComment = null;
            // 
            // colCreateDatetime
            // 
            this.colCreateDatetime.Caption = "CreateDatetime";
            this.colCreateDatetime.FieldName = "CreateDatetime";
            this.colCreateDatetime.Name = "colCreateDatetime";
            this.colCreateDatetime.OptionsColumn.AllowEdit = false;
            this.colCreateDatetime.StatusBarComment = null;
            this.colCreateDatetime.StatusBarShortcut = null;
            this.colCreateDatetime.StatusBarShortcutComment = null;
            this.colCreateDatetime.Visible = true;
            this.colCreateDatetime.VisibleIndex = 0;
            // 
            // colOnlineUser
            // 
            this.colOnlineUser.Caption = "OnlineUser";
            this.colOnlineUser.FieldName = "OnlineUser";
            this.colOnlineUser.Name = "colOnlineUser";
            this.colOnlineUser.OptionsColumn.AllowEdit = false;
            this.colOnlineUser.StatusBarComment = null;
            this.colOnlineUser.StatusBarShortcut = null;
            this.colOnlineUser.StatusBarShortcutComment = null;
            this.colOnlineUser.Visible = true;
            this.colOnlineUser.VisibleIndex = 1;
            this.colOnlineUser.Width = 106;
            // 
            // colWorkArea
            // 
            this.colWorkArea.Caption = "WorkArea";
            this.colWorkArea.FieldName = "WorkArea";
            this.colWorkArea.Name = "colWorkArea";
            this.colWorkArea.OptionsColumn.AllowEdit = false;
            this.colWorkArea.StatusBarComment = null;
            this.colWorkArea.StatusBarShortcut = null;
            this.colWorkArea.StatusBarShortcutComment = null;
            this.colWorkArea.Visible = true;
            this.colWorkArea.VisibleIndex = 2;
            this.colWorkArea.Width = 115;
            // 
            // colJob
            // 
            this.colJob.Caption = "Job";
            this.colJob.FieldName = "Job";
            this.colJob.Name = "colJob";
            this.colJob.OptionsColumn.AllowEdit = false;
            this.colJob.StatusBarComment = null;
            this.colJob.StatusBarShortcut = null;
            this.colJob.StatusBarShortcutComment = null;
            this.colJob.Visible = true;
            this.colJob.VisibleIndex = 3;
            this.colJob.Width = 185;
            // 
            // colOldVal
            // 
            this.colOldVal.Caption = "OldVal";
            this.colOldVal.FieldName = "OldVal";
            this.colOldVal.Name = "colOldVal";
            this.colOldVal.OptionsColumn.AllowEdit = false;
            this.colOldVal.StatusBarComment = null;
            this.colOldVal.StatusBarShortcut = null;
            this.colOldVal.StatusBarShortcutComment = null;
            this.colOldVal.Visible = true;
            this.colOldVal.VisibleIndex = 4;
            this.colOldVal.Width = 127;
            // 
            // colNewVal
            // 
            this.colNewVal.Caption = "NewVal";
            this.colNewVal.FieldName = "NewVal";
            this.colNewVal.Name = "colNewVal";
            this.colNewVal.OptionsColumn.AllowEdit = false;
            this.colNewVal.StatusBarComment = null;
            this.colNewVal.StatusBarShortcut = null;
            this.colNewVal.StatusBarShortcutComment = null;
            this.colNewVal.Visible = true;
            this.colNewVal.VisibleIndex = 5;
            this.colNewVal.Width = 142;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.StatusBarComment = null;
            this.colStatus.StatusBarShortcut = null;
            this.colStatus.StatusBarShortcutComment = null;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            // 
            // ColMessages
            // 
            this.ColMessages.Caption = "Messages";
            this.ColMessages.FieldName = "Messages";
            this.ColMessages.Name = "ColMessages";
            this.ColMessages.OptionsColumn.AllowEdit = false;
            this.ColMessages.StatusBarComment = null;
            this.ColMessages.StatusBarShortcut = null;
            this.ColMessages.StatusBarShortcutComment = null;
            this.ColMessages.Visible = true;
            this.ColMessages.VisibleIndex = 7;
            this.ColMessages.Width = 150;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(873, 176);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 200D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 100D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition6.Width = 99D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition4,
            columnDefinition5,
            columnDefinition6});
            rowDefinition11.Height = 24D;
            rowDefinition11.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition12.Height = 24D;
            rowDefinition12.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition13.Height = 24D;
            rowDefinition13.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition14.Height = 24D;
            rowDefinition14.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition15.Height = 24D;
            rowDefinition15.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition16.Height = 24D;
            rowDefinition16.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition17.Height = 24D;
            rowDefinition17.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition18.Height = 24D;
            rowDefinition18.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition19.Height = 24D;
            rowDefinition19.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition20.Height = 100D;
            rowDefinition20.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition11,
            rowDefinition12,
            rowDefinition13,
            rowDefinition14,
            rowDefinition15,
            rowDefinition16,
            rowDefinition17,
            rowDefinition18,
            rowDefinition19,
            rowDefinition20});
            this.Root.Size = new System.Drawing.Size(873, 237);
            this.Root.TextVisible = false;
            // 
            // UserSystemLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 541);
            this.IconOptions.ShowIcon = false;
            this.Name = "UserSystemLogsForm";
            this.Text = "UserSystemLogsForm";
            this.BaseSplitContainer.Panel1.ResumeLayout(false);
            this.BaseSplitContainer.Panel2.ResumeLayout(false);
            this.BaseSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseSplitContainer)).EndInit();
            this.BaseSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlList)).EndInit();
            this.baseLongNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Design.Grid.MyGridControl baseGrid;
        private Common.Design.Grid.MyGridView baseTablo;
        private Common.Design.Grid.MyGridColumn colId;
        private Common.Design.Grid.MyGridColumn colCreateDatetime;
        private Common.Design.Grid.MyGridColumn colOnlineUser;
        private Common.Design.Grid.MyGridColumn colWorkArea;
        private Common.Design.Grid.MyGridColumn colJob;
        private Common.Design.Grid.MyGridColumn colOldVal;
        private Common.Design.Grid.MyGridColumn colNewVal;
        private Common.Design.Grid.MyGridColumn colStatus;
        private Common.Design.Grid.MyGridColumn ColMessages;
        private Common.Design.Controls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
    }
}