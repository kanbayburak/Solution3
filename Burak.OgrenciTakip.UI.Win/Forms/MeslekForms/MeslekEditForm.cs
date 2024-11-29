using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;

namespace Burak.OgrenciTakip.UI.Win.Forms.MeslekForms
{
    public partial class MeslekEditForm : BaseEditForm
    {
        public MeslekEditForm()
        {
            InitializeComponent();


            DataLayoutControl = myDataLayoutControl;
            Bll = new MeslekBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Meslek;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Meslek() : ((MeslekBll)Bll).Single(FilterFunctions.Filter<Meslek>(Id));  //ailebilgiBll üzerinden gidip ıd alanına göre gidip sorgu yapıyor ve geriye bir değer döndürüyor hangi durumda? işlem türü EntityUpdate ise 
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);   //IslemTuru, entityInsert ise bşir tane id ver 
            txtKod.Text = ((MeslekBll)Bll).YeniKodVer();      //yeni bir kod ver
            txtMeslekAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Meslek)OldEntity;

            txtKod.Text = entity.Kod;
            txtMeslekAdi.Text = entity.MeslekAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Meslek
            {
                Id = Id,
                Kod = txtKod.Text,
                MeslekAdi = txtMeslekAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}