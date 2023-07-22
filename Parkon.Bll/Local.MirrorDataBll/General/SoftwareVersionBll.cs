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

namespace Prkn.Bll.Local.MirrorDataBll.General
{
    public class SoftwareVersionBll : BaseBll<SoftwareVersion, MirrorDataContext>
    {
        public SoftwareVersionBll()
        {
            _uow = new UnitOfWork<SoftwareVersion>(new MirrorDataContext());
            DefaultValues();
        }

        public override TResult GetSingle<TResult>(Expression<Func<SoftwareVersion, bool>> filter, Expression<Func<SoftwareVersion, TResult>> selector)
        {
            return base.GetSingle(filter, selector);
        }
        public override IQueryable<TResult> GetList<TResult>(Expression<Func<SoftwareVersion, bool>> filter, Expression<Func<SoftwareVersion, TResult>> selector)
        {
            return base.GetList(filter, selector);
        }

        public override string Insert(SoftwareVersion entity)
        {
            return base.Insert(entity);
        }
        public override string InsertRange(List<SoftwareVersion> entity)
        {
            return base.InsertRange(entity);
        }

        public override string Update(SoftwareVersion currentEntity)
        {

            return base.Update(currentEntity);
        }
        public override string UpdateOnlyChange(SoftwareVersion currentEntity, SoftwareVersion oldEntity, Expression<Func<SoftwareVersion, bool>> filter)
        {
            return base.UpdateOnlyChange(currentEntity, oldEntity, filter);
        }
        public override string UpdateRange(List<SoftwareVersion> currentEntity)
        {
            return base.UpdateRange(currentEntity);
        }

        public override string DeleteSoft(SoftwareVersion currentEntity)
        {
            return base.DeleteSoft(currentEntity);
        }
        public override string DeleteHard(SoftwareVersion entity)
        {
            return base.DeleteHard(entity);
        }
        public override string DeleteHardRange(List<SoftwareVersion> entity)
        {
            return base.DeleteHardRange(entity);
        }

        public override string TableTruncate()
        {
            return base.TableTruncate();
        }

        public long MyCrud(IslemTuru islemturu, SoftwareVersion Data)
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
        public List<SoftwareVersion> ListRefresh()
        {
            return GetList(null, x => x).ToList();
        }
        public class ModelDataEdit : SoftwareVersion
        {
        }

    }
}
