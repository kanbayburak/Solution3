using DevExpress.XtraBars;
using System;
using System.Windows.Forms;

namespace Burak.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BaseListForm()
        {
            InitializeComponent();
        }

        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch(item)
                {
                    case BarItem button:
                        button.ItemClick += Button_ItemClick;
                        break;
                }
            }
                

        }

        private void ShowEditForm(int v)
        {
            var result =
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            //gönder butonuna ulaşmamız için 
            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandartExcelDosyasi)
            {

            }
            else if (e.Item == btnFormatliExcelDosyasi)
            {
            }
            else if (e.Item == btnFormatsizExcelDosyasi)
            {
                
            }
            else if (e.Item == btnWordDosyasi)
            {
                
            }
            else if (e.Item == btnPdfDosyasi)
            {
                
            }
            else if (e.Item == btnTxtDosyasi)
            {
                
            }
            else if (e.Item == btnYeni)
            {
                //Yetki Kontrolü kodları yazılacak buraya 


                ShowEditForm(-1);
            }
           
        }


    }
}