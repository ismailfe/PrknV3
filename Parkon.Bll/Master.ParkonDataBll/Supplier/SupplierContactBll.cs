﻿using DevExpress.XtraEditors;
using Prkn.Bll.Base;
using Prkn.Bll.Interfaces;
using Prkn.Common;
using Prkn.Common.Design.Controls;
using Prkn.Common.Enums;
using Prkn.Common.Functions;
using Prkn.Common.Generate;
using Prkn.Common.Variables;
using Prkn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prkn.Bll.FileDirectory;
using Prkn.Data.Master;
using System.Linq.Expressions;
using Prkn.Dal.Repositories.Concreate;

namespace Prkn.Bll.Master.PrknDataBll.Supplier
{
    public class SupplierContactBll : BaseBll<Supplier_Contact, PrknDataContext>
    {
        public SupplierContactBll()
        {
            _uow = new UnitOfWork<Supplier_Contact>(new PrknDataContext());
            DefaultValues();
        }

        public override TResult GetSingle<TResult>(Expression<Func<Supplier_Contact, bool>> filter, Expression<Func<Supplier_Contact, TResult>> selector)
        {
            return base.GetSingle(filter, selector);
        }
        public override IQueryable<TResult> GetList<TResult>(Expression<Func<Supplier_Contact, bool>> filter, Expression<Func<Supplier_Contact, TResult>> selector)
        {
            return base.GetList(filter, selector);
        }

        public override string Insert(Supplier_Contact entity)
        {
            return base.Insert(entity);
        }
        public override string InsertRange(List<Supplier_Contact> entity)
        {
            return base.InsertRange(entity);
        }

        public override string Update(Supplier_Contact currentEntity)
        {

            return base.Update(currentEntity);
        }
        public override string UpdateOnlyChange(Supplier_Contact currentEntity, Supplier_Contact oldEntity, Expression<Func<Supplier_Contact, bool>> filter)
        {
            return base.UpdateOnlyChange(currentEntity, oldEntity, filter);
        }
        public override string UpdateRange(List<Supplier_Contact> currentEntity)
        {
            return base.UpdateRange(currentEntity);
        }

        public override string DeleteSoft(Supplier_Contact currentEntity)
        {
            return base.DeleteSoft(currentEntity);
        }
        public override string DeleteHard(Supplier_Contact entity)
        {
            return base.DeleteHard(entity);
        }
        public override string DeleteHardRange(List<Supplier_Contact> entity)
        {
            return base.DeleteHardRange(entity);
        }

        public override string TableTruncate()
        {
            return base.TableTruncate();
        }

        public long MyCrud(IslemTuru islemturu, Supplier_Contact Data)
        {
            long Result = 0;

            switch (islemturu)
            {
                case IslemTuru.Insert:
                    Insert(Data);
                    var SonKayit = GetList(x => x != null, x => x).OrderByDescending(x => x.Id).FirstOrDefault();
                    Result = SonKayit.Id;
                    break;
                case IslemTuru.Update:
                    Update(Data);

                    Result = Data.Id;
                    break;
                case IslemTuru.Delete:
                    DeleteHard(Data);
                    break;
                case IslemTuru.ListRefresh:

                    break;
                default:
                    break;
            }

            return Result;
        }
        public List<Supplier_Contact> ListRefresh()
        {
            return GetList(null, x => x).ToList();
        }
        public class ModelDataEdit : Supplier_Contact
        {
        }

    }
}
