using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Common.Messages;
using Burak.OgrenciTakip.Model.Entities.Base;
using Burak.OgrenciTakip.UI.Win.Functions;
using Burak.OgrenciTakip.UI.Win.UserControls.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Windows.Forms;


namespace Burak.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal IslemTuru BaseIslemTuru;
        protected internal long Id;
        protected internal bool RefresYapilacak;
        protected MyDataLayoutControl DataLayoutControl;
        protected MyDataLayoutControl[] DataLayoutControls;
        protected IBaseBll Bll;
        protected KartTuru BaseKartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected bool IsLoaded;
        protected bool KayitSonrasiFormuKapat = true;

        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected void EventsLoad()
        {
            //Buttton Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //Forms Events
            Load += BaseEditForm_Load;

            void ControlEvents(Control control)
            {
                control.KeyDown += Control_Keydown;
               

                switch (control)  //bu kısımda sıralama önemli MyButtonEdit sonrasında BaseEdit olmalı çünkü MyButtonEdit, BaseEditten implament olduğu için
                {
                    case MyButtonEdit edt:
                        edt.IdChanged += Control_IdChanged;
                        edt.ButtonClick += Control_ButtonClick;
                        edt.DoubleClick += Control_DoubleClick;
                        break;
                    case BaseEdit edt:    //burada formda değişiklik yapıldığı vakit kaydettiğinde güncelleme işlemi yapar
                        edt.EditValueChanged += Control_EditValueChanged; 
                        break;
                }
            }

            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;
                foreach (Control ctrl in DataLayoutControl.Controls)
                    ControlEvents(ctrl);
            }
            else
                foreach (var layout in DataLayoutControls)
                    foreach (Control ctrl in layout.Controls)
                        ControlEvents(ctrl);
        }

        private void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_IdChanged(object sender, IdChangedEvenetArgs e)
        {
            if (!IsLoaded) return;
            GuncelNesneOlustur();
        }

        private void Control_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (sender is MyButtonEdit edt)
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift: // burada ctrlshift delete basında şu işlmei yaparsın diye tanımladık
                        edt.Id = null;
                        edt.EditValue = null;
                        break;

                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(edt);
                        break;
                }
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            GuncelNesneOlustur();
            //SablonYukle();
            //ButonGizleGoster();
            Id = BaseIslemTuru.IdOlustur(OldEntity);


            //güncelleme yapılacak
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnYeni)
            {
                BaseIslemTuru = IslemTuru.EntityInsert;
                Yukle();
            }
            else if (e.Item == btnKaydet)
            {
                Kaydet(false);
            }

            else if (e.Item == btnGerial)
            {
                Gerial();
            }
            else if (e.Item == btnSil)
            {
                //Yetki Kontrolleri
                EntityDelete();
            }

            else if (e.Item == btnCikis)
            {
                Close();
            }

            Cursor.Current = DefaultCursor;
        }
        protected virtual void SecimYap(object sender) { }

        private void EntityDelete()
        {
            throw new NotImplementedException();
        }

        private void Gerial()
        {
            throw new NotImplementedException();
        }

        private bool Kaydet(bool kapanis)
        {
            bool KayitIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (BaseIslemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                            return KayitSonrasiIslemler();
                        break;
                    case IslemTuru.EntityUpdate:
                        if (EntityUpdate())
                            return KayitSonrasiIslemler();
                        break;

                }
                bool KayitSonrasiIslemler()
                {
                    OldEntity = CurrentEntity;
                    RefresYapilacak = true;
                    ButonEnabledDurumu();

                    if (KayitSonrasiFormuKapat)
                    {
                        Close();
                    }
                    else
                        BaseIslemTuru = BaseIslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : BaseIslemTuru;
                    return true;
                }
                return false;
            }
            var result = kapanis ? Messages.KapanisMesaj() : Messages.KayitMesaj();

            switch (result) //tyhyth
            {
                case DialogResult.Yes:
                    return KayitIslemi();

                case DialogResult.No:
                    if (kapanis)
                    {
                        btnKaydet.Enabled = false;
                    }
                    return true;

                case DialogResult.Cancel:
                    return true;
            }
            return false;
        }

        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)Bll).Insert(CurrentEntity);
        }
        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)Bll).UpDate(OldEntity, CurrentEntity);
        }

        protected internal virtual void Yukle() {}
        protected virtual void NesneyiKontrollereBagla() { }
        protected virtual void GuncelNesneOlustur() { }
        protected virtual void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity);  //buttonların enabled durumunu değiştirecek
        }

    }
}