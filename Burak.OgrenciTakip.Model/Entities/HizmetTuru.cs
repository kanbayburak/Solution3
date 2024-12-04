using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Attributes;
using Burak.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Burak.OgrenciTakip.Model.Entities
{
    public class HizmetTuru : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Hizmet Türü Adı", "txtHizmetTuruAdi")]
        public string HizmetTuruAdi { get; set; }

        public HizmetTipi HizmetTipi { get; set; } = HizmetTipi.Egitim;

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
