﻿using System;
using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Dto;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;

namespace Burak.OgrenciTakip.UI.Win.Forms.OkulForms
{
    public partial class OkulEditForm : BaseEditForm
    {
        public OkulEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new OkulBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Okul;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OkulS() : ((OkulBll)Bll).Single(FilterFunctions.Filter<Okul>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((OkulBll)Bll).YeniKodVer();
            txtOkulAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OkulS)OldEntity;

            txtKod.Text = entity.Kod;
            txtOkulAdi.Text = entity.OkulAdi;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Okul
            {
                Id = Id,
                Kod = txtKod.Text,
                OkulAdi = txtOkulAdi.Text,
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButonEnabledDurumu();

        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtIl)
                    sec.Sec(txtIl);
                else if (sender == txtIlce)
                    sec.Sec(txtIlce, txtIl);
            }
        }
    }
}