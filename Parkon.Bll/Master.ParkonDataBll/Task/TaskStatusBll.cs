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

namespace Prkn.Bll.Master.PrknDataBll.Task
{
    public class TaskStatusBll : BaseBll<Task_Status, PrknDataContext>
    {
        public TaskStatusBll()
        {
            _uow = new UnitOfWork<Task_Status>(new PrknDataContext());
            DefaultValues();
        }

        public override TResult GetSingle<TResult>(Expression<Func<Task_Status, bool>> filter, Expression<Func<Task_Status, TResult>> selector)
        {
            return base.GetSingle(filter, selector);
        }
        public override IQueryable<TResult> GetList<TResult>(Expression<Func<Task_Status, bool>> filter, Expression<Func<Task_Status, TResult>> selector)
        {
            return base.GetList(filter, selector);
        }

        public override string Insert(Task_Status entity)
        {
            return base.Insert(entity);
        }
        public override string InsertRange(List<Task_Status> entity)
        {
            return base.InsertRange(entity);
        }

        public override string Update(Task_Status currentEntity)
        {

            return base.Update(currentEntity);
        }
        public override string UpdateOnlyChange(Task_Status currentEntity, Task_Status oldEntity, Expression<Func<Task_Status, bool>> filter)
        {
            return base.UpdateOnlyChange(currentEntity, oldEntity, filter);
        }
        public override string UpdateRange(List<Task_Status> currentEntity)
        {
            return base.UpdateRange(currentEntity);
        }

        public override string DeleteSoft(Task_Status currentEntity)
        {
            return base.DeleteSoft(currentEntity);
        }
        public override string DeleteHard(Task_Status entity)
        {
            return base.DeleteHard(entity);
        }
        public override string DeleteHardRange(List<Task_Status> entity)
        {
            return base.DeleteHardRange(entity);
        }

        public override string TableTruncate()
        {
            return base.TableTruncate();
        }

        public long MyCrud(IslemTuru islemturu, Task_Status Data)
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
        public List<Task_Status> ListRefresh()
        {
            return GetList(null, x => x).ToList();
        }
        public class ModelDataEdit : Task_Status
        {
        }

    }
}
