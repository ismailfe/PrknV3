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
    public class KeywordBll : BaseBll<Keyword, MirrorDataContext>
    {
        public KeywordBll()
        {
            _uow = new UnitOfWork<Keyword>(new MirrorDataContext());
            DefaultValues();
        }

        public override TResult GetSingle<TResult>(Expression<Func<Keyword, bool>> filter, Expression<Func<Keyword, TResult>> selector)
        {
            return base.GetSingle(filter, selector);
        }
        public override IQueryable<TResult> GetList<TResult>(Expression<Func<Keyword, bool>> filter, Expression<Func<Keyword, TResult>> selector)
        {
            return base.GetList(filter, selector);
        }

        public override string Insert(Keyword entity)
        {
            return base.Insert(entity);
        }
        public override string InsertRange(List<Keyword> entity)
        {
            return base.InsertRange(entity);
        }

        public override string Update(Keyword currentEntity)
        {

            return base.Update(currentEntity);
        }
        public override string UpdateOnlyChange(Keyword currentEntity, Keyword oldEntity, Expression<Func<Keyword, bool>> filter)
        {
            return base.UpdateOnlyChange(currentEntity, oldEntity, filter);
        }
        public override string UpdateRange(List<Keyword> currentEntity)
        {
            return base.UpdateRange(currentEntity);
        }

        public override string DeleteSoft(Keyword currentEntity)
        {
            return base.DeleteSoft(currentEntity);
        }
        public override string DeleteHard(Keyword entity)
        {
            return base.DeleteHard(entity);
        }
        public override string DeleteHardRange(List<Keyword> entity)
        {
            return base.DeleteHardRange(entity);
        }

        public override string TableTruncate()
        {
            return base.TableTruncate();
        }

        public long MyCrud(IslemTuru islemturu, Keyword Data)
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
        public List<Keyword> ListRefresh()
        {
            return GetList(null, x => x).ToList();
        }
        public class ModelDataEdit : Keyword
        {
        }

    }
}
