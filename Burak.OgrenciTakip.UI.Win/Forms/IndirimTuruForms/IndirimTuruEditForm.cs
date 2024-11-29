using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;

namespace Burak.OgrenciTakip.UI.Win.Forms.IndirimTuruForms
{
    public partial class IndirimTuruEditForm : BaseEditForm
    {
        public IndirimTuruEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IndirimTuruBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.IndirimTuru;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IndirimTuru() : ((IndirimTuruBll)Bll).Single(FilterFunctions.Filter<IndirimTuru>(Id));  //ailebilgiBll üzerinden gidip ıd alanına göre gidip sorgu yapıyor ve geriye bir değer döndürüyor hangi durumda? işlem türü EntityUpdate ise 
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);   //IslemTuru, entityInsert ise bşir tane id ver 
            txtKod.Text = ((IndirimTuruBll)Bll).YeniKodVer();      //yeni bir kod ver
            txtIndirimTuruAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IndirimTuru)OldEntity;

            txtKod.Text = entity.Kod;
            txtIndirimTuruAdi.Text = entity.IndirimTuruAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new IndirimTuru
            {
                Id = Id,
                Kod = txtKod.Text,
                IndirimTuruAdi = txtIndirimTuruAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}