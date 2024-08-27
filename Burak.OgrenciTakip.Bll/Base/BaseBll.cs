using Burak.OgrenciTakip.Bll.Functions;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Common.Functions;
using Burak.OgrenciTakip.Common.Messages;
using Burak.OgrenciTakip.Model.Entities.Base;
using BurakOgrenciTakip.Interfaces;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Burak.OgrenciTakip.Bll.Base
{
    //<T, CTontext> dememizin nedeni birden fazla context olacağından buna generic yapı denir
    //Normal veri girişi yaptığımız formlar için olduğıundan dolayı BaseEntity kullandık, başka zaman basehareketentity yide başka zaman yapacağız
    public class BaseBll<T, TContext> : IBaseBll where T : BaseEntity where TContext : DbContext //buraya gelecek olacak entitylerimiz model katmanındaki BaseEntity den olacağı için implamente ettik 
    {

        #region Variables
        private readonly Control _ctrl;
        private IUnitOfWork<T> _uow;  //repostory imize  buradan ynai UnitOfWork  den erişiyor olacağız 
        #endregion

       

        //1. ctorumuz
        protected BaseBll() { } //protected dememizin nedeni sadece implamente eden classlar ulaşmasını istiyoruz 

        //2. ctorumuz
        protected BaseBll(Control ctrl)
        {
            _ctrl = ctrl;
        }

        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow); //sisteme giriş yaparken sürekli ConnectionString değişecek
            return _uow.Rep.Find(filter, selector);
        }
        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);
        }

        protected bool BaseInsert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);

            //Validation kod blokları
           
            _uow.Rep.Insert(entity.EntityConvert<T>());

            //burada gelen entity i Convert yapıp o şekilde repository e göndereceğiz
            //_uow.Rep.Insert(entity.EntityConvert<T>());
            return _uow.Save();
        }

        //2 tane entity alacak bir eski diğeri yeni halinin
        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);

            //validation işlmeleri
            


            //sadece değişen propertylere update olacak 
            var degisenAlanlar = oldEntity.DegisenAlanlariGetir(currentEntity);
            //değişen alanlara sahipsek
            if (degisenAlanlar.Count == 0) return true;

            _uow.Rep.Update(currentEntity.EntityConvert<T>(), degisenAlanlar);
            return _uow.Save();
        }

        protected bool BaseDelete(BaseEntity entity, KartTuru kartTuru, bool mesajVer = true)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            if (mesajVer)
            {
                if (Messages.SilMesaj(kartTuru.ToName()) != DialogResult.Yes) return false;
            }
            _uow.Rep.Delete(entity.EntityConvert<T>());
            return _uow.Save();
        }

        protected string BaseYeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {
            GeneralFunctions.CreatUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.YeniKodVer(kartTuru, filter, where);
        }

        #region Dispose


        //Bu kod, _ctrl ve _uow nesnelerinin Dispose metodunu çağırarak, bu nesnelerin sahip olduğu kaynakları güvenli bir şekilde serbest bırakmayı amaçlar ve null kontrolü yaparak olası hataları önler.
        public void Dispose()
        {
            _ctrl?.Dispose();
            _uow?.Dispose();
        }
        #endregion
    }
}
