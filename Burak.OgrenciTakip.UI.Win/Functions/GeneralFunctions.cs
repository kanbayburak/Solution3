using System;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Common.Messages;
using Burak.OgrenciTakip.Model.Entities.Base;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;

namespace Burak.OgrenciTakip.UI.Win.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle > -1) return (long)tablo.GetFocusedRowCellValue("Id");
            Messages.KartSecmemeUyariMesaji();
            return -1;
        }
        public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);

            if (mesajVer)
                Messages.KartSecmemeUyariMesaji();
            return default(T);
        }

        private static VeriDegisimYeri VeriDegisimYeirGetir<T>(T oldEntity, T currentEntity)
        {

            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;  //??, prop.GetValue(oldEntity) ile gelen değer null ise o zaman null değilde string.Empty olarak bu old değeri al 
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                //dikkat! bu verinin byte dizisi olup olmadığına dikkat edeceğiz.bunun için,
                //çok anlamadım ama yapılan işlem birisi byte diğerinin türü farklı, bu durumda karşılaştırma yapamayız bunun için aşağıdaki işlenmi yaptık 
                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(currentEntity.ToString()))
                        currentValue = new byte[] { 0 };
                    //2 si byte ise şimdi bu 2 alanı karşılaştıracağız
                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                        return VeriDegisimYeri.Alan;
                }
                else if (!currentValue.Equals(oldValue))
                    return VeriDegisimYeri.Alan;
            }
            return VeriDegisimYeri.VeriDegisimiYok;
        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnKaydet, BarButtonItem btnFarkliKaydet, BarButtonItem btnSil, IslemTuru islemTuru, T oldEntity, T currentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeirGetir(oldEntity, currentEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabledDurumu;
            btnFarkliKaydet.Enabled = islemTuru != IslemTuru.EntityInsert;
            btnSil.Enabled = !buttonEnabledDurumu;
        }

        internal static void ButtonEnabledDurumu(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGerial, BarButtonItem btnSil, BaseEntity oldEntity, BaseEntity currentEntity)
        {
            throw new NotImplementedException();
        }
    }
}
