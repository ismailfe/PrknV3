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

namespace Prkn.Bll.Master.PrknDataBll.Offer
{
    public class OfferStatusBll : BaseBll<Offer_Status, PrknDataContext>
    {
        public OfferStatusBll()
        {
            _uow = new UnitOfWork<Offer_Status>(new PrknDataContext());
            DefaultValues();
        }

        public override TResult GetSingle<TResult>(Expression<Func<Offer_Status, bool>> filter, Expression<Func<Offer_Status, TResult>> selector)
        {
            return base.GetSingle(filter, selector);
        }
        public override IQueryable<TResult> GetList<TResult>(Expression<Func<Offer_Status, bool>> filter, Expression<Func<Offer_Status, TResult>> selector)
        {
            return base.GetList(filter, selector);
        }

        public override string Insert(Offer_Status entity)
        {
            return base.Insert(entity);
        }
        public override string InsertRange(List<Offer_Status> entity)
        {
            return base.InsertRange(entity);
        }

        public override string Update(Offer_Status currentEntity)
        {

            return base.Update(currentEntity);
        }
        public override string UpdateOnlyChange(Offer_Status currentEntity, Offer_Status oldEntity, Expression<Func<Offer_Status, bool>> filter)
        {
            return base.UpdateOnlyChange(currentEntity, oldEntity, filter);
        }
        public override string UpdateRange(List<Offer_Status> currentEntity)
        {
            return base.UpdateRange(currentEntity);
        }

        public override string DeleteSoft(Offer_Status currentEntity)
        {
            return base.DeleteSoft(currentEntity);
        }
        public override string DeleteHard(Offer_Status entity)
        {
            return base.DeleteHard(entity);
        }
        public override string DeleteHardRange(List<Offer_Status> entity)
        {
            return base.DeleteHardRange(entity);
        }

        public override string TableTruncate()
        {
            return base.TableTruncate();
        }

        public long MyCrud(IslemTuru islemturu, Offer_Status Data)
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
        public List<Offer_Status> ListRefresh()
        {
            return GetList(null, x => x).ToList();
        }
        public class ModelDataEdit : Offer_Status
        {
        }

    }
}