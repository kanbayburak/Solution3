using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Common.Functions;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.Model.Entities.Base.Interfaces;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraBars;
using System;

namespace Burak.OgrenciTakip.UI.Win.GenelForms
{
    public partial class TabloDokumParametreleri : BaseEditForm
    {
        #region Variable
        private DokumSekli _dokumSekli;
        private readonly string _raporBaslik;
        #endregion
        public TabloDokumParametreleri(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl2;
            HideItems = new BarItem[] { btnYeni, btnKaydet, btnGerial, btnSil };
            ShowItems = new BarItem[] { btnYazdir, btnBaskiOnizleme };
            EventsLoad();

            _raporBaslik = prm[0].ToString();
        }

        protected internal override void Yukle()
        {
            txtRaporBasligi.Text = _raporBaslik;
            txtBaslikEkle.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtRaporKagidaSigdir.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<RaporuKagidaSigdirmaTuru>());
            txtYazdirmaYonu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaYonu>());
            txtYatayCizgileriGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtDikeyCizgileriGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtSutunBasliklariniGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());


            //aşağıdakiler formu açtığımız zaman ilk olarak default olarak gelecek olanlar
            txtBaslikEkle.SelectedItem = EvetHayir.Evet.ToName();
            txtRaporKagidaSigdir.SelectedItem = RaporuKagidaSigdirmaTuru.YaziBoyutunuKuculterekSigdir.ToName();
            txtYazdirmaYonu.SelectedItem = YazdirmaYonu.Otomatik.ToName();
            txtYatayCizgileriGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtDikeyCizgileriGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtSutunBasliklariniGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();  //yazici ismi seçmek 
        }
        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new DokumParametreleri
            {
                RaporBaslik = txtRaporBasligi.Text,
                Basilikle = txtBaslikEkle.Text.GetEnum<EvetHayir>(),
                RaporuKagidaSigdir = txtRaporKagidaSigdir.Text.GetEnum<RaporuKagidaSigdirmaTuru>(),
                YazdirmaYonu = txtYazdirmaYonu.Text.GetEnum<YazdirmaYonu>(),
                YatayCizgileriGoster = txtYatayCizgileriGoster.Text.GetEnum<EvetHayir>(),
                DikeyCizgileriGoster = txtDikeyCizgileriGoster.Text.GetEnum<EvetHayir>(),
                SutunBasliklariniGoster = txtSutunBasliklariniGoster.Text.GetEnum<EvetHayir>(),
                YaziciAdi = txtYaziciAdi.Text,
                YazdirilacakAdet = (int)txtYazdirilacakAdet.Value,
                DokumSekli = _dokumSekli   //_dokumSekli adında yerel bir değişken oluşturacağız çünkü farklı yerlerde kullanacağız 
            };
            return entity;
        }

        protected override void Yazdir()
        {
            _dokumSekli = DokumSekli.TabloYazdir;
            Close();
        }

        protected override void BaskiOnizleme()
        {
            _dokumSekli = DokumSekli.TabloBaskiOnizleme;
            Close();
        }
        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            txtRaporBasligi.Enabled = txtBaslikEkle.Text.GetEnum<EvetHayir>() == EvetHayir.Evet;
        }
    }
}