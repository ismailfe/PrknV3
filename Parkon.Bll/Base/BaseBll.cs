using Prkn.Dal.Repositories.Concreate;
using Prkn.Spersys.Bll.Functions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Prkn.Bll.Base
{
    public class BaseBll<T, TContext> where T : class where TContext : DbContext // , IBaseBll<T> 
    {
        #region Variables

        protected UnitOfWork<T> _uow;
        //protected DbContext _context;
        #endregion

        public BaseBll()
        {
        }

        #region Get Methods
        public virtual TResult GetSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return _uow.Rep.Find(filter, selector);
        }
        public virtual IQueryable<TResult> GetList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return _uow.Rep.Select(filter, selector);
        }
        public virtual IQueryable<TResult> SqlQuery<TResult>(string query, Expression<Func<T, TResult>> selector, params string[] args)
        {
            return _uow.Rep.SqlQuery(query, selector, args);
        }
        #endregion

        #region Insert Methods
        public virtual string Insert(T entity)
        {
            //Validation
            //if (!Validation(IslemTuru.EntityInsert, null, entity, filter)) return false;
            var createtDate = entity.GetType().GetProperty("CreateDate");
            createtDate.SetValue(entity, DateTime.Now);
            _uow.Rep.Insert(entity);
            return _uow.Save();
        }
        public virtual string InsertRange(List<T> entity)
        {
            //Validation
            //if (!Validation(IslemTuru.EntityInsert, null, entity, filter)) return false;
            for (int i = 0; i < entity.Count; i++)
            {
                var createtDate = entity[i].GetType().GetProperty("CreateDate");
                createtDate.SetValue(entity[i], DateTime.Now);
            }
            _uow.Rep.InsertRange(entity);
            return _uow.Save();
        }
        #endregion

        #region Update Methods
        public virtual string UpdateOnlyChange(T currentEntity, T oldEntity, Expression<Func<T, bool>> filter)
        {
            //Validation
            //if (!Validation(IslemTuru.EntityUpdate, oldEntity, currentEntity, filter)) return false;

            var DegisenAlanlar = oldEntity.DegisenAlanlariGetir(currentEntity);
            if (DegisenAlanlar.Count == 0)
            {
                return "true";
            }
            else
            {
                _uow.Rep.UpdateOnlyChange(currentEntity, DegisenAlanlar);
                return _uow.Save();
            }
        }
        public virtual string Update(T currentEntity)
        {
            //Validation
            //if (!Validation(IslemTuru.EntityUpdate, oldEntity, currentEntity, filter)) return false;
            var updateDate = currentEntity.GetType().GetProperty("UpdateDate");
            updateDate.SetValue(currentEntity, DateTime.Now);
            _uow.Rep.Update(currentEntity);
            return _uow.Save();
        }
        public virtual string UpdateRange(List<T> currentEntity)
        {
            //Validation
            //if (!Validation(IslemTuru.EntityUpdate, oldEntity, currentEntity, filter)) return false;
            for (int i = 0; i < currentEntity.Count; i++)
            {
                var updateDate = currentEntity[i].GetType().GetProperty("UpdateDate");
                updateDate.SetValue(currentEntity[i], DateTime.Now);
            }
            _uow.Rep.UpdateRange(currentEntity);
            return _uow.Save();
        }


        #endregion

        #region Delete Methods
        public virtual string DeleteSoft(T currentEntity)
        {
            //Validation
            //if (!Validation(IslemTuru.EntityUpdate, oldEntity, currentEntity, filter)) return false;
            try
            {
                var varStatus = currentEntity.GetType().GetProperty("VarStatus");
                var deleteDate = currentEntity.GetType().GetProperty("DeleteDate");
                varStatus.SetValue(currentEntity, "Deleted");
                deleteDate.SetValue(currentEntity, DateTime.Now);
                _uow.Rep.Update(currentEntity);
                return _uow.Save();
            }
            catch (Exception hata)
            {
                return "Error " + hata.ToString();
            }

        }
        public virtual string DeleteHard(T entity)
        {
            _uow.Rep.Delete(entity);
            return _uow.Save();
        }
        public virtual string DeleteHardRange(List<T> entity)
        {
            _uow.Rep.DeleteRange(entity);
            return _uow.Save();
        }
        public virtual string TableTruncate()
        {
            try
            {
                _uow.Rep.TableTruncate();
                return "true";// _uow.Save();
            }
            catch (Exception hata)
            {
                return "Error " + hata.ToString();// _uow.Save();
            }


        }
        #endregion


        public virtual string DefaultValues()
        {
            return "OK";
        }

        #region IDisposable Support
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }
        public void Dispose()
        {
            //_ctrl.Dispose();
            //_uow.Dispose();

        }
        #endregion

    }
}
