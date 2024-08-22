using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyKodTextEdit : MyTextEdit
    {
        public MyKodTextEdit()
        {
            //Focuslandığı zaman arka plan rengini MyTextEdit den alacak

            //sabit bir backcolor vereceğiz
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;

            //kod giriş alanını sınırlandırmamız lazım
            Properties.MaxLength = 20;

            StatusBarAciklama = "Kod Giriniz.";
        }
    }
}
