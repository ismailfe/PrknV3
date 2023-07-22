using Prkn.UI.Win.Forms.Base;
using Prkn.UI.Win.Forms.Show.Interfaces;
using Prkn.UI.Win.Dokum.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.UI.Win.Forms.Show
{
    class ShowEditForms<TForm> : IBaseFormShow where TForm : BaseEditForm //Interface Gelecek
    {
        public long ShowDialogEditForm(long id) //, params object[] prm)
        {
            //Yetki Kontrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
               // frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }

        public static long ShowDialogEditForm(long id, params object[] prm)
        {
            //Yetki Kontrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
             //   frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }

        public static T ShowDialogEditForm<T>(params object[] prm) where T : IBaseEntity
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return (T)frm.ReturnEntity();
            }
        }
    }
}
