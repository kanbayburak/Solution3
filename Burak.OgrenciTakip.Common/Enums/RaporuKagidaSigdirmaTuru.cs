using System;
using System.ComponentModel;

namespace Burak.OgrenciTakip.Common.Enums
{
    public enum RaporuKagidaSigdirmaTuru: byte
    {
        [Description("Sütunları Daraltarak Sığdır")]
        SutunlariDaraltarakSigdir =1,
        [Description("YazıBoyutunu Küçülterek Sığdır")]
        YaziBoyutunuKuculterekSigdir =2,
        [Description("İşlem Yapma")]
        IslemYapma =3,
    }
}
