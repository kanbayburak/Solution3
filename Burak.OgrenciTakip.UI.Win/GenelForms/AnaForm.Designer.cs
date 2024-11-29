namespace Burak.OgrenciTakip.UI.Win.GenelForms
{
    partial class AnaForm
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnOkulKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnIlKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAileBilgiKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnIptalNedeniKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnYabanciDilKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnTesvikKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.btnKontenjanKartlari = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnOkulKartlari,
            this.btnIlKartlari,
            this.barButtonItem2,
            this.btnAileBilgiKartlari,
            this.btnIptalNedeniKartlari,
            this.btnYabanciDilKartlari,
            this.btnTesvikKartlari,
            this.btnKontenjanKartlari});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 9;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsMenuMinWidth = 385;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.Size = new System.Drawing.Size(845, 193);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            // 
            // btnOkulKartlari
            // 
            this.btnOkulKartlari.Caption = "Okul Kartları";
            this.btnOkulKartlari.Id = 1;
            this.btnOkulKartlari.Name = "btnOkulKartlari";
            // 
            // btnIlKartlari
            // 
            this.btnIlKartlari.Caption = "İl Kartları";
            this.btnIlKartlari.Id = 2;
            this.btnIlKartlari.Name = "btnIlKartlari";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnAileBilgiKartlari
            // 
            this.btnAileBilgiKartlari.Caption = "Aile Bilgi Kartları";
            this.btnAileBilgiKartlari.Id = 4;
            this.btnAileBilgiKartlari.Name = "btnAileBilgiKartlari";
            // 
            // btnIptalNedeniKartlari
            // 
            this.btnIptalNedeniKartlari.Caption = "İptal Nedeni Kartları";
            this.btnIptalNedeniKartlari.Id = 5;
            this.btnIptalNedeniKartlari.Name = "btnIptalNedeniKartlari";
            // 
            // btnYabanciDilKartlari
            // 
            this.btnYabanciDilKartlari.Caption = "Yabancı Dil Kartları ";
            this.btnYabanciDilKartlari.Id = 6;
            this.btnYabanciDilKartlari.Name = "btnYabanciDilKartlari";
            // 
            // btnTesvikKartlari
            // 
            this.btnTesvikKartlari.Caption = "Teşvik Kartları";
            this.btnTesvikKartlari.Id = 7;
            this.btnTesvikKartlari.Name = "btnTesvikKartlari";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOkulKartlari);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnIlKartlari);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAileBilgiKartlari);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnIptalNedeniKartlari);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYabanciDilKartlari);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTesvikKartlari);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKontenjanKartlari);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 541);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(845, 30);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // btnKontenjanKartlari
            // 
            this.btnKontenjanKartlari.Caption = "Kontenjan Kartlari";
            this.btnKontenjanKartlari.Id = 8;
            this.btnKontenjanKartlari.Name = "btnKontenjanKartlari";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 571);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AnaForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "AnaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnOkulKartlari;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarButtonItem btnIlKartlari;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnAileBilgiKartlari;
        private DevExpress.XtraBars.BarButtonItem btnIptalNedeniKartlari;
        private DevExpress.XtraBars.BarButtonItem btnYabanciDilKartlari;
        private DevExpress.XtraBars.BarButtonItem btnTesvikKartlari;
        private DevExpress.XtraBars.BarButtonItem btnKontenjanKartlari;
    }
}