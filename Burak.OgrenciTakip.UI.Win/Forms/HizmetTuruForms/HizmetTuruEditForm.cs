using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Common.Functions;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;

namespace Burak.OgrenciTakip.UI.Win.Forms.HizmetTuruForms
{
    public partial class HizmetTuruEditForm : BaseEditForm
    {
        public HizmetTuruEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new HizmetTuruBll(myDataLayoutControl);
            txtHizmetTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<HizmetTipi>());
            BaseKartTuru = KartTuru.HizmetTuru;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new HizmetTuru() : ((HizmetTuruBll)Bll).Single(FilterFunctions.Filter<HizmetTuru>(Id));  //ailebilgiBll üzerinden gidip ıd alanına göre gidip sorgu yapıyor ve geriye bir değer döndürüyor hangi durumda? işlem türü EntityUpdate ise 
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);   //IslemTuru, entityInsert ise bşir tane id ver 
            txtKod.Text = ((HizmetTuruBll)Bll).YeniKodVer();      //yeni bir kod ver
            txtHizmetTuruAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (HizmetTuru)OldEntity;

            txtKod.Text = entity.Kod;
            txtHizmetTuruAdi.Text = entity.HizmetTuruAdi;
            txtHizmetTipi.SelectedItem = entity.HizmetTipi.ToName();
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new HizmetTuru
            {
                Id = Id,
                Kod = txtKod.Text,
                HizmetTuruAdi = txtHizmetTuruAdi.Text,
                HizmetTipi = txtHizmetTipi.Text.GetEnum<HizmetTipi>(),
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}