using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Forms.EvrakForms;
using Burak.OgrenciTakip.UI.Win.GenelForms;
using Burak.OgrenciTakip.UI.Win.Show;

namespace Burak.OgrenciTakip.UI.Win.Forms.SinifForms
{
    public partial class SinifListForm : BaseListForm
    {
        public SinifListForm()
        {
            InitializeComponent();
            Bll = new SinifBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Sinif;
            FormShow = new ShowEditForms<SinifEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SinifBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId);
        }
    }
}