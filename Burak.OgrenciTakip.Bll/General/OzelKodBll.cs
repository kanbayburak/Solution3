using System.Windows.Forms;
using Burak.OgrenciTakip.Bll.Base;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;

namespace Burak.OgrenciTakip.Bll.General
{
    public class OzelKodBll : BaseGenelBll<OzelKod>, IBaseCommonBll
    {
        public OzelKodBll() : base(KartTuru.OzelKod)
        {
        }

        public OzelKodBll(Control ctrl) : base(ctrl, KartTuru.OzelKod)
        {
        }
    }
}
