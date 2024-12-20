﻿using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Burak.OgrenciTakip.Model.Dto
{
    [NotMapped]  
    public class HizmetS : Hizmet
    {
        public string HizmetTuruAdi { get; set; }
    }

    public class HizmetL : BaseEntity
    {
        public string HizmetAdi { get; set; }
        public long HizmetTuruId { get; set; }
        public string HizmetTuruAdi { get; set; }
        public HizmetTipi HizmetTipi { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public decimal Ucret { get; set; }
        public string Aciklama { get; set; }

    }
}
