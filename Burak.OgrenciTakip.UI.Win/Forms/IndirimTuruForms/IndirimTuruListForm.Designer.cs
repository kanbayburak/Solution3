﻿namespace Burak.OgrenciTakip.UI.Win.Forms.IndirimTuruForms
{
    partial class IndirimTuruListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndirimTuruListForm));
            this.myGridControl = new Burak.OgrenciTakip.UI.Win.UserControls.Grid.MyGridControl();
            this.tablo = new Burak.OgrenciTakip.UI.Win.UserControls.Grid.MyGridView();
            this.colId = new Burak.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.colKod = new Burak.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.longNavigator = new Burak.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.colIndirimTuru = new Burak.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            this.cıolAciklama = new Burak.OgrenciTakip.UI.Win.UserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // myGridControl
            // 
            this.myGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl.Location = new System.Drawing.Point(0, 135);
            this.myGridControl.MainView = this.tablo;
            this.myGridControl.MenuManager = this.ribbonControl;
            this.myGridControl.Name = "myGridControl";
            this.myGridControl.Size = new System.Drawing.Size(619, 235);
            this.myGridControl.TabIndex = 2;
            this.myGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKod,
            this.colIndirimTuru,
            this.cıolAciklama});
            this.tablo.GridControl = this.myGridControl;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "İndirim Türü Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = "F4 :";
            this.colId.StatusBarKisaYolAciklama = null;
            this.colId.Width = 94;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.MinWidth = 25;
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = "F4 :";
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 120;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 370);
            this.longNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(619, 30);
            this.longNavigator.TabIndex = 3;
            // 
            // colIndirimTuru
            // 
            this.colIndirimTuru.Caption = "İndirim Türü";
            this.colIndirimTuru.FieldName = "IndirimTuruAdi";
            this.colIndirimTuru.MinWidth = 25;
            this.colIndirimTuru.Name = "colIndirimTuru";
            this.colIndirimTuru.OptionsColumn.AllowEdit = false;
            this.colIndirimTuru.StatusBarAciklama = null;
            this.colIndirimTuru.StatusBarKisaYol = "F4 :";
            this.colIndirimTuru.StatusBarKisaYolAciklama = null;
            this.colIndirimTuru.Visible = true;
            this.colIndirimTuru.VisibleIndex = 1;
            this.colIndirimTuru.Width = 250;
            // 
            // cıolAciklama
            // 
            this.cıolAciklama.Caption = "Açıklama";
            this.cıolAciklama.FieldName = "Aciklama";
            this.cıolAciklama.MinWidth = 25;
            this.cıolAciklama.Name = "cıolAciklama";
            this.cıolAciklama.OptionsColumn.AllowEdit = false;
            this.cıolAciklama.StatusBarAciklama = null;
            this.cıolAciklama.StatusBarKisaYol = "F4 :";
            this.cıolAciklama.StatusBarKisaYolAciklama = null;
            this.cıolAciklama.Visible = true;
            this.cıolAciklama.VisibleIndex = 2;
            this.cıolAciklama.Width = 450;
            // 
            // IndirimTuruListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 430);
            this.Controls.Add(this.myGridControl);
            this.Controls.Add(this.longNavigator);
            this.Name = "IndirimTuruListForm";
            this.Text = "İndirim Türü Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.myGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grid.MyGridControl myGridControl;
        private UserControls.Grid.MyGridView tablo;
        private UserControls.Grid.MyGridColumn colId;
        private UserControls.Grid.MyGridColumn colKod;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyGridColumn colIndirimTuru;
        private UserControls.Grid.MyGridColumn cıolAciklama;
    }
}