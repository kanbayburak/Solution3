using Burak.OgrenciTakip.Bll.Base;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Dto;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Burak.OgrenciTakip.Bll.General
{
    public class HizmetBll : BaseGenelBll<Hizmet>, IBaseCommonBll
    {
        public HizmetBll() : base(KartTuru.Hizmet)
        {
        }

        public HizmetBll(Control ctrl) : base(ctrl, KartTuru.Hizmet)
        {
        }

        public override BaseEntity Single(Expression<Func<Hizmet, bool>> filter)
        {
            return BaseSingle(filter, x => new HizmetS
            {
                Id = x.Id,
                Kod = x.Kod,
                HizmetAdi = x.HizmetAdi,
                HizmetTuruId = x.HizmetTuruId,
                HizmetTuruAdi = x.HizmetTuru.HizmetTuruAdi,
                BaslamaTarihi = x.BaslamaTarihi,
                BitisTarihi = x.BitisTarihi,
                Ucret = x.Ucret,
                SubeId = x.SubeId,
                DonemId = x.DonemId,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Hizmet, bool>> filter)
        {
            return BaseList(filter, x => new HizmetL
            {
                Id = x.Id,
                Kod = x.Kod,
                HizmetAdi = x.HizmetAdi,
                HizmetTuruId = x.HizmetTuruId,
                HizmetTuruAdi = x.HizmetTuru.HizmetTuruAdi,
                HizmetTipi = x.HizmetTuru.HizmetTipi,
                BaslamaTarihi = x.BaslamaTarihi,
                BitisTarihi = x.BitisTarihi,
                Ucret = x.Ucret,
                Aciklama = x.Aciklama
            })
            .OrderBy(x => x.Kod).ToList();
        }



    }
}
