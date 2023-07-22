namespace Emikon.Parkon.UI.Win.Forms.Store
{
    partial class StoreLocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreLocationForm));
            ((System.ComponentModel.ISupportInitialize)(this.DataLayoutControl)).BeginInit();
            this.DataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseSplitContainer)).BeginInit();
            this.BaseSplitContainer.Panel1.SuspendLayout();
            this.BaseSplitContainer.SuspendLayout();
            this.baseLongNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // DataLayoutControl
            // 
            this.DataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.DataLayoutControl.Controls.SetChildIndex(this.txtName, 0);
            this.DataLayoutControl.Controls.SetChildIndex(this.txtCode, 0);
            this.DataLayoutControl.Controls.SetChildIndex(this.txtComment, 0);
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
            // 
            // BaseSplitContainer
            // 
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
            this.ribbonControlList.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // txtCode
            // 
            this.txtCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtName.TabIndex = 0;
            // 
            // txtComment
            // 
            this.txtComment.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtComment.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtComment.TabIndex = 2;
            // 
            // StoreLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 487);
            this.IconOptions.ShowIcon = false;
            this.Name = "StoreLocationForm";
            this.Text = "StoreLocationForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataLayoutControl)).EndInit();
            this.DataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.BaseSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaseSplitContainer)).EndInit();
            this.BaseSplitContainer.ResumeLayout(false);
            this.baseLongNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}