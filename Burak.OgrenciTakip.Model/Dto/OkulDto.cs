using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak.OgrenciTakip.Model.Dto
{
    /*[NotMapped]*/ //OkulS i database edahil etmiyor bu yapmamızın nedeni IlAdi ve IlceAdi gözükmesini istemiyoruz database deki Okul ksımında 

    //OkulS sınıfı, bir okulun tüm detaylarını, il ve ilçe adlarını içeren bir veri transfer objesidir. Bu sınıf, okulun detay bilgilerini almak için kullanılır.
    public class OkulS : Okul  //OkulS deki S select anlamında birde OkulL var oda okul listesi demek 
    {
        //okul entitysinden implamente edildi base>okulda ilid var il adı yok bunun oluşması için datatransform oluşturuyoruz
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
    }

    //OkulL sınıfı, temel okul bilgilerini içeren ve listeleme işlemleri için optimize edilmiş bir veri transfer objesidir.Bu sınıf, okul listesini görüntülemek için kullanılır.
    public class OkulL : BaseEntity  //sadece id ve kod id ler lazım o yüzden BaseEntity kullandık 
    {
        public string OkulAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Aciklama { get; set; }
    }
}


//OkulS ADINDA (Dto) dataTransform OBJECT DENİYOR 
