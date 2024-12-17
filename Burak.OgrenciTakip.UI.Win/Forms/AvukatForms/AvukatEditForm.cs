﻿using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Dto;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;

namespace Burak.OgrenciTakip.UI.Win.Forms.AvukatForms
{
    public partial class AvukatEditForm : BaseEditForm
    {
        public AvukatEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new AvukatBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Avukat;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new AvukatS() : ((AvukatBll)Bll).Single(FilterFunctions.Filter<Avukat>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AvukatBll)Bll).YeniKodVer();
            txtAdiSoyadi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AvukatS)OldEntity;

            txtKod.Text = entity.Kod;
            txtAdiSoyadi.Text = entity.AdiSoyadi;
            txtSozlemeNo.Text = entity.SozlesmeNo;
            txtBaslamaTarihi.EditValue = entity.SozlesmeBaslamaTarihi;  //entity de datetime nullable olduğu için DateTime da null kabul etmediği için EditValue kullandık
            txtBitisTarihi.EditValue = entity.SozlesmeBitisTarihi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Avukat
            {
                Id = Id,
                Kod = txtKod.Text,
                AdiSoyadi = txtAdiSoyadi.Text,
                SozlesmeNo =txtSozlemeNo.Text,
                SozlesmeBaslamaTarihi = (DateTime?)txtBaslamaTarihi.EditValue, 
                SozlesmeBitisTarihi = (DateTime?)txtBitisTarihi.EditValue,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn

            };

            ButonEnabledDurumu();

        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Avukat);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Avukat);
        }
    }
}