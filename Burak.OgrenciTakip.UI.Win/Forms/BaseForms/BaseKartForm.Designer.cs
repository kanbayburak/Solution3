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
            DevExpress.Utils.SuperToolTip superToolTip21 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem21 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem21 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip22 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem22 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem22 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip23 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem23 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem23 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip24 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem24 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem24 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip25 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem25 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem25 = new DevExpress.Utils.ToolTipItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(684, 109);
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
            toolTipTitleItem21.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem21.Text = "(Ctrl+Insert)";
            toolTipItem21.Text = "Yeni Kart";
            superToolTip21.Items.Add(toolTipTitleItem21);
            superToolTip21.Items.Add(toolTipItem21);
            this.btnYeni.SuperTip = superToolTip21;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 2;
            this.btnKaydet.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.save_16x16;
            this.btnKaydet.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.save_32x32;
            this.btnKaydet.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnKaydet.Name = "btnKaydet";
            toolTipTitleItem22.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem22.Text = "(F2)";
            toolTipItem22.Text = "Kaydet";
            superToolTip22.Items.Add(toolTipTitleItem22);
            superToolTip22.Items.Add(toolTipItem22);
            this.btnKaydet.SuperTip = superToolTip22;
            // 
            // btnGerial
            // 
            this.btnGerial.Caption = "Gerial";
            this.btnGerial.Id = 3;
            this.btnGerial.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.reset_16x16;
            this.btnGerial.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.reset_32x32;
            this.btnGerial.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.btnGerial.Name = "btnGerial";
            toolTipTitleItem23.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem23.Text = "(Ctrl+Z)";
            toolTipItem23.Text = "Geri Al";
            superToolTip23.Items.Add(toolTipTitleItem23);
            superToolTip23.Items.Add(toolTipItem23);
            this.btnGerial.SuperTip = superToolTip23;
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 4;
            this.btnSil.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.deletelist_16x16;
            this.btnSil.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.deletelist_32x32;
            this.btnSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete));
            this.btnSil.Name = "btnSil";
            toolTipTitleItem24.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem24.Text = "(Ctrl+Delete)";
            toolTipItem24.Text = "Sil";
            superToolTip24.Items.Add(toolTipTitleItem24);
            superToolTip24.Items.Add(toolTipItem24);
            this.btnSil.SuperTip = superToolTip24;
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "Çıkış";
            this.btnCikis.Id = 5;
            this.btnCikis.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.close_16x16;
            this.btnCikis.ImageOptions.LargeImage = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.close_32x32;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ShortcutKeyDisplayString = "Esc";
            toolTipTitleItem25.ImageOptions.Image = global::Burak.OgrenciTakip.UI.Win.Properties.Resources.comment_16x16;
            toolTipTitleItem25.Text = "(Esc)";
            toolTipItem25.Text = "Çıkış";
            superToolTip25.Items.Add(toolTipTitleItem25);
            superToolTip25.Items.Add(toolTipItem25);
            this.btnCikis.SuperTip = superToolTip25;
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
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 383);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(684, 24);
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
            this.ClientSize = new System.Drawing.Size(684, 407);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.MinimizeBox = false;
            this.Name = "BaseKartForm";
            this.Ribbon = this.ribbonControl1;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar1;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
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
    }
}