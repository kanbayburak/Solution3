﻿using Burak.OgrenciTakip.Bll.General;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Show;

namespace Burak.OgrenciTakip.UI.Win.Forms.IlceForms
{
    public partial class IlceListForm : BaseListForm
    {
        #region Variables
        private readonly long _ilId;
        private readonly string _ilAdi;
        #endregion
        public IlceListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new IlceBll();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ilce;
            Navigator = longNavigator.Navigator;
            Text = Text + $"- ( {_ilAdi} )";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlceBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.IlId == _ilId);   //özel filter oluşturduk normalde genel bir filter function ımız vardı ama biz bunu kullandık
        }
        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<IlceEditForm>.ShowDialogEditForm(KartTuru.Ilce, id, _ilId, _ilAdi);
            //ShowEditFormDefault(result);
        }
    }
}