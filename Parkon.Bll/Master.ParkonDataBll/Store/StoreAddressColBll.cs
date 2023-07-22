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

namespace Prkn.Bll.Master.PrknDataBll.Store
{
    public class StoreAddressColBll : BaseBll<Store_AddressCol, PrknDataContext>
    {
        public StoreAddressColBll()
        {
            _uow = new UnitOfWork<Store_AddressCol>(new PrknDataContext());
            DefaultValues();
        }

        public override TResult GetSingle<TResult>(Expression<Func<Store_AddressCol, bool>> filter, Expression<Func<Store_AddressCol, TResult>> selector)
        {
            return base.GetSingle(filter, selector);
        }
        public override IQueryable<TResult> GetList<TResult>(Expression<Func<Store_AddressCol, bool>> filter, Expression<Func<Store_AddressCol, TResult>> selector)
        {
            return base.GetList(filter, selector);
        }

        public override string Insert(Store_AddressCol entity)
        {
            return base.Insert(entity);
        }
        public override string InsertRange(List<Store_AddressCol> entity)
        {
            return base.InsertRange(entity);
        }

        public override string Update(Store_AddressCol currentEntity)
        {

            return base.Update(currentEntity);
        }
        public override string UpdateOnlyChange(Store_AddressCol currentEntity, Store_AddressCol oldEntity, Expression<Func<Store_AddressCol, bool>> filter)
        {
            return base.UpdateOnlyChange(currentEntity, oldEntity, filter);
        }
        public override string UpdateRange(List<Store_AddressCol> currentEntity)
        {
            return base.UpdateRange(currentEntity);
        }

        public override string DeleteSoft(Store_AddressCol currentEntity)
        {
            return base.DeleteSoft(currentEntity);
        }
        public override string DeleteHard(Store_AddressCol entity)
        {
            return base.DeleteHard(entity);
        }
        public override string DeleteHardRange(List<Store_AddressCol> entity)
        {
            return base.DeleteHardRange(entity);
        }

        public override string TableTruncate()
        {
            return base.TableTruncate();
        }

        public long MyCrud(IslemTuru islemturu, Store_AddressCol Data)
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
        public List<Store_AddressCol> ListRefresh()
        {
            return GetList(null, x => x).ToList();
        }
        public class ModelDataEdit : Store_AddressCol
        {
        }

    }
}
