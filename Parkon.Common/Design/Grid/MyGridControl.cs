using Prkn.Common.Design.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Drawing;

namespace Prkn.Common.Design.Grid
{
    [ToolboxItem(true)]
    public class MyGridControl : GridControl
    {
        public MyGridControl()
        {

        }
        protected override BaseView CreateDefaultView()
        {
            var view                                            = (GridView)CreateView("MyGridView");
            view.Appearance.ViewCaption.ForeColor               = Color.Maroon;
            view.Appearance.HeaderPanel.ForeColor               = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment  = HorzAlignment.Center;
            view.Appearance.FooterPanel.ForeColor               = Color.Maroon;
            view.Appearance.FooterPanel.Font                    = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);


            view.OptionsMenu.EnableColumnMenu                   = false;
            view.OptionsMenu.EnableFooterMenu                   = false;
            view.OptionsMenu.EnableGroupPanelMenu               = false;

            view.OptionsNavigation.EnterMoveNextColumn          = true;
            view.OptionsPrint.AutoWidth                         = false;
            view.OptionsPrint.PrintFooter                       = false;
            view.OptionsPrint.PrintGroupFooter                  = false;

            view.OptionsView.ShowViewCaption                    = true;
            view.OptionsView.ShowAutoFilterRow                  = true;
            view.OptionsView.ShowGroupPanel                     = false;
            view.OptionsView.ColumnAutoWidth                    = false;
            view.OptionsView.RowAutoHeight                      = true;
            view.OptionsView.HeaderFilterButtonShowMode         = FilterButtonShowMode.Button;

            var idcolumn                                        = new MyGridColumn();
            idcolumn.Caption                                    = "Id";
            idcolumn.FieldName                                  = "Id";
            idcolumn.OptionsColumn.AllowEdit                    = false;
            idcolumn.OptionsColumn.ShowInCustomizationForm      = false;

            view.Columns.Add(idcolumn);

            var SysCodeColumn = new MyGridColumn();
            SysCodeColumn.Caption                                   = "SysCode";
            SysCodeColumn.FieldName                                 = "SysCode";
            SysCodeColumn.OptionsColumn.AllowEdit                   = false;
            SysCodeColumn.AppearanceCell.TextOptions.HAlignment     = HorzAlignment.Center;
            SysCodeColumn.AppearanceCell.Options.UseTextOptions     = true;
            SysCodeColumn.Visible                                   = true;
            
            view.Columns.Add(SysCodeColumn);


            var CreateDateColumn = new MyGridColumn();
            CreateDateColumn.Caption = "Create Date";
            CreateDateColumn.FieldName = "CreateDate";
            CreateDateColumn.OptionsColumn.AllowEdit = false;
            CreateDateColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            CreateDateColumn.AppearanceCell.Options.UseTextOptions = true;
            CreateDateColumn.Visible = true;

            view.Columns.Add(CreateDateColumn);


            var UpdateDateColumn = new MyGridColumn();
            UpdateDateColumn.Caption = "Update Date";
            UpdateDateColumn.FieldName = "UpdateDate";
            UpdateDateColumn.OptionsColumn.AllowEdit = false;
            UpdateDateColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            UpdateDateColumn.AppearanceCell.Options.UseTextOptions = true;
            UpdateDateColumn.Visible = true;

            view.Columns.Add(UpdateDateColumn);

            var DeleteDateColumn = new MyGridColumn();
            DeleteDateColumn.Caption = "Delete Date";
            DeleteDateColumn.FieldName = "DeleteDate";
            DeleteDateColumn.OptionsColumn.AllowEdit = false;
            DeleteDateColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            DeleteDateColumn.AppearanceCell.Options.UseTextOptions = true;
            DeleteDateColumn.Visible = true;

            view.Columns.Add(DeleteDateColumn);

            var VarStatusColumn = new MyGridColumn();
            VarStatusColumn.Caption = "Var - Status";
            VarStatusColumn.FieldName = "VarStatus";
            VarStatusColumn.OptionsColumn.AllowEdit = false;
            VarStatusColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            VarStatusColumn.AppearanceCell.Options.UseTextOptions = true;
            VarStatusColumn.Visible = true;

            view.Columns.Add(VarStatusColumn);

            var CommentColumn = new MyGridColumn();
            CommentColumn.Caption = "Comment";
            CommentColumn.FieldName = "Comment";
            CommentColumn.OptionsColumn.AllowEdit = false;
            CommentColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            CommentColumn.AppearanceCell.Options.UseTextOptions = true;
            CommentColumn.Visible = true;

            view.Columns.Add(CommentColumn);

            return view;
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridInfoRegistrator());  //GridControl oluştuğunda myGridview gelmesi için
        }
    }

    public class MyGridInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName => "MyGridView";
        public override BaseView CreateView(GridControl grid) => new MyGridView(grid);
    }

    [ToolboxItem(true)]
    public class MyGridView : GridView, IStatusBarShortcut
    {
        #region Properties
        public string StatusBarShortcut { get; set; }
        public string StatusBarShortcutComment { get; set; }
        public string StatusBarComment { get; set; }
        #endregion

        public MyGridView()
        {

        }

        public MyGridView(GridControl ownerGrid) :base(ownerGrid) { }

        //Column içinde datetime düzgün bir şekilde kullanabilmek için
        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);

            if (column.ColumnEdit == null) return;

            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            //return base.CreateColumnCollection();

            return new MyGridColumnCollection(this);
        }

        private class MyGridColumnCollection : GridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view) { }

            protected override GridColumn CreateColumn()
            {
                var column = new MyGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }

    [ToolboxItem(true)]
    public class MyGridColumn : GridColumn, IStatusBarShortcut
    {
        #region Properties
        public string StatusBarShortcut { get; set; }
        public string StatusBarShortcutComment { get; set; }
        public string StatusBarComment { get; set; } 
        #endregion
    }

}
