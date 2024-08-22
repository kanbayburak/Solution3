namespace Burak.OgrenciTakip.UI.Win.Forms.BaseForms
{
    partial class BaseKartForm
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnYeni = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnGerial = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.statusBarAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.statusaBarKisaYol = new DevExpress.XtraBars.BarStaticItem();
            this.statusBarKisaYolAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.myBandedGridControl1 = new Burak.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.myBandedGridView1 = new Burak.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBandedGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnYeni,
            this.btnKaydet,
            this.btnGerial,
            this.btnSil,
            this.btnCikis,
            this.statusBarAciklama,
            this.statusaBarKisaYol,
            this.statusBarKisaYolAciklama});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(845, 109);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnYeni
            // 
            this.btnYeni.Caption = "Yeni";
            this.btnYeni.Id = 1;
            this.btnYeni.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.addfile_16x16;
            this.btnYeni.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.addfile_32x32;
            this.btnYeni.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert));
            this.btnYeni.Name = "btnYeni";
            toolTipTitleItem1.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem1.Text = "(Ctrl+Insert)";
            toolTipItem1.Text = "Yeni Kart";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnYeni.SuperTip = superToolTip1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 2;
            this.btnKaydet.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.save_16x16;
            this.btnKaydet.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.save_32x32;
            this.btnKaydet.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnKaydet.Name = "btnKaydet";
            toolTipTitleItem2.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem2.Text = "(F2)";
            toolTipItem2.Text = "Kaydet";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.btnKaydet.SuperTip = superToolTip2;
            // 
            // btnGerial
            // 
            this.btnGerial.Caption = "Gerial";
            this.btnGerial.Id = 3;
            this.btnGerial.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.reset_16x16;
            this.btnGerial.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.reset_32x32;
            this.btnGerial.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.btnGerial.Name = "btnGerial";
            toolTipTitleItem3.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem3.Text = "(Ctrl+Z)";
            toolTipItem3.Text = "Geri Al";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.btnGerial.SuperTip = superToolTip3;
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 4;
            this.btnSil.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.deletelist_16x16;
            this.btnSil.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.deletelist_32x32;
            this.btnSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete));
            this.btnSil.Name = "btnSil";
            toolTipTitleItem4.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem4.Text = "(Ctrl+Delete)";
            toolTipItem4.Text = "Sil";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.btnSil.SuperTip = superToolTip4;
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "Çıkış";
            this.btnCikis.Id = 5;
            this.btnCikis.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.close_16x16;
            this.btnCikis.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.close_32x32;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ShortcutKeyDisplayString = "Esc";
            toolTipTitleItem5.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem5.Text = "(Esc)";
            toolTipItem5.Text = "Çıkış";
            superToolTip5.Items.Add(toolTipTitleItem5);
            superToolTip5.Items.Add(toolTipItem5);
            this.btnCikis.SuperTip = superToolTip5;
            // 
            // statusBarAciklama
            // 
            this.statusBarAciklama.Id = 6;
            this.statusBarAciklama.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.suggestion_16x16;
            this.statusBarAciklama.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.suggestion_32x32;
            this.statusBarAciklama.Name = "statusBarAciklama";
            this.statusBarAciklama.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // statusaBarKisaYol
            // 
            this.statusaBarKisaYol.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.statusaBarKisaYol.Id = 7;
            this.statusaBarKisaYol.Name = "statusaBarKisaYol";
            // 
            // statusBarKisaYolAciklama
            // 
            this.statusBarKisaYolAciklama.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.statusBarKisaYolAciklama.Id = 8;
            this.statusBarKisaYolAciklama.Name = "statusBarKisaYolAciklama";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYeni);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaydet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGerial);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.statusBarAciklama);
            this.ribbonStatusBar1.ItemLinks.Add(this.statusaBarKisaYol);
            this.ribbonStatusBar1.ItemLinks.Add(this.statusBarKisaYolAciklama);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 482);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(845, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // myBandedGridControl1
            // 
            this.myBandedGridControl1.Location = new System.Drawing.Point(147, 141);
            this.myBandedGridControl1.MainView = this.myBandedGridView1;
            this.myBandedGridControl1.MenuManager = this.ribbonControl1;
            this.myBandedGridControl1.Name = "myBandedGridControl1";
            this.myBandedGridControl1.Size = new System.Drawing.Size(400, 200);
            this.myBandedGridControl1.TabIndex = 2;
            this.myBandedGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myBandedGridView1});
            // 
            // myBandedGridView1
            // 
            this.myBandedGridView1.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.myBandedGridView1.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.myBandedGridView1.Appearance.BandPanel.Options.UseFont = true;
            this.myBandedGridView1.Appearance.BandPanel.Options.UseForeColor = true;
            this.myBandedGridView1.Appearance.BandPanel.Options.UseTextOptions = true;
            this.myBandedGridView1.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myBandedGridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.myBandedGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myBandedGridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.myBandedGridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.myBandedGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myBandedGridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.myBandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.myBandedGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myBandedGridView1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.myBandedGridView1.Appearance.ViewCaption.Options.UseForeColor = true;
            this.myBandedGridView1.BandPanelRowHeight = 40;
            this.myBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.myBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod});
            this.myBandedGridView1.GridControl = this.myBandedGridControl1;
            this.myBandedGridView1.Name = "myBandedGridView1";
            this.myBandedGridView1.OptionsMenu.EnableColumnMenu = false;
            this.myBandedGridView1.OptionsMenu.EnableFooterMenu = false;
            this.myBandedGridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myBandedGridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.myBandedGridView1.OptionsPrint.AutoWidth = false;
            this.myBandedGridView1.OptionsPrint.PrintFooter = false;
            this.myBandedGridView1.OptionsPrint.PrintGroupFooter = false;
            this.myBandedGridView1.OptionsView.ColumnAutoWidth = false;
            this.myBandedGridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.myBandedGridView1.OptionsView.RowAutoHeight = true;
            this.myBandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.myBandedGridView1.OptionsView.ShowGroupPanel = false;
            this.myBandedGridView1.OptionsView.ShowViewCaption = true;
            this.myBandedGridView1.StatusBarAciklama = null;
            this.myBandedGridView1.StatusBarKisaYol = null;
            this.myBandedGridView1.StatusBarKisaYolAciklama = null;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.Visible = true;
            // 
            // BaseKartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 506);
            this.Controls.Add(this.myBandedGridControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.MinimizeBox = false;
            this.Name = "BaseKartForm";
            this.Ribbon = this.ribbonControl1;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar1;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBandedGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBandedGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnYeni;
        private DevExpress.XtraBars.BarButtonItem btnKaydet;
        private DevExpress.XtraBars.BarButtonItem btnGerial;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
        private DevExpress.XtraBars.BarStaticItem statusBarAciklama;
        private DevExpress.XtraBars.BarStaticItem statusaBarKisaYol;
        private DevExpress.XtraBars.BarStaticItem statusBarKisaYolAciklama;
        private UserControls.Grid.MyBandedGridControl myBandedGridControl1;
        private UserControls.Grid.MyBandedGridView myBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
    }
}