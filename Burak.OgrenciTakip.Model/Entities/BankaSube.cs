using Burak.OgrenciTakip.Model.Attributes;
using Burak.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Burak.OgrenciTakip.Model.Entities
{
    public class BankaSube : BaseEntityDurum
    {

            [Index("IX_Kod", IsUnique = false)]
            public override string Kod { get; set; }
            [Required, StringLength(50), ZorunluAlan("Şube Adı", "txtSubeAdi")]
            public string SubeAdi { get; set; }
            public long BankaId { get; set; }
            [StringLength(500)]
            public string Aciklama { get; set; }
            public Banka Banka { get; set; }
    }
}
