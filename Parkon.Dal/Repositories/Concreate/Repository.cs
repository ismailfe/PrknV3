using Prkn.Dal.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;


namespace Prkn.Dal.Repositories.Concreate
{
    public class Repository<Tentity> : IRepository<Tentity> where Tentity : class
    {
        protected DbContext _context;
        private DbSet<Tentity> _dbSet;

        public Repository(DbContext context)
        {
            if (context == null) return;
            _context = context;
            _dbSet = _context.Set<Tentity>();
        }

        #region Insert
        //Gelen Entity Ekle
        public void Insert(Tentity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }
        //Gelen Entityleri EKle
        public void InsertRange(IEnumerable<Tentity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
        }

        #endregion

        #region Update
        //Gelen Entity Güncelle
        public void Update(Tentity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        //Gelen Entity deki sadece değişmiş fieldları güncelle
        public void UpdateOnlyChange(Tentity entity, IEnumerable<string> fields)
        {
            _dbSet.Attach(entity);
            var entry = _context.Entry(entity);

            foreach (var field in fields)
            {
                entry.Property(field).IsModified = true; //Güncellenecek entry bul ve yap
            }

        }
        //Gelen Entityleri Güncelle
        public void UpdateRange(IEnumerable<Tentity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }
        #endregion

        #region Delete
        //Gelen ENtity Sil
        public void Delete(Tentity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }
        //Gelen Entityleri Sil
        public void DeleteRange(IEnumerable<Tentity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }


        public void TableTruncate()
        {      
            string TableName = typeof(Tentity).Name;
            //FOR SQLCE
            try
            {
         
                var constr = _context.Database.Connection.ConnectionString;
                _context.Database.ExecuteSqlCommand($"DELETE FROM {TableName}");
                Table_AutoNumber_Reset(TableName, "0");

                SqlCeConnection DBConnection;
                SqlCeConnection Connect()
                {
                    DBConnection = new SqlCeConnection(constr);
                    if (DBConnection.State != System.Data.ConnectionState.Open)
                    {
                        try
                        {
                            DBConnection.Open();
                        }
                        catch
                        {
                        }
                    }
                    // Database Aç

                    return DBConnection;
                }
                string Table_AutoNumber_Reset(string tableName, string FirstAutoNumber)
                {
                    try
                    {
                        string StringCMD = "ALTER TABLE " + tableName + " ALTER COLUMN " + "ID" + " IDENTITY (1,1)";
                        SqlCeCommand Cmd = new SqlCeCommand(StringCMD, Connect()); // "DBCC CHECKIDENT ('" + tableName + "', RESEED," + FirstAutoNumber + ")", Connect());
                        Cmd.ExecuteNonQuery();
                        Cmd.Connection.Close();
                        return " 1 OK";
                    }
                    catch (Exception Hata)
                    {
                        return "-1 ERR: " + Hata.ToString();
                    }

                }
            }
            catch (Exception hata)
            {
                var a = hata.ToString();
            }

            // FOR SQL
            try
            {
                _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('[" + TableName + "]', RESEED, 0);");
                _context.Database.ExecuteSqlCommand($"TRUNCATE TABLE {typeof(Tentity).Name}");
            
            }
            catch (Exception hata)
            {
                var a = hata.ToString();
            }

        }
        #endregion

        #region Find
        public TResult Find<TResult>(Expression<Func<Tentity, bool>> filter, Expression<Func<Tentity, TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector).FirstOrDefault() : _dbSet.Where(filter).Select(selector).FirstOrDefault();
        }
        public IQueryable<TResult> FindRange<TResult>(Expression<Func<Tentity, bool>> filter, Expression<Func<Tentity, TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector) : _dbSet.Where(filter).Select(selector);
        }
        #endregion

        #region Select
        public IQueryable<TResult> Select<TResult>(Expression<Func<Tentity, bool>> filter, Expression<Func<Tentity, TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector) : _dbSet.Where(filter).Select(selector);
        }
        #endregion

        public IQueryable<TResult> SqlQuery<TResult>(string query, Expression<Func<Tentity, TResult>> selector, params object[] args)
        {
            var result = _dbSet.SqlQuery(query, args);
            return (IQueryable<TResult>)result;
        }

        public int Count(Expression<Func<Tentity, bool>> filter = null)
        {
            return filter == null ? _dbSet.Count() : _dbSet.Count(filter);
        }

        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose(); //Context i disponse yap
                }
                _disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Repository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        #endregion
    }
}
