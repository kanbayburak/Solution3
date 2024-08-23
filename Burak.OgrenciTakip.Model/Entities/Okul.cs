using Burak.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak.OgrenciTakip.Model.Entities
{
    public class Okul : BaseEntityDurum
    {
        //[Index("IX_Kod", IsUnique = true)]
       /* public override string Kod { get; set; } */  //`BaseEntity` sınıfındaki `Kod` özelliği, miras alınan sınıflarda değiştirilebilmesi için `virtual` yapılmıştır. `Okul` sınıfı bu özelliği kendi özelinde kullanmak için `override` ederek özelleştirmiştir.

        //[Required, StringLength(50), ZorunluAlan("Okul Adi", "txtOkulAdi")]
        public string OkulAdi { get; set; }

        //[ZorunluAlan("İl Adi", "txtIl")]
        public long IlId { get; set; }

        //[ZorunluAlan("İlÇe Adi", "txtIlce")]
        public long IlceId { get; set; }

        //[StringLength(500)]
        public string Aciklama { get; set; }

        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
    }
}
