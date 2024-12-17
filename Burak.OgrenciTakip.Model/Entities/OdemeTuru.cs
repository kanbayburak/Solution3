using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Attributes;
using Burak.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Burak.OgrenciTakip.Model.Entities
{
    public class OdemeTuru : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Ödeme Türü Adı", "txtOdemeTuruAdi")]
        public string OdemeTuruAdi { get; set; }

        public OdemeTipi OdemeTipi { get; set; } = OdemeTipi.Elden;   //Elden seçili bir şekilde gelecek

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
