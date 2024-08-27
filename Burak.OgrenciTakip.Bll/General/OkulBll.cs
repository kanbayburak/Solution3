using Burak.OgrenciTakip.Bll.Base;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Data.Contexts;
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
    public class OkulBll: BaseBll<Okul, OgrenciTakipContext>, IBaseGenelBll
    {
        public OkulBll() { }

        public OkulBll(Control ctrl) : base(ctrl) { }


        public BaseEntity Single(Expression<Func<Okul, bool>> filter)
        {
            return BaseSingle(filter, x => new OkulS
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

        public IEnumerable<BaseEntity> List(Expression<Func<Okul, bool>> filter)
        {
            return BaseList(filter, x => new OkulL
            {
                Id = x.Id,
                Kod = x.Kod,
                OkulAdi = x.OkulAdi,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                Aciklama = x.Aciklama,

            }).OrderBy(x => x.Kod).ToList(); 
        }

       public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currenEntity)
        {
            return BaseUpdate(oldEntity, currenEntity, x => x.Kod == currenEntity.Kod);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity,KartTuru.Okul);
        }

        public bool UpDate(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            throw new NotImplementedException();
        }

        public string YeniKodVer()
        {
            throw new NotImplementedException();
        }
    }
}
