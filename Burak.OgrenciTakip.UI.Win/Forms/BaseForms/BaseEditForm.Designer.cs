namespace Burak.OgrenciTakip.UI.Win.Forms.BaseForms
{
    partial class BaseEditForm
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
            DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem11 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem11 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem12 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem12 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip13 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem13 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem13 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip14 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem14 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem14 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip15 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem15 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem15 = new DevExpress.Utils.ToolTipItem();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnYeni,
            this.btnKaydet,
            this.btnGerial,
            this.btnSil,
            this.btnCikis,
            this.statusBarAciklama,
            this.statusaBarKisaYol,
            this.statusBarKisaYolAciklama});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 9;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(845, 109);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl.Click += new System.EventHandler(this.ribbonControl_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Caption = "Yeni";
            this.btnYeni.Id = 1;
            this.btnYeni.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.addfile_16x16;
            this.btnYeni.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.addfile_32x32;
            this.btnYeni.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert));
            this.btnYeni.Name = "btnYeni";
            toolTipTitleItem11.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem11.Text = "(Ctrl+Insert)";
            toolTipItem11.Text = "Yeni Kart";
            superToolTip11.Items.Add(toolTipTitleItem11);
            superToolTip11.Items.Add(toolTipItem11);
            this.btnYeni.SuperTip = superToolTip11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 2;
            this.btnKaydet.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.save_16x16;
            this.btnKaydet.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.save_32x32;
            this.btnKaydet.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnKaydet.Name = "btnKaydet";
            toolTipTitleItem12.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem12.Text = "(F2)";
            toolTipItem12.Text = "Kaydet";
            superToolTip12.Items.Add(toolTipTitleItem12);
            superToolTip12.Items.Add(toolTipItem12);
            this.btnKaydet.SuperTip = superToolTip12;
            // 
            // btnGerial
            // 
            this.btnGerial.Caption = "Gerial";
            this.btnGerial.Id = 3;
            this.btnGerial.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.reset_16x16;
            this.btnGerial.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.reset_32x32;
            this.btnGerial.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.btnGerial.Name = "btnGerial";
            toolTipTitleItem13.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem13.Text = "(Ctrl+Z)";
            toolTipItem13.Text = "Geri Al";
            superToolTip13.Items.Add(toolTipTitleItem13);
            superToolTip13.Items.Add(toolTipItem13);
            this.btnGerial.SuperTip = superToolTip13;
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 4;
            this.btnSil.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.deletelist_16x16;
            this.btnSil.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.deletelist_32x32;
            this.btnSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete));
            this.btnSil.Name = "btnSil";
            toolTipTitleItem14.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem14.Text = "(Ctrl+Delete)";
            toolTipItem14.Text = "Sil";
            superToolTip14.Items.Add(toolTipTitleItem14);
            superToolTip14.Items.Add(toolTipItem14);
            this.btnSil.SuperTip = superToolTip14;
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "Çıkış";
            this.btnCikis.Id = 5;
            this.btnCikis.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.close_16x16;
            this.btnCikis.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.close_32x32;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ShortcutKeyDisplayString = "Esc";
            toolTipTitleItem15.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem15.Text = "(Esc)";
            toolTipItem15.Text = "Çıkış";
            superToolTip15.Items.Add(toolTipTitleItem15);
            superToolTip15.Items.Add(toolTipItem15);
            this.btnCikis.SuperTip = superToolTip15;
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
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(845, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // BaseKartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 506);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.MinimizeBox = false;
            this.Name = "BaseKartForm";
            this.Ribbon = this.ribbonControl;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar1;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
    }
}