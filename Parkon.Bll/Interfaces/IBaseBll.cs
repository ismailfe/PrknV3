using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Prkn.Bll.Interfaces
{
    public interface IBaseBll<T> : IDisposable
    {
        TResult GetSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);
        IQueryable<TResult> GetList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);
        IQueryable<TResult> SqlQuery<TResult>(string query, params object[] args);
        bool Insert(T entity);
        bool InsertRange(List<T> entity);

        bool UpdateOnlyChange(T currentEntity, T oldEntity, Expression<Func<T, bool>> filter);
        bool Update(T currentEntity);
        bool UpdateRange(List<T> currentEntity);

        bool Delete(T entity);
        bool DeleteRange(List<T> entity);


    }
}
