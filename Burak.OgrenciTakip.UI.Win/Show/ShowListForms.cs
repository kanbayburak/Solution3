﻿using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities.Base;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using System;
using System.Windows.Forms;

namespace Burak.OgrenciTakip.UI.Win.Show
{
    public class ShowListForms<TForm> where TForm : BaseListForm
    {
        public static void ShowListForm(KartTuru kartTuru)
        {
            //yetki kontrolü gelecek 

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }
        public static void ShowListForm(KartTuru kartTuru, params object[] prm)
        {
            //yetki kontrolü gelecek 

            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }
        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
        {
            //yetki kontrolleri olacak 

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.SeciliGelecekId = seciliGelecekId;
                frm.Yukle();
                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
            }
        }
    }
}
