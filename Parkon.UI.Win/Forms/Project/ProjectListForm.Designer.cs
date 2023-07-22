namespace Prkn.UI.Win.Forms.Project
{
    partial class ProjectListForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.baseGrid = new Prkn.Common.Design.Grid.MyGridControl();
            this.baseTablo = new Prkn.Common.Design.Grid.MyGridView();
            this.colId = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colSysCode = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colCreateDate = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colUpdateDate = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colDeleteDate = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colVarStatus = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colComment = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colUserId = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colProjectDetailId = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colCustomerId = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colCustomerSectionId = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colCustomerContactId = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colRefNoOld = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colRefNo = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colPeriodYear = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colPeriodMonth = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colDateStart = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colDateEnd = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colNo = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colCode = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colName = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colCustomerName = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colCustomerSectionName = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colCustomerContactName = new Prkn.Common.Design.Grid.MyGridColumn();
            this.colKeyword = new Prkn.Common.Design.Grid.MyGridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.baseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // baseGrid
            // 
            this.baseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.baseGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.baseGrid.Location = new System.Drawing.Point(0, 0);
            this.baseGrid.MainView = this.baseTablo;
            this.baseGrid.Name = "baseGrid";
            this.baseGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.baseGrid.Size = new System.Drawing.Size(1209, 583);
            this.baseGrid.TabIndex = 11;
            this.baseGrid.TabStop = false;
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
            this.colSysCode,
            this.colCreateDate,
            this.colUpdateDate,
            this.colDeleteDate,
            this.colVarStatus,
            this.colComment,
            this.colUserId,
            this.colProjectDetailId,
            this.colCustomerId,
            this.colCustomerSectionId,
            this.colCustomerContactId,
            this.colRefNoOld,
            this.colRefNo,
            this.colPeriodYear,
            this.colPeriodMonth,
            this.colDateStart,
            this.colDateEnd,
            this.colNo,
            this.colCode,
            this.colName,
            this.colCustomerName,
            this.colCustomerSectionName,
            this.colCustomerContactName,
            this.colKeyword});
            this.baseTablo.CustomizationFormBounds = new System.Drawing.Rectangle(1243, 455, 252, 266);
            this.baseTablo.GridControl = this.baseGrid;
            this.baseTablo.Name = "baseTablo";
            this.baseTablo.OptionsMenu.EnableFooterMenu = false;
            this.baseTablo.OptionsMenu.EnableGroupRowMenu = true;
            this.baseTablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.baseTablo.OptionsPrint.AutoWidth = false;
            this.baseTablo.OptionsPrint.PrintFooter = false;
            this.baseTablo.OptionsPrint.PrintGroupFooter = false;
            this.baseTablo.OptionsView.ColumnAutoWidth = false;
            this.baseTablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.baseTablo.OptionsView.RowAutoHeight = true;
            this.baseTablo.OptionsView.ShowAutoFilterRow = true;
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
            this.colId.StatusBarComment = null;
            this.colId.StatusBarShortcut = null;
            this.colId.StatusBarShortcutComment = null;
            // 
            // colSysCode
            // 
            this.colSysCode.Caption = "SysCode";
            this.colSysCode.FieldName = "SysCode";
            this.colSysCode.Name = "colSysCode";
            this.colSysCode.StatusBarComment = null;
            this.colSysCode.StatusBarShortcut = null;
            this.colSysCode.StatusBarShortcutComment = null;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "CreateDate";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.StatusBarComment = null;
            this.colCreateDate.StatusBarShortcut = null;
            this.colCreateDate.StatusBarShortcutComment = null;
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.Caption = "UpdateDate";
            this.colUpdateDate.FieldName = "UpdateDate";
            this.colUpdateDate.Name = "colUpdateDate";
            this.colUpdateDate.StatusBarComment = null;
            this.colUpdateDate.StatusBarShortcut = null;
            this.colUpdateDate.StatusBarShortcutComment = null;
            // 
            // colDeleteDate
            // 
            this.colDeleteDate.Caption = "DeleteDate";
            this.colDeleteDate.FieldName = "DeleteDate";
            this.colDeleteDate.Name = "colDeleteDate";
            this.colDeleteDate.StatusBarComment = null;
            this.colDeleteDate.StatusBarShortcut = null;
            this.colDeleteDate.StatusBarShortcutComment = null;
            // 
            // colVarStatus
            // 
            this.colVarStatus.Caption = "VarStatus";
            this.colVarStatus.FieldName = "VarStatus";
            this.colVarStatus.Name = "colVarStatus";
            this.colVarStatus.StatusBarComment = null;
            this.colVarStatus.StatusBarShortcut = null;
            this.colVarStatus.StatusBarShortcutComment = null;
            // 
            // colComment
            // 
            this.colComment.Caption = "Açıklama / Not";
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.StatusBarComment = null;
            this.colComment.StatusBarShortcut = null;
            this.colComment.StatusBarShortcutComment = null;
            this.colComment.Visible = true;
            this.colComment.VisibleIndex = 5;
            this.colComment.Width = 194;
            // 
            // colUserId
            // 
            this.colUserId.Caption = "UserId";
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            this.colUserId.StatusBarComment = null;
            this.colUserId.StatusBarShortcut = null;
            this.colUserId.StatusBarShortcutComment = null;
            // 
            // colProjectDetailId
            // 
            this.colProjectDetailId.Caption = "ProjectDetailId";
            this.colProjectDetailId.FieldName = "ProjectDetailId";
            this.colProjectDetailId.Name = "colProjectDetailId";
            this.colProjectDetailId.StatusBarComment = null;
            this.colProjectDetailId.StatusBarShortcut = null;
            this.colProjectDetailId.StatusBarShortcutComment = null;
            // 
            // colCustomerId
            // 
            this.colCustomerId.Caption = "CustomerId";
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.StatusBarComment = null;
            this.colCustomerId.StatusBarShortcut = null;
            this.colCustomerId.StatusBarShortcutComment = null;
            // 
            // colCustomerSectionId
            // 
            this.colCustomerSectionId.Caption = "CustomerSectionId";
            this.colCustomerSectionId.FieldName = "CustomerSectionId";
            this.colCustomerSectionId.Name = "colCustomerSectionId";
            this.colCustomerSectionId.StatusBarComment = null;
            this.colCustomerSectionId.StatusBarShortcut = null;
            this.colCustomerSectionId.StatusBarShortcutComment = null;
            // 
            // colCustomerContactId
            // 
            this.colCustomerContactId.Caption = "CustomerContactId";
            this.colCustomerContactId.FieldName = "CustomerContactId";
            this.colCustomerContactId.Name = "colCustomerContactId";
            this.colCustomerContactId.StatusBarComment = null;
            this.colCustomerContactId.StatusBarShortcut = null;
            this.colCustomerContactId.StatusBarShortcutComment = null;
            // 
            // colRefNoOld
            // 
            this.colRefNoOld.Caption = "Eski Referans No";
            this.colRefNoOld.FieldName = "RefNoOld";
            this.colRefNoOld.Name = "colRefNoOld";
            this.colRefNoOld.StatusBarComment = null;
            this.colRefNoOld.StatusBarShortcut = null;
            this.colRefNoOld.StatusBarShortcutComment = null;
            // 
            // colRefNo
            // 
            this.colRefNo.Caption = "Referans No";
            this.colRefNo.FieldName = "RefNo";
            this.colRefNo.Name = "colRefNo";
            this.colRefNo.StatusBarComment = null;
            this.colRefNo.StatusBarShortcut = null;
            this.colRefNo.StatusBarShortcutComment = null;
            this.colRefNo.Visible = true;
            this.colRefNo.VisibleIndex = 0;
            this.colRefNo.Width = 105;
            // 
            // colPeriodYear
            // 
            this.colPeriodYear.Caption = "Proje Periyodu - YIL";
            this.colPeriodYear.FieldName = "PeriodYear";
            this.colPeriodYear.Name = "colPeriodYear";
            this.colPeriodYear.StatusBarComment = null;
            this.colPeriodYear.StatusBarShortcut = null;
            this.colPeriodYear.StatusBarShortcutComment = null;
            // 
            // colPeriodMonth
            // 
            this.colPeriodMonth.Caption = "Peroje Periyodu - AY";
            this.colPeriodMonth.FieldName = "PeriodMonth";
            this.colPeriodMonth.Name = "colPeriodMonth";
            this.colPeriodMonth.StatusBarComment = null;
            this.colPeriodMonth.StatusBarShortcut = null;
            this.colPeriodMonth.StatusBarShortcutComment = null;
            // 
            // colDateStart
            // 
            this.colDateStart.Caption = "Başlangıç Tarihi";
            this.colDateStart.FieldName = "DateStart";
            this.colDateStart.Name = "colDateStart";
            this.colDateStart.StatusBarComment = null;
            this.colDateStart.StatusBarShortcut = null;
            this.colDateStart.StatusBarShortcutComment = null;
            this.colDateStart.Visible = true;
            this.colDateStart.VisibleIndex = 7;
            this.colDateStart.Width = 117;
            // 
            // colDateEnd
            // 
            this.colDateEnd.Caption = "Bitiş Tarihi";
            this.colDateEnd.FieldName = "DateEnd";
            this.colDateEnd.Name = "colDateEnd";
            this.colDateEnd.StatusBarComment = null;
            this.colDateEnd.StatusBarShortcut = null;
            this.colDateEnd.StatusBarShortcutComment = null;
            this.colDateEnd.Visible = true;
            this.colDateEnd.VisibleIndex = 8;
            this.colDateEnd.Width = 116;
            // 
            // colNo
            // 
            this.colNo.Caption = "No";
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.StatusBarComment = null;
            this.colNo.StatusBarShortcut = null;
            this.colNo.StatusBarShortcutComment = null;
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.StatusBarComment = null;
            this.colCode.StatusBarShortcut = null;
            this.colCode.StatusBarShortcutComment = null;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 83;
            // 
            // colName
            // 
            this.colName.Caption = "Proje Adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.StatusBarComment = null;
            this.colName.StatusBarShortcut = null;
            this.colName.StatusBarShortcutComment = null;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 4;
            this.colName.Width = 170;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Müşteri";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.StatusBarComment = null;
            this.colCustomerName.StatusBarShortcut = null;
            this.colCustomerName.StatusBarShortcutComment = null;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            this.colCustomerName.Width = 243;
            // 
            // colCustomerSectionName
            // 
            this.colCustomerSectionName.Caption = "Bölüm / Fabrika";
            this.colCustomerSectionName.FieldName = "CustomerSectionName";
            this.colCustomerSectionName.Name = "colCustomerSectionName";
            this.colCustomerSectionName.StatusBarComment = null;
            this.colCustomerSectionName.StatusBarShortcut = null;
            this.colCustomerSectionName.StatusBarShortcutComment = null;
            this.colCustomerSectionName.Visible = true;
            this.colCustomerSectionName.VisibleIndex = 3;
            this.colCustomerSectionName.Width = 236;
            // 
            // colCustomerContactName
            // 
            this.colCustomerContactName.Caption = "Proje Sorumlusu";
            this.colCustomerContactName.FieldName = "CustomerContactName";
            this.colCustomerContactName.Name = "colCustomerContactName";
            this.colCustomerContactName.StatusBarComment = null;
            this.colCustomerContactName.StatusBarShortcut = null;
            this.colCustomerContactName.StatusBarShortcutComment = null;
            this.colCustomerContactName.Visible = true;
            this.colCustomerContactName.VisibleIndex = 6;
            this.colCustomerContactName.Width = 204;
            // 
            // colKeyword
            // 
            this.colKeyword.Caption = "Keyword";
            this.colKeyword.FieldName = "Keyword";
            this.colKeyword.Name = "colKeyword";
            this.colKeyword.OptionsColumn.AllowEdit = false;
            this.colKeyword.StatusBarComment = null;
            this.colKeyword.StatusBarShortcut = null;
            this.colKeyword.StatusBarShortcutComment = null;
            this.colKeyword.Visible = true;
            this.colKeyword.VisibleIndex = 9;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // ProjectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 583);
            this.Controls.Add(this.baseGrid);
            this.Name = "ProjectListForm";
            this.Text = "ProjectListForm";
            ((System.ComponentModel.ISupportInitialize)(this.baseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Common.Design.Grid.MyGridControl baseGrid;
        private Common.Design.Grid.MyGridView baseTablo;
        private Common.Design.Grid.MyGridColumn colId;
        private Common.Design.Grid.MyGridColumn colSysCode;
        private Common.Design.Grid.MyGridColumn colCreateDate;
        private Common.Design.Grid.MyGridColumn colUpdateDate;
        private Common.Design.Grid.MyGridColumn colDeleteDate;
        private Common.Design.Grid.MyGridColumn colVarStatus;
        private Common.Design.Grid.MyGridColumn colComment;
        private Common.Design.Grid.MyGridColumn colUserId;
        private Common.Design.Grid.MyGridColumn colProjectDetailId;
        private Common.Design.Grid.MyGridColumn colCustomerId;
        private Common.Design.Grid.MyGridColumn colCustomerSectionId;
        private Common.Design.Grid.MyGridColumn colCustomerContactId;
        private Common.Design.Grid.MyGridColumn colRefNoOld;
        private Common.Design.Grid.MyGridColumn colRefNo;
        private Common.Design.Grid.MyGridColumn colPeriodYear;
        private Common.Design.Grid.MyGridColumn colPeriodMonth;
        private Common.Design.Grid.MyGridColumn colDateStart;
        private Common.Design.Grid.MyGridColumn colDateEnd;
        private Common.Design.Grid.MyGridColumn colNo;
        private Common.Design.Grid.MyGridColumn colCode;
        private Common.Design.Grid.MyGridColumn colName;
        private Common.Design.Grid.MyGridColumn colCustomerName;
        private Common.Design.Grid.MyGridColumn colCustomerSectionName;
        private Common.Design.Grid.MyGridColumn colCustomerContactName;
        private Common.Design.Grid.MyGridColumn colKeyword;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}