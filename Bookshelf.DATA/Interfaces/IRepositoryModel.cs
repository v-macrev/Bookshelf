using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshelf.DATA.Interfaces
{
    public interface IRepositoryModel<T> where T : class
    {
        List<T> GetAll();
        T GetById(params object[] id);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        void SaveChanges();
    }
}
