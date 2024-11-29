using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;
using Burak.OgrenciTakip.UI.Win.GenelForms;

namespace Burak.OgrenciTakip.UI.Win.Forms.EvrakForms
{
    public partial class EvrakEditForm : BaseEditForm

    {
        public EvrakEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new EvrakBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Evrak;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Evrak() : ((EvrakBll)Bll).Single(FilterFunctions.Filter<Evrak>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((EvrakBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtEvrakAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Evrak)OldEntity;

            txtKod.Text = entity.Kod;
            txtEvrakAdi.Text = entity.EvrakAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Evrak
            {
                Id = Id,
                Kod = txtKod.Text,
                EvrakAdi = txtEvrakAdi.Text,
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Durum = tglDurum.IsOn,

            };

            ButonEnabledDurumu();

        }


        //Insert ve Update bizim interface yapımıza uymuyorlar o yüzden Override yaptık
        protected override bool EntityInsert()
        {
            return ((EvrakBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
        protected override bool EntityUpdate()
        {
            return ((EvrakBll)Bll).UpDate(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}