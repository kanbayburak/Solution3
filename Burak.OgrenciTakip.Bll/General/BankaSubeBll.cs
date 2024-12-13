using Burak.OgrenciTakip.Bll.Base;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace Burak.OgrenciTakip.Bll.General
{
    public class BankaSubeBll : BaseGenelBll<BankaSube>, IBaseCommonBll
    {
        public BankaSubeBll() : base(KartTuru.BankaSube) { }

        public BankaSubeBll(Control ctrl) : base(ctrl, KartTuru.BankaSube) { }
    }
}
