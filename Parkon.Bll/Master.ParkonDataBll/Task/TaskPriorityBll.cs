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
    public class TaskPriorityBll : BaseBll<Task_Priority, PrknDataContext>
    {
        public TaskPriorityBll()
        {
            _uow = new UnitOfWork<Task_Priority>(new PrknDataContext());
            DefaultValues();
        }

        public override TResult GetSingle<TResult>(Expression<Func<Task_Priority, bool>> filter, Expression<Func<Task_Priority, TResult>> selector)
        {
            return base.GetSingle(filter, selector);
        }
        public override IQueryable<TResult> GetList<TResult>(Expression<Func<Task_Priority, bool>> filter, Expression<Func<Task_Priority, TResult>> selector)
        {
            return base.GetList(filter, selector);
        }

        public override string Insert(Task_Priority entity)
        {
            return base.Insert(entity);
        }
        public override string InsertRange(List<Task_Priority> entity)
        {
            return base.InsertRange(entity);
        }

        public override string Update(Task_Priority currentEntity)
        {

            return base.Update(currentEntity);
        }
        public override string UpdateOnlyChange(Task_Priority currentEntity, Task_Priority oldEntity, Expression<Func<Task_Priority, bool>> filter)
        {
            return base.UpdateOnlyChange(currentEntity, oldEntity, filter);
        }
        public override string UpdateRange(List<Task_Priority> currentEntity)
        {
            return base.UpdateRange(currentEntity);
        }

        public override string DeleteSoft(Task_Priority currentEntity)
        {
            return base.DeleteSoft(currentEntity);
        }
        public override string DeleteHard(Task_Priority entity)
        {
            return base.DeleteHard(entity);
        }
        public override string DeleteHardRange(List<Task_Priority> entity)
        {
            return base.DeleteHardRange(entity);
        }

        public override string TableTruncate()
        {
            return base.TableTruncate();
        }

        public long MyCrud(IslemTuru islemturu, Task_Priority Data)
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
        public List<Task_Priority> ListRefresh()
        {
            return GetList(null, x => x).ToList();
        }
        public class ModelDataEdit : Task_Priority
        {
        }

    }
}
