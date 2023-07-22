using DevExpress.XtraEditors;
using Prkn.Bll.Base;
using Prkn.Bll.Interfaces;
using Prkn.Common;
using Prkn.Common.Design.Controls;
using Prkn.Common.Enums;
using Prkn.Common.Functions;
using Prkn.Common.Generate;
using Prkn.Common.Variables;
using Prkn.Model.Mirror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prkn.Bll.FileDirectory;
using Prkn.Data.Master;
using System.Linq.Expressions;
using Prkn.Dal.Repositories.Concreate;
using Prkn.Data.Local;

namespace Prkn.Bll.Local.MirrorDataBll.Customer
{
        public class CustomerContactBll : BaseBll<Customer_Contact, MirrorDataContext>
    {
        public CustomerContactBll()
        {
            _uow = new UnitOfWork<Customer_Contact>(new MirrorDataContext());
            DefaultValues();
        }

        public override TResult GetSingle<TResult>(Expression<Func<Customer_Contact, bool>> filter, Expression<Func<Customer_Contact, TResult>> selector)
        {
            return base.GetSingle(filter, selector);
        }
        public override IQueryable<TResult> GetList<TResult>(Expression<Func<Customer_Contact, bool>> filter, Expression<Func<Customer_Contact, TResult>> selector)
        {
            return base.GetList(filter, selector);
        }

        public override string Insert(Customer_Contact entity)
        {
            return base.Insert(entity);
        }
        public override string InsertRange(List<Customer_Contact> entity)
        {
            return base.InsertRange(entity);
        }

        public override string Update(Customer_Contact currentEntity)
        {

            return base.Update(currentEntity);
        }
        public override string UpdateOnlyChange(Customer_Contact currentEntity, Customer_Contact oldEntity, Expression<Func<Customer_Contact, bool>> filter)
        {
            return base.UpdateOnlyChange(currentEntity, oldEntity, filter);
        }
        public override string UpdateRange(List<Customer_Contact> currentEntity)
        {
            return base.UpdateRange(currentEntity);
        }

        public override string DeleteSoft(Customer_Contact currentEntity)
        {
            return base.DeleteSoft(currentEntity);
        }
        public override string DeleteHard(Customer_Contact entity)
        {
            return base.DeleteHard(entity);
        }
        public override string DeleteHardRange(List<Customer_Contact> entity)
        {
            return base.DeleteHardRange(entity);
        }

        public override string TableTruncate()
        {
            return base.TableTruncate();
        }

        public long MyCrud(IslemTuru islemturu, Customer_Contact Data)
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
        public List<Customer_Contact> ListRefresh()
        {
            return GetList(null, x => x).ToList();
        }
        public class ModelDataEdit : Customer_Contact
        {
        }

    }
}
