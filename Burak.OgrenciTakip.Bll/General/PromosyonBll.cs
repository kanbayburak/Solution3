using Burak.OgrenciTakip.Bll.Base;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace Burak.OgrenciTakip.Bll.General
{
    public class PromosyonBll : BaseGenelBll<Promosyon>, IBaseCommonBll
    {
        public PromosyonBll() : base(KartTuru.Promosyon)
        {
        }

        public PromosyonBll(Control ctrl) : base(ctrl, KartTuru.Promosyon)
        {
        }
    }
}
