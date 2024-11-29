using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;

namespace Burak.OgrenciTakip.UI.Win.Forms.KontenjanForms
{
    public partial class KontenjanEditForm : BaseEditForm
    {
        public KontenjanEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KontenjanBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Kontenjan;
            EventsLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Kontenjan() : ((KontenjanBll)Bll).Single(FilterFunctions.Filter<Kontenjan>(Id));  //ailebilgiBll üzerinden gidip ıd alanına göre gidip sorgu yapıyor ve geriye bir değer döndürüyor hangi durumda? işlem türü EntityUpdate ise 
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);   //IslemTuru, entityInsert ise bşir tane id ver 
            txtKod.Text = ((KontenjanBll)Bll).YeniKodVer();      //yeni bir kod ver
            txtKontenjanAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kontenjan)OldEntity;

            txtKod.Text = entity.Kod;
            txtKontenjanAdi.Text = entity.KontenjanAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kontenjan
            {
                Id = Id,
                Kod = txtKod.Text,
                KontenjanAdi = txtKontenjanAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };
            ButonEnabledDurumu();
        }
    }
}