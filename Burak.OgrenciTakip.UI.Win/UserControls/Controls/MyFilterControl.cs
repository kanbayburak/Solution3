﻿using Burak.OgrenciTakip.UI.Win.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyFilterControl : FilterControl, IStatusBarAciklama
    {
        public MyFilterControl()
        {
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz";
    }
}
