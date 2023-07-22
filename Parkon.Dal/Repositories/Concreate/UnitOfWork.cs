using Prkn.Dal.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Dal.Repositories.Concreate
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        #region Variables
        private readonly DbContext _context; 
        #endregion

        public UnitOfWork(DbContext context)
        {
            if (context == null) return;
            _context = context;
        }
        public IRepository<T> Rep => new Repository<T>(_context);
        public string Save()
        {
            string mesaj = "";
            int ResultGet = 0;
            try
            {
                ResultGet = _context.SaveChanges();

                if (ResultGet > 0)
                {
                    mesaj = "OK";
                }
                else
                {

                }
            }
            catch (DbUpdateException ex)
            {
          
                var sqlex = (SqlException)ex.InnerException? .InnerException;
                if(sqlex == null)
                {
                    mesaj = ex.Message;
                    return mesaj;
                }

                switch (sqlex.Number)
                {
                    case 208: //Sql den gelen hata
                        mesaj = "208 - İşlem yapmak istediğiniz tablo DB'de bulunamadı";
                        break;

                    case 547:
                        mesaj = "547 - Seçilen kartın işlem görmüş hareketleri var. Kart silinemez.";
                        break;
                    case 2601:
                    case 2627:
                        mesaj = "2601/20627 - Girmiş olduğunuz Id daha önce kullanılmıştır";
                        break;
                    case 4060:
                        mesaj = "4060 - İşlem yapmak istediğiniz DB Suncuda bulunamadı.";
                        break;
                    case 18456:
                        mesaj = "18456 - Server bağlantısı için kullanılan kullanıcı adı ya da şifre hatalıdır.";
                        break;
                    default:
                        mesaj = sqlex.Number + " - " + sqlex.Message;
                        break;
                }

                return mesaj;
            }
            catch (Exception ex)
            {
                mesaj = ex.Message;
                return mesaj;
            }

            return mesaj;
        }

        #region IDisposable Support
        private bool disposedValue = false; 
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
