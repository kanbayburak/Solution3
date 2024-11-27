using Burak.OgrenciTakip.Bll.Base;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace Burak.OgrenciTakip.Bll.General
{
    public class IlBll : BaseGenelBll<Il>, IBaseGenelBll, IBaseCommonBll
    {
        public IlBll() : base(KartTuru.Il) { }
        public IlBll(Control ctrl):base(ctrl, KartTuru.Il) { }
    }
}
