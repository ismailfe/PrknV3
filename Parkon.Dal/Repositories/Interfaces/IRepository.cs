using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Dal.Repositories.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        //TEntity GetById(long Id);
        //IEnumerable<TEntity> getAll();
        //void Add(TEntity entity);
        //void AddRange(IEnumerable<TEntity> entities);
        //void Update(TEntity entity);
        //void UpdateRange(IEnumerable<TEntity> entities);
        //void Remove(long Id);
        //void RemoveRange(IEnumerable<TEntity> entities);


        void Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateOnlyChange(TEntity entity, IEnumerable<string> fields);
        void UpdateRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        void TableTruncate();
        IQueryable<TResult> SqlQuery<TResult>(string query, Expression<Func<TEntity, TResult>> slector = null, params object[] args);
        TResult Find                 <TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> slector = null); //T türündeki sorgu cevabı bool ile ok/not ok olarak durum bilgisi gönder.
        IQueryable<TResult> FindRange<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector = null); // Sonucu List olarak döndürür.
        IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector = null); 
        int Count(Expression<Func<TEntity, bool>> filter = null);


    }
}
