using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;

namespace Burak.OgrenciTakip.UI.Win.Forms.YakinlikForm
{
    public partial class YakinlikEditForm : BaseEditForm
    {
        public YakinlikEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new YakinlikBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Yakinlik;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Yakinlik() : ((YakinlikBll)Bll).Single(FilterFunctions.Filter<Yakinlik>(Id));  //ailebilgiBll üzerinden gidip ıd alanına göre gidip sorgu yapıyor ve geriye bir değer döndürüyor hangi durumda? işlem türü EntityUpdate ise 
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);   //IslemTuru, entityInsert ise bşir tane id ver 
            txtKod.Text = ((YakinlikBll)Bll).YeniKodVer();      //yeni bir kod ver
            txtYakinlikAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Yakinlik)OldEntity;

            txtKod.Text = entity.Kod;
            txtYakinlikAdi.Text = entity.YakinlikAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Yakinlik
            {
                Id = Id,
                Kod = txtKod.Text,
                YakinlikAdi = txtYakinlikAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}