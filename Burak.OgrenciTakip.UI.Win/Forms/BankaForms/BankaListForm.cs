using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;
using Burak.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;

namespace Burak.OgrenciTakip.UI.Win.Forms.BankaForms
{
    public partial class BankaListForm : BaseListForm
    {
        public BankaListForm()
        {
            InitializeComponent();

            Bll = new BankaBll();
            btnBagliKartlar.Caption = "Şube Kartlari";
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Banka;
            FormShow = new ShowEditForms<BankaEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BankaBll)Bll).List(FilterFunctions.Filter<Banka>(AktifKartlariGoster));
        }

        //protected override void BagliKartAc()
        //{
        //    var Entity = Tablo.GetRow<Il>();
        //    if (Entity == null) return;
        //    ShowListForms<IlceListForm>.ShowListForm(KartTuru.Ilce, Entity.Id, Entity.IlAdi);
        //}
    }
}