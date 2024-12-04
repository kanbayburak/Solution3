using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;
using Burak.OgrenciTakip.UI.Win.Show;

namespace Burak.OgrenciTakip.UI.Win.Forms.HizmetTuruForms
{
    public partial class HizmetTuruListForm : BaseListForm
    {
        public HizmetTuruListForm()
        {
            InitializeComponent();

            Bll = new HizmetTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.HizmetTuru;
            FormShow = new ShowEditForms<HizmetTuruEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((HizmetTuruBll)Bll).List(FilterFunctions.Filter<HizmetTuru>(AktifKartlariGoster));
        }
    }
}