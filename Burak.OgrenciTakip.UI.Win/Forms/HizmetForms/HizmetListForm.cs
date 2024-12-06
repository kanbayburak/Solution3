using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.GenelForms;
using Burak.OgrenciTakip.UI.Win.Show;
using System;

namespace Burak.OgrenciTakip.UI.Win.Forms.HizmetForms
{
    public partial class HizmetListForm : BaseListForm
    {
        public HizmetListForm()
        {
            InitializeComponent();

            Bll = new HizmetBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Hizmet;
            FormShow = new ShowEditForms<HizmetEditForm>();
            Navigator = longNavigator.Navigator;
            TarihAyarla();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((HizmetBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        private void TarihAyarla()
        {
            txtHizmetBaslamaTarihi.Properties.MinValue = AnaForm.GunTarihininOncesineHizmetBaslamaTarihiGirilebilir ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date < AnaForm.EgitimBaslamaTarihi ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date;
            txtHizmetBaslamaTarihi.Properties.MaxValue = AnaForm.GunTarihininSonrasinaHizmetBaslamaTarihiGirilebilir ? AnaForm.DonemBitisTarihi : DateTime.Now.Date < AnaForm.EgitimBaslamaTarihi ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.DonemBitisTarihi ? AnaForm.DonemBitisTarihi : DateTime.Now.Date;
            txtHizmetBaslamaTarihi.DateTime = DateTime.Now.Date <= AnaForm.EgitimBaslamaTarihi ? AnaForm.EgitimBaslamaTarihi : DateTime.Now.Date > AnaForm.EgitimBaslamaTarihi && DateTime.Now.Date <= AnaForm.DonemBitisTarihi ? DateTime.Now.Date : DateTime.Now.Date > AnaForm.DonemBitisTarihi ? AnaForm.DonemBitisTarihi : DateTime.Now.Date;
        }
    }
}