using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Dal.Repositories.Interfaces
{
    //Çeşitli işlemleri tek seferde DB ye göndermek için kullanılacak (Save işlemi)
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        IRepository<T> Rep { get; }
        string Save();
    }
}
