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
    public class OkulBll: BaseGenelBll<Okul>, IBaseGenelBll, IBaseCommonBll
    {
        public OkulBll() : base(KartTuru.Okul) { }

        public OkulBll(Control ctrl) : base(ctrl, KartTuru.Okul) { }


        public override BaseEntity Single(Expression<Func<Okul, bool>> filter)
        {
            return BaseSingle(filter, x => new OkulS   //OkulS diye bir tane datatransferobject oluşuturarak kendisine has bir select işlemi yaptık
            {
                Id = x.Id,  //x yukarda yazdığımız okulu temsil ediyor
                Kod = x.Kod,
                OkulAdi = x.OkulAdi,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,  //okuldan Il e ulaştık Il den de IlAdi na ulaştık
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Okul, bool>> filter)
        {
            return BaseList(filter, x => new OkulL //OkulL diye bir tane datatransferobject oluşuturarak kendisine has bir select işlemi yaptık
            {
                Id = x.Id,
                Kod = x.Kod,
                OkulAdi = x.OkulAdi,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                Aciklama = x.Aciklama,

            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
