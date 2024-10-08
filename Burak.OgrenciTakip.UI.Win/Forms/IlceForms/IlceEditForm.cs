﻿using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Functions;

namespace Burak.OgrenciTakip.UI.Win.Forms.IlceForms
{
    public partial class IlceEditForm : BaseEditForm
    {
        
        #region Variables
        private readonly long _ilId;
        private readonly string _ilAdi;
        #endregion
        public IlceEditForm(params object[] prm)
        {
            InitializeComponent();
            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
            DataLayoutControl = myDataLayoutControl;
            Bll = new IlceBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Ilce;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Ilce() : ((IlceBll)Bll).Single(FilterFunctions.Filter<Ilce>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $"- ( {_ilAdi} )";
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            //Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IlceBll)Bll).YeniKodVer(x => x.IlId == _ilId);
            txtIlceAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Ilce)OldEntity;
            txtKod.Text = entity.Kod;
            txtIlceAdi.Text = entity.IlceAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Ilce
            {
                Id = Id,
                Kod = txtKod.Text,
                IlceAdi = txtIlceAdi.Text,
                IlId = _ilId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((IlceBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);  // x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId   bu kısımda özet olarak ben sana bir tane ilId gönderdim sen git bu ilId ile ilgili ilçeleri database den çek aynı zamanda bu Ilceler arasında bu koda ait sdaha önce kullanılmış bir ilçe var mı varsa uyarı verecek 
        }
        protected override bool EntityUpdate()
        {
            return ((IlceBll)Bll).UpDate(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlId == _ilId);
        }
    }
}