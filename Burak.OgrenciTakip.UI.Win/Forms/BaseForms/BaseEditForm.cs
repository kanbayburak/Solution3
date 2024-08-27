using Burak.OgrenciTakip.Bll.Interfaces;
using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.Common.Messages;
using Burak.OgrenciTakip.Model.Entities.Base;
using Burak.OgrenciTakip.UI.Win.Functions;
using Burak.OgrenciTakip.UI.Win.UserControls.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Windows.Forms;


namespace Burak.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal IslemTuru IslemTuru;
        protected internal long Id;
        protected internal bool RefresYapilacak;
        protected MyDataLayoutControl DataLayoutControl;
        protected IBaseBll Bll;
        protected KartTuru KartTuru;
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
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            GuncelNesneOlustur();
            //SablonYukle();
            //ButonGizleGoster();
            Id = IslemTuru.IdOlustur(OldEntity);


            //güncelleme yapılacak
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnYeni)
            {
                IslemTuru = IslemTuru.EntityInsert;
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

                switch (IslemTuru)
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
                        IslemTuru = IslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : IslemTuru;
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