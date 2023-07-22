using Emikon.Parkon.UI.Win.Forms.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
using System.Drawing;


namespace Emikon.Parkon.UI.Win.Forms.UserControls.Grid
{
    [ToolboxItem(true)]
    public class MyBandedGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (MyBandedGridView)CreateView("MyBandedGridView");

            view.Appearance.BandPanel.ForeColor = Color.DarkBlue;
            view.Appearance.BandPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            view.Appearance.BandPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.BandPanelRowHeight = 30;

            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;
            view.OptionsNavigation.EnterMoveNextColumn = true;
            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;


            var Idcolumn = new BandedGridColumn
            {
                Caption                 = "Id",
                FieldName               = "Id"
            };
            Idcolumn.OptionsColumn.AllowEdit                = false;
            Idcolumn.OptionsColumn.ShowInCustomizationForm  = false;
            view.Columns.Add(Idcolumn);

            var SysCodecolumn = new BandedGridColumn
            {
                Caption                 = "SysCode",
                FieldName               = "SysCode"
            };
            SysCodecolumn.OptionsColumn.AllowEdit = false;
            SysCodecolumn.OptionsColumn.ShowInCustomizationForm = false;
            SysCodecolumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            SysCodecolumn.AppearanceCell.Options.UseTextOptions = true;
            SysCodecolumn.Visible = true;
            view.Columns.Add(SysCodecolumn);


            var CreateDatecolumn = new BandedGridColumn
            {
                Caption = "Create Date",
                FieldName = "CreateDate"
            };
            CreateDatecolumn.OptionsColumn.AllowEdit = false;
            CreateDatecolumn.OptionsColumn.ShowInCustomizationForm = false;
            CreateDatecolumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            CreateDatecolumn.AppearanceCell.Options.UseTextOptions = true;
            CreateDatecolumn.Visible = true;
            view.Columns.Add(CreateDatecolumn);

            var UpdateDatecolumn = new BandedGridColumn
            {
                Caption = "Update Date",
                FieldName = "UpdateDate"
            };
            UpdateDatecolumn.OptionsColumn.AllowEdit = false;
            UpdateDatecolumn.OptionsColumn.ShowInCustomizationForm = false;
            UpdateDatecolumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            UpdateDatecolumn.AppearanceCell.Options.UseTextOptions = true;
            UpdateDatecolumn.Visible = true;
            view.Columns.Add(UpdateDatecolumn);

            var DeleteDatecolumn = new BandedGridColumn
            {
                Caption = "Delete Date",
                FieldName = "DeleteDate"
            };
            DeleteDatecolumn.OptionsColumn.AllowEdit = false;
            DeleteDatecolumn.OptionsColumn.ShowInCustomizationForm = false;
            DeleteDatecolumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            DeleteDatecolumn.AppearanceCell.Options.UseTextOptions = true;
            DeleteDatecolumn.Visible = true;
            view.Columns.Add(DeleteDatecolumn);

            var VarStatuscolumn = new BandedGridColumn
            {
                Caption = "Var - Status",
                FieldName = "VarStatus"
            };
            VarStatuscolumn.OptionsColumn.AllowEdit = false;
            VarStatuscolumn.OptionsColumn.ShowInCustomizationForm = false;
            VarStatuscolumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            VarStatuscolumn.AppearanceCell.Options.UseTextOptions = true;
            VarStatuscolumn.Visible = true;
            view.Columns.Add(VarStatuscolumn);

            var Commentcolumn = new BandedGridColumn
            {
                Caption = "Comment",
                FieldName = "Comment"
            };
            Commentcolumn.OptionsColumn.AllowEdit = false;
            Commentcolumn.OptionsColumn.ShowInCustomizationForm = false;
            Commentcolumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            Commentcolumn.AppearanceCell.Options.UseTextOptions = true;
            Commentcolumn.Visible = true;
            view.Columns.Add(Commentcolumn);

            return view;
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyBandedGridInfoRegistrator());
        }
        public class MyBandedGridInfoRegistrator : BandedGridInfoRegistrator
        {
            public override string ViewName => "MyBandedGridView";
            public override BaseView CreateView(GridControl grid) => new MyBandedGridView(grid);
        }
    }

    public class MyBandedGridView : BandedGridView, IStatusBarShortcut
    {
        #region Properties
        public string StatusBarShortcut { get; set; }
        public string StatusBarShortcutComment { get; set; }
        public string StatusBarComment { get; set; }

        #endregion    }

        public MyBandedGridView()
        {

        }
        public MyBandedGridView(GridControl ownerGrid) : base(ownerGrid)
        {
        }
        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);

            if (column.ColumnEdit == null) return;
            if(column.ColumnEdit.GetType() == typeof( RepositoryItemDateEdit) )
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }
        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyColumnCollection(this);   
        }
        public class MyColumnCollection : BandedGridColumnCollection
        {
            public MyColumnCollection(ColumnView view) : base(view)
            {
            }
            protected override GridColumn CreateColumn()
            {
                var column = new MyBandedGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }

    public class MyBandedGridColumn : BandedGridColumn, IStatusBarShortcut
    {
        #region Properties
        public string StatusBarShortcut { get; set; }
        public string StatusBarShortcutComment { get; set; }
        public string StatusBarComment { get; set; }

        #endregion
    }


    }
