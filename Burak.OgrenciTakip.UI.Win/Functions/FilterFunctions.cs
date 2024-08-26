﻿using Burak.OgrenciTakip.Model.Entities.Base;
using System;
using System.Linq.Expressions;

namespace Burak.OgrenciTakip.UI.Win.Functions
{
    public class FilterFunctions
    {
        public static Expression<Func<T, bool>> Filter<T>(bool aktifKartlariGoster) where T : BaseEntityDurum
        {
            return x => x.Durum == aktifKartlariGoster;
        }
    }
}