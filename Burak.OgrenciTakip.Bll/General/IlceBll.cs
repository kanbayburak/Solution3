using Burak.OgrenciTakip.Bll.Base;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Data.Contexts;
using Burak.OgrenciTakip.Model.Entities;
using Burak.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Burak.OgrenciTakip.Bll.General
{
    public class IlceBll : BaseGenelBll<Ilce>, IBaseCommonBll
    {

        public IlceBll(): base(KartTuru.Ilce) { }
        public IlceBll(Control ctrl):base(ctrl, KartTuru.Ilce) { }
    }
}
