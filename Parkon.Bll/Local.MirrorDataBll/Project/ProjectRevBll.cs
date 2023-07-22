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

namespace Prkn.Bll.Local.MirrorDataBll.Project
{
    public class ProjectRevBll : BaseBll<Project_Rev, MirrorDataContext>
    {
        public ProjectRevBll()
        {
            _uow = new UnitOfWork<Project_Rev>(new MirrorDataContext());
            DefaultValues();
        }

        public override TResult GetSingle<TResult>(Expression<Func<Project_Rev, bool>> filter, Expression<Func<Project_Rev, TResult>> selector)
        {
            return base.GetSingle(filter, selector);
        }
        public override IQueryable<TResult> GetList<TResult>(Expression<Func<Project_Rev, bool>> filter, Expression<Func<Project_Rev, TResult>> selector)
        {
            return base.GetList(filter, selector);
        }

        public override string Insert(Project_Rev entity)
        {
            return base.Insert(entity);
        }
        public override string InsertRange(List<Project_Rev> entity)
        {
            return base.InsertRange(entity);
        }

        public override string Update(Project_Rev currentEntity)
        {

            return base.Update(currentEntity);
        }
        public override string UpdateOnlyChange(Project_Rev currentEntity, Project_Rev oldEntity, Expression<Func<Project_Rev, bool>> filter)
        {
            return base.UpdateOnlyChange(currentEntity, oldEntity, filter);
        }
        public override string UpdateRange(List<Project_Rev> currentEntity)
        {
            return base.UpdateRange(currentEntity);
        }

        public override string DeleteSoft(Project_Rev currentEntity)
        {
            return base.DeleteSoft(currentEntity);
        }
        public override string DeleteHard(Project_Rev entity)
        {
            return base.DeleteHard(entity);
        }
        public override string DeleteHardRange(List<Project_Rev> entity)
        {
            return base.DeleteHardRange(entity);
        }

        public override string TableTruncate()
        {
            return base.TableTruncate();
        }

        public long MyCrud(IslemTuru islemturu, Project_Rev Data)
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
        public List<Project_Rev> ListRefresh()
        {
            return GetList(null, x => x).ToList();
        }
        public class ModelDataEdit : Project_Rev
        {
        }

    }
}
