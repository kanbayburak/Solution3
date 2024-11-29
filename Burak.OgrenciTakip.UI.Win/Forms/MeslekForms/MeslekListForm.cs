using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.UI.Win.Show;
using Burak.OgrenciTakip.UI.Win.Functions;
using Burak.OgrenciTakip.Model.Entities;

namespace Burak.OgrenciTakip.UI.Win.Forms.MeslekForms
{
    public partial class MeslekListForm : BaseListForm
    {
        public MeslekListForm()
        {
            InitializeComponent();

            Bll = new MeslekBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Meslek;
            FormShow = new ShowEditForms<MeslekEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MeslekBll)Bll).List(FilterFunctions.Filter<Meslek>(AktifKartlariGoster));
        }
    }
}