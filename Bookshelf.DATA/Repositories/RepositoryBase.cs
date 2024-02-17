using Bookshelf.DATA.Interfaces;
using Bookshelf.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshelf.DATA.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected BookshelftContext _context;
        public bool _saved = true;

        public RepositoryBase(bool saved = true)
        {
            _context = new BookshelftContext();
            _saved = saved;
        }

        public T Add(T entity)
        {
            _context!.Set<T>().Add(entity);
            if (_saved)
            {
                _context.SaveChanges();
            }
            return entity;
        }

        public void Delete(T entity)
        {
            _context!.Set<T>().Remove(entity);
            if (_saved)
            {
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var obj = GetById(id);
            Delete(obj);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public List<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }

        public T GetById(params object[] id)
        {
            return _context.Set<T>().Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            if (_saved)
            {
                _context.SaveChanges();
            }

            return entity;
        }
    }
}
