using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Functions;
using Burak.OgrenciTakip.UI.Win.Show;

namespace Burak.OgrenciTakip.UI.Win.Forms.GorevForms
{
    public partial class GorevListForm : BaseListForm
    {
        public GorevListForm()
        {
            InitializeComponent();
            Bll = new GorevBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Gorev;
            FormShow = new ShowEditForms<GorevEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((GorevBll)Bll).List(FilterFunctions.Filter<Gorev>(AktifKartlariGoster));
        }
    }
}