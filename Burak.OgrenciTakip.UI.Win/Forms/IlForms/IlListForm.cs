using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;
using Burak.OgrenciTakip.UI.Win.Show;
using Burak.OgrenciTakip.Common.Enums;
using DevExpress.XtraBars;
using Burak.OgrenciTakip.UI.Win.Forms.IlceForms;

namespace Burak.OgrenciTakip.UI.Win.Forms.IlForms
{
    public partial class IlListForm : BaseListForm
    {
        public IlListForm()
        {
            InitializeComponent();
            Bll = new IlBll();
            btnBagliKartlar.Caption = "İlçe Kartlari";
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Il;
            FormShow = new ShowEditForms<IlEditForm>();
            Navigator = longNavigator.Navigator;


            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlBll)Bll).List(FilterFunctions.Filter<Il>(AktifKartlariGoster));
        }
        protected override void BagliKartAC()
        {
            var Entity = Tablo.GetRow<Il>();
            if (Entity == null) return;
            ShowListForms<IlceListForm>.ShowListForm(KartTuru.Ilce, Entity.Id, Entity.IlAdi);
        }
    }
}