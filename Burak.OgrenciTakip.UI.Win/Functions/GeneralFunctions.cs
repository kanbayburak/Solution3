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
            var veriDegisimYeri = VeriDegisimYeirGetir(oldEntity, currentEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabledDurumu;
            btnGerial.Enabled = buttonEnabledDurumu;
            btnYeni.Enabled = !buttonEnabledDurumu;
            btnSil.Enabled = !buttonEnabledDurumu;
        }

        public static long IdOlustur(this IslemTuru islemTuru, BaseEntity selectedEntity)
        {
            //2017 12 30 18 04 23 55 654
            string SifirEkle(string deger)
            {
                if (deger.Length == 1)
                {
                    return "0" + deger;
                }
                return deger;
            }

            string UcBasamakYap(string deger)
            {
                switch (deger.Length)
                {
                    case 1:
                        return "00" + deger;
                    case 2:
                        return "0" + deger;
                }
                return deger;
            }


            string Id()
            {
                var yil = DateTime.Now.Date.Year.ToString();
                var ay = SifirEkle(DateTime.Now.Date.Month.ToString());
                var gun = SifirEkle(DateTime.Now.Date.Day.ToString());
                var saat = SifirEkle(DateTime.Now.Hour.ToString());
                var dakika = SifirEkle(DateTime.Now.Minute.ToString());
                var saniye = SifirEkle(DateTime.Now.Second.ToString());
                var milisaniye = UcBasamakYap(DateTime.Now.Millisecond.ToString());
                var random = SifirEkle(new Random().Next(0, 99).ToString());

                return yil + ay + gun + saat + dakika + saniye + milisaniye + random;
            }
            var id = Id();
            return islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(Id()); //parse üret ve ıd ye gönder demek 
        }
    }
}
