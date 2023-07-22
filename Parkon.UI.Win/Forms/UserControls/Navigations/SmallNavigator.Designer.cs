﻿namespace Emikon.Parkon.UI.Win.Forms.UserControls.Navigations
{
    partial class SmallNavigator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmallNavigator));
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.Navigator = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertImage(global::Emikon.Parkon.UI.Win.Properties.Resources.doublefirst_16x16, "doublefirst_16x16", typeof(global::Emikon.Parkon.UI.Win.Properties.Resources), 0);
            this.imageCollection.Images.SetKeyName(0, "doublefirst_16x16");
            this.imageCollection.InsertImage(global::Emikon.Parkon.UI.Win.Properties.Resources.doubleprev_16x16, "doubleprev_16x16", typeof(global::Emikon.Parkon.UI.Win.Properties.Resources), 1);
            this.imageCollection.Images.SetKeyName(1, "doubleprev_16x16");
            this.imageCollection.InsertImage(global::Emikon.Parkon.UI.Win.Properties.Resources.first_16x16, "first_16x16", typeof(global::Emikon.Parkon.UI.Win.Properties.Resources), 2);
            this.imageCollection.Images.SetKeyName(2, "first_16x16");
            this.imageCollection.InsertImage(global::Emikon.Parkon.UI.Win.Properties.Resources.prev_16x16, "prev_16x16", typeof(global::Emikon.Parkon.UI.Win.Properties.Resources), 3);
            this.imageCollection.Images.SetKeyName(3, "prev_16x16");
            this.imageCollection.InsertImage(global::Emikon.Parkon.UI.Win.Properties.Resources.next_16x16, "next_16x16", typeof(global::Emikon.Parkon.UI.Win.Properties.Resources), 4);
            this.imageCollection.Images.SetKeyName(4, "next_16x16");
            this.imageCollection.InsertImage(global::Emikon.Parkon.UI.Win.Properties.Resources.last_16x16, "last_16x16", typeof(global::Emikon.Parkon.UI.Win.Properties.Resources), 5);
            this.imageCollection.Images.SetKeyName(5, "last_16x16");
            this.imageCollection.InsertImage(global::Emikon.Parkon.UI.Win.Properties.Resources.doublenext_16x16, "doublenext_16x16", typeof(global::Emikon.Parkon.UI.Win.Properties.Resources), 6);
            this.imageCollection.Images.SetKeyName(6, "doublenext_16x16");
            this.imageCollection.InsertImage(global::Emikon.Parkon.UI.Win.Properties.Resources.doublelast_16x16, "doublelast_16x16", typeof(global::Emikon.Parkon.UI.Win.Properties.Resources), 7);
            this.imageCollection.Images.SetKeyName(7, "doublelast_16x16");
            this.imageCollection.InsertImage(global::Emikon.Parkon.UI.Win.Properties.Resources.addfile_16x16, "addfile_16x16", typeof(global::Emikon.Parkon.UI.Win.Properties.Resources), 8);
            this.imageCollection.Images.SetKeyName(8, "addfile_16x16");
            this.imageCollection.InsertImage(global::Emikon.Parkon.UI.Win.Properties.Resources.deletelist_16x16, "deletelist_16x16", typeof(global::Emikon.Parkon.UI.Win.Properties.Resources), 9);
            this.imageCollection.Images.SetKeyName(9, "deletelist_16x16");
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
            this.Navigator.Buttons.ImageList = this.imageCollection;
            this.Navigator.Buttons.Last.ImageIndex = 5;
            this.Navigator.Buttons.Next.ImageIndex = 4;
            this.Navigator.Buttons.NextPage.ImageIndex = 6;
            this.Navigator.Buttons.NextPage.Visible = false;
            this.Navigator.Buttons.Prev.ImageIndex = 3;
            this.Navigator.Buttons.PrevPage.ImageIndex = 1;
            this.Navigator.Buttons.PrevPage.Visible = false;
            this.Navigator.Buttons.Remove.ImageIndex = 9;
            this.Navigator.Buttons.Remove.Visible = false;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Location = new System.Drawing.Point(0, 0);
            this.Navigator.Name = "Navigator";
            this.Navigator.Size = new System.Drawing.Size(442, 24);
            this.Navigator.TabIndex = 2;
            this.Navigator.Text = "controlNavigator1";
            this.Navigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.Navigator.TextStringFormat = "Veri ( {0} / {1} )";
            // 
            // SmallNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigator);
            this.Name = "SmallNavigator";
            this.Size = new System.Drawing.Size(442, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection;
        public DevExpress.XtraEditors.ControlNavigator Navigator;
    }
}
