using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Common.Functions;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;

namespace Burak.OgrenciTakip.UI.Win.Forms.OdemeTuruForms
{
    public partial class OdemeTuruEditForm : BaseEditForm
    {
        public OdemeTuruEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new OdemeTuruBll(myDataLayoutControl);
            txtOdemeTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<OdemeTipi>());
            BaseKartTuru = KartTuru.OdemeTuru;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new OdemeTuru() : ((OdemeTuruBll)Bll).Single(FilterFunctions.Filter<OdemeTuru>(Id));  //ailebilgiBll üzerinden gidip ıd alanına göre gidip sorgu yapıyor ve geriye bir değer döndürüyor hangi durumda? işlem türü EntityUpdate ise 
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);   //IslemTuru, entityInsert ise bir tane id ver 
            txtKod.Text = ((OdemeTuruBll)Bll).YeniKodVer();      //yeni bir kod ver
            txtOdemeTuruAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (OdemeTuru)OldEntity;

            txtKod.Text = entity.Kod;
            txtOdemeTuruAdi.Text = entity.OdemeTuruAdi;
            txtOdemeTipi.SelectedItem = entity.OdemeTipi.ToName();
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new OdemeTuru
            {
                Id = Id,
                Kod = txtKod.Text,
                OdemeTuruAdi = txtOdemeTuruAdi.Text,
                OdemeTipi = txtOdemeTipi.Text.GetEnum<OdemeTipi>(),
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}