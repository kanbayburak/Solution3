using Burak.OgrenciTakip.Common.Enums;
using Burak.OgrenciTakip.UI.Win.Forms.BaseForms;
using Burak.OgrenciTakip.UI.Win.Show.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak.OgrenciTakip.UI.Win.Show
{
    public class ShowEditForms<TForm>: IBaseFormShow where TForm : BaseEditForm
    {
        public long ShowDialogEditForm(KartTuru kartTuru, long id) //,params object[] prm
        {
            //yetki kontrolü gelecek 

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {

                //buradaki IslemTuru, Id, Yukle BaseEditForm dan geldi
                frm.IslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefresYapilacak ? frm.Id : 0;  //formda değişiklik yapılacaksa true oldu o zaman bu formun id sibni geri gönder, değilse 0 olarak gönder diyor
            }
        }

       
    }
}
