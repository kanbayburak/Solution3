using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;

namespace Burak.OgrenciTakip.UI.Win.Forms.OkulForms
{
    public partial class OkulListForm : BaseListForm
    {
        public OkulListForm()
        {
            InitializeComponent();

            OkulBll bll = new OkulBll();
            grid.DataSource = bll.List(null);
        }
    }
}