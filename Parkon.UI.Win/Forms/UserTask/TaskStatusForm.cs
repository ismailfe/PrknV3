﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Emikon.Parkon.UI.Win.Forms.Base;
using Emikon.Parkon.UI.Win.Functions;
using Emikon.Parkon.Common.Variables;
using Emikon.Parkon.Common.Enums;
using Emikon.Parkon.Common.Functions;
using Emikon.Parkon.Common.Generate;
using Emikon.Parkon.Common.Message;
using Emikon.Parkon.Common.Design.Controls;
using Emikon.Parkon.Bll.General;
using Emikon.Parkon.Bll.Task;

namespace Emikon.Parkon.UI.Win.Forms.Task
{
    public partial class TaskStatusForm : BaseListEditForm
    {
        public TaskStatusForm()
        {
            _userScreen = UserScreen.Gorevler;
            Yukle();

            InitializeComponent();
            Text                = "Görev Durum Listesi";
            Tablo.ViewCaption   = Text;
            EventsLoad();       // Ribbon
            ListeRefresh();     // Ribbon

            LayoutEvents();
        }
        void LayoutEvents()
        {
            txtName.KeyPress += TextCorrection.TextEdit_KeyPressForUpperEnglish; 
            txtCode.KeyPress += TextCorrection.TextEdit_KeyPressForUpperEnglish;
        }
        protected override void ListeRefresh()
        {
            YapilacakIslem(IslemTuru.ListRefresh);
        }
        protected override void EntityInsert()
        {
            YapilacakIslem(IslemTuru.Insert);
        }
        protected override void EntityUpdate()
        {
            YapilacakIslem(IslemTuru.Update);

        }
        protected override void EntityDelete()
        {
            YapilacakIslem(IslemTuru.Delete);
        }
        private void YapilacakIslem(IslemTuru islemturu)
        {
            var Data                    = new Model.Task_Status();                  // Contollerdan gelen ve Fonksiyon içinde kullanılacak Data
            var _aktifDataFromTable     = new Model.Task_Status();                  // Fonksiyon içinde kullanılacak Data
            var _propertyFilling        = GeneralFunctions.ClassPropertyFilling(AktifData, _aktifDataFromTable);
            long selectFocusId          = 0;                                        // İşlem yapıldıktan sonra focus olacak ID

            if (IslemTuru.ListRefresh != islemturu)
            {
                if (IslemTuru.Insert != islemturu)
                {
                    if (_propertyFilling)
                        Data = _aktifDataFromTable;

                    if (IslemTuru.Update == islemturu && !_propertyFilling) //Tablo boş ve gelen işlem Update ise Insert işlemine geç
                    {
                        islemturu = IslemTuru.Insert;
                    }
                }

                List<object> OutOfCheck = new List<object>
                {
                    txtCode,
                    txtComment,
                };

                if (Checks.DataLayoutValueFillingOK(DataLayoutControl, OutOfCheck))
                {
                    Data.Id         = Generator.CreateId(islemturu, Data.Id);
                    Data.UserId     = Dynamic.OnlineUser.Id;
                    Data.Name       = txtName.Text;
                    Data.Code       = txtCode.Text;
                    Data.Comment    = txtComment.Text;
                }
                else
                {
                    return;
                }

                selectFocusId = TaskStatusBll.MyCrud(islemturu, Data);
            }

            var myList = TaskStatusBll.ListRefresh();
            Tablo.GridControl.DataSource = myList;
            Tablo.RowFocus("Id", selectFocusId);
        }
    }
}