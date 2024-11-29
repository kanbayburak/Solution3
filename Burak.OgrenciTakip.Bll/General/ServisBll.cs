using Burak.OgrenciTakip.Bll.Base;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace Burak.OgrenciTakip.Bll.General
{
    public class ServisBll : BaseGenelBll<Servis>, IBaseCommonBll
    {
        public ServisBll() : base(KartTuru.Servis)
        {
        }

        public ServisBll(Control ctrl) : base(ctrl, KartTuru.Servis)
        {
        }
    }
}
