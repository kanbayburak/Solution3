﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Burak.OgrenciTakip.Bll.Base;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Dto;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.Model.Entities.Base;

namespace Burak.OgrenciTakip.Bll.General
{
    public class AvukatBll : BaseGenelBll<Avukat>, IBaseGenelBll, IBaseCommonBll
    {
        public AvukatBll() : base(KartTuru.Avukat)
        {
        }

        public AvukatBll(Control ctrl) : base(ctrl, KartTuru.Avukat)
        {
        }
        public override BaseEntity Single(Expression<Func<Avukat, bool>> filter)
        {
            return BaseSingle(filter, x => new AvukatS
            {
                Id = x.Id,
                Kod = x.Kod,
                AdiSoyadi = x.AdiSoyadi,
                SozlesmeNo = x.SozlesmeNo,
                SozlesmeBaslamaTarihi =x.SozlesmeBaslamaTarihi,
                SozlesmeBitisTarihi = x.SozlesmeBitisTarihi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Avukat, bool>> filter)
        {
            return BaseList(filter, x => new AvukatL
            {
                Id = x.Id,
                Kod = x.Kod,
                AdiSoyadi = x.AdiSoyadi,
                SozlesmeNo = x.SozlesmeNo,
                SozlesmeBaslamaTarihi = x.SozlesmeBaslamaTarihi,
                SozlesmeBitisTarihi = x.SozlesmeBitisTarihi,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama
            })
            .OrderBy(x => x.Kod).ToList();
        }
    }
}
