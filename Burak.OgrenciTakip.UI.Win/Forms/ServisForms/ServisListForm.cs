using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.GenelForms;
using Burak.OgrenciTakip.UI.Win.Show;

namespace Burak.OgrenciTakip.UI.Win.Forms.ServisForms
{
    public partial class ServisListForm : BaseListForm
    {
        public ServisListForm()
        {
            InitializeComponent();

            Bll = new ServisBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Servis;
            FormShow = new ShowEditForms<ServisEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((ServisBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
    }
}