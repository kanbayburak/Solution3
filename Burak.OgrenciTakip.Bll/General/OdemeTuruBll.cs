using System.Windows.Forms;
using Burak.OgrenciTakip.Bll.Base;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;

namespace Burak.OgrenciTakip.Bll.General
{
    public class OdemeTuruBll : BaseGenelBll<OdemeTuru>, IBaseGenelBll, IBaseCommonBll
    {
        public OdemeTuruBll() : base(KartTuru.OdemeTuru)
        {
        }

        public OdemeTuruBll(Control ctrl) : base(ctrl, KartTuru.OdemeTuru)
        {
        }
    }
}
