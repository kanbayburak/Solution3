using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;
using Burak.OgrenciTakip.UI.Win.Show;

namespace Burak.OgrenciTakip.UI.Win.Forms.YakinlikForm
{
    public partial class YakinlikListForm : BaseListForm
    {
        public YakinlikListForm()
        {
            InitializeComponent();

            Bll = new YakinlikBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Yakinlik;
            FormShow = new ShowEditForms<YakinlikEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((YakinlikBll)Bll).List(FilterFunctions.Filter<Yakinlik>(AktifKartlariGoster));
        }
    }
}