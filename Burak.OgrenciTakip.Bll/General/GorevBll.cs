﻿using Burak.OgrenciTakip.Bll.Base;
using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace Burak.OgrenciTakip.Bll.General
{
    public class GorevBll : BaseGenelBll<Gorev>, IBaseGenelBll, IBaseCommonBll
    {
        public GorevBll() : base(KartTuru.Gorev)
        {
        }

        public GorevBll(Control ctrl) : base(ctrl, KartTuru.Gorev)
        {
        }
    }
}