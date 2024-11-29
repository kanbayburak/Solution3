using Burak.OgrenciTakip.Model.Attributes;
using Burak.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Burak.OgrenciTakip.Model.Entities
{
    public class Yakinlik : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Yakınlık Adı", "txtYakinlikAdi")]
        public string YakinlikAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
