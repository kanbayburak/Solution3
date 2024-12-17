using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.UI.Win.Forms.AileBilgiForms;
using Burak.OgrenciTakip.UI.Win.Forms.AvukatForms;
using Burak.OgrenciTakip.UI.Win.Forms.BankaForms;
using Burak.OgrenciTakip.UI.Win.Forms.EvrakForms;
using Burak.OgrenciTakip.UI.Win.Forms.GorevForms;
using Burak.OgrenciTakip.UI.Win.Forms.HizmetForms;
using Burak.OgrenciTakip.UI.Win.Forms.HizmetTuruForms;
using Burak.OgrenciTakip.UI.Win.Forms.IlForms;
using Burak.OgrenciTakip.UI.Win.Forms.IndirimTuruForms;
using Burak.OgrenciTakip.UI.Win.Forms.IptalNedeniForms;
using Burak.OgrenciTakip.UI.Win.Forms.IsyeriForms;
using Burak.OgrenciTakip.UI.Win.Forms.KasaForms;
using Burak.OgrenciTakip.UI.Win.Forms.KontenjanForms;
using Burak.OgrenciTakip.UI.Win.Forms.MeslekForms;
using Burak.OgrenciTakip.UI.Win.Forms.OkulForms;
using Burak.OgrenciTakip.UI.Win.Forms.PromosyonForms;
using Burak.OgrenciTakip.UI.Win.Forms.RehberForms;
using Burak.OgrenciTakip.UI.Win.Forms.ServisForms;
using Burak.OgrenciTakip.UI.Win.Forms.SinifForms;
using Burak.OgrenciTakip.UI.Win.Forms.SinifGrupForms;
using Burak.OgrenciTakip.UI.Win.Forms.TesvikForms;
using Burak.OgrenciTakip.UI.Win.Forms.YabanciDilForms;
using Burak.OgrenciTakip.UI.Win.Forms.YakinlikForm;
using Burak.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;
using System;

namespace Burak.OgrenciTakip.UI.Win.GenelForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static long DonemId = 1;
        public static string DonemAdi = "Dönem Bilgisi Bekleniyor...";
        public static long SubeId = 1;
        public static string SubeAdi = "Şube Bilgisi Bekleniyor...";

        public static DateTime EgitimBaslamaTarihi = new DateTime(2020, 09, 15);
        public static DateTime DonemBitisTarihi = new DateTime(2021, 06, 30);
        public static bool GunTarihininOncesineHizmetBaslamaTarihiGirilebilir = true;
        public static bool GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir = true;
        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }
            }
        }



        //burada uygulamayı ilk çalıştırdığımızda gözüken butonlar
        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnOkulKartlari)
                ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);
            else if (e.Item == btnIlKartlari)
                ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
            else if (e.Item == btnAileBilgiKartlari)
                ShowListForms<AileBilgiListForm>.ShowListForm(KartTuru.AileBilgi);
            else if (e.Item == btnIptalNedeniKartlari)
                ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
            else if (e.Item == btnYabanciDilKartlari)
                ShowListForms<YabanciDilListForm>.ShowListForm(KartTuru.YabanciDil);
            else if (e.Item == btnTesvikKartlari)
                ShowListForms<TesvikListForm>.ShowListForm(KartTuru.Tesvik);
            else if (e.Item == btnKontenjanKartlari)
                ShowListForms<KontenjanListForm>.ShowListForm(KartTuru.Kontenjan);
            else if (e.Item == btnRehberKartlari)
                ShowListForms<RehberListForm>.ShowListForm(KartTuru.Rehber);
            else if (e.Item == btnSinifGrupKartlari)
                ShowListForms<SinifGrupListForm>.ShowListForm(KartTuru.SinifGrup);
            else if (e.Item == btnMeslekKartlari)
                ShowListForms<MeslekListForm>.ShowListForm(KartTuru.Meslek);
            else if (e.Item == btnYakinlikKartlari)
                ShowListForms<YakinlikListForm>.ShowListForm(KartTuru.Yakinlik);
            else if (e.Item == btnIsyeriKartlari)
                ShowListForms<IsyeriListForm>.ShowListForm(KartTuru.Isyeri);
            else if (e.Item == btnGorevKartlari)
                ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
            else if (e.Item == btnIndirimTuruKartlari)
                ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
            else if (e.Item == btnEvrakKartlari)
                ShowListForms<EvrakListForm>.ShowListForm(KartTuru.Evrak);
            else if (e.Item == btnPromosyonKartlari)
                ShowListForms<PromosyonListForm>.ShowListForm(KartTuru.Promosyon);
            else if (e.Item == btnServisYeriKartlari)
                ShowListForms<ServisListForm>.ShowListForm(KartTuru.Servis);
            else if (e.Item == btnSinifKartlari)
                ShowListForms<SinifListForm>.ShowListForm(KartTuru.Sinif);
            else if (e.Item == btnHizmetTuruKartlari)
                ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
            else if (e.Item == btnHizmetKartlari)
                ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Hizmet);
            else if (e.Item == btnKasaKartlari)
                ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
            else if (e.Item == btnBankaKartlari)
                ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
            else if (e.Item == btnAvukatKartlari)
                ShowListForms<AvukatListForm>.ShowListForm(KartTuru.Avukat);
        }

        private void AnaForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}