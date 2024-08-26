using Burak.OgrenciTakip.Common.Enums;
using DevExpress.XtraBars.Ribbon;
using System;

namespace Burak.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal IslemTuru IslemTuru;
        protected internal long Id;
        protected internal bool RefresYapilacak;
        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected internal void Yukle() {}


    }
}