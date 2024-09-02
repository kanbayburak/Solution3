using Burak.OgrenciTakip.Model.Attributes;
using Burak.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak.OgrenciTakip.Model.Entities
{
    public class Il : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; } //`BaseEntity` sınıfındaki `Kod` özelliği, miras alınan sınıflarda değiştirilebilmesi için `virtual` yapılmıştır. `Il` sınıfı bu özelliği kendi özelinde kullanmak için `override` ederek özelleştirmiştir.

        [Required, StringLength(50), ZorunluAlan("İl Adi", "txtIlAdi")]
        public string IlAdi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }

        public ICollection<Ilce> Ilce { get; set; } //İle bağlı ilçeleri ICollection ile ulaşabiliriz 
    }
}
