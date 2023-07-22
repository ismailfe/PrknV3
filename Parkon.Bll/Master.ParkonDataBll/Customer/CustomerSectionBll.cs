using DevExpress.XtraEditors;
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

namespace Prkn.Bll.Master.PrknDataBll.Customer
{
    public class CustomerSectionBll : BaseBll<Customer_Section, PrknDataContext>
    {
        public CustomerSectionBll()
        {
            _uow = new UnitOfWork<Customer_Section>(new PrknDataContext());
            DefaultValues();
        }

        public override TResult GetSingle<TResult>(Expression<Func<Customer_Section, bool>> filter, Expression<Func<Customer_Section, TResult>> selector)
        {
            return base.GetSingle(filter, selector);
        }
        public override IQueryable<TResult> GetList<TResult>(Expression<Func<Customer_Section, bool>> filter, Expression<Func<Customer_Section, TResult>> selector)
        {
            return base.GetList(filter, selector);
        }

        public override string Insert(Customer_Section entity)
        {
            return base.Insert(entity);
        }
        public override string InsertRange(List<Customer_Section> entity)
        {
            return base.InsertRange(entity);
        }

        public override string Update(Customer_Section currentEntity)
        {

            return base.Update(currentEntity);
        }
        public override string UpdateOnlyChange(Customer_Section currentEntity, Customer_Section oldEntity, Expression<Func<Customer_Section, bool>> filter)
        {
            return base.UpdateOnlyChange(currentEntity, oldEntity, filter);
        }
        public override string UpdateRange(List<Customer_Section> currentEntity)
        {
            return base.UpdateRange(currentEntity);
        }

        public override string DeleteSoft(Customer_Section currentEntity)
        {
            return base.DeleteSoft(currentEntity);
        }
        public override string DeleteHard(Customer_Section entity)
        {
            return base.DeleteHard(entity);
        }
        public override string DeleteHardRange(List<Customer_Section> entity)
        {
            return base.DeleteHardRange(entity);
        }

        public override string TableTruncate()
        {
            return base.TableTruncate();
        }

        public long MyCrud(IslemTuru islemturu, Customer_Section Data)
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
        public List<Customer_Section> ListRefresh()
        {
            return GetList(null, x => x).ToList();
        }
        public class ModelDataEdit : Customer_Section
        {
        }

    }
}
