using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using DotBlog.Core.Contracts;

namespace DotBlog.Core.Repository
{
    public class Repository<T, TKey> : IRepository<T, TKey>
        where T : class, IIdentity<TKey>
    {
        private DotBlogContext _context;

        public Repository(DotBlogContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return All().Count();
        }

        public int Count(Func<T, bool> filter)
        {
            return All(filter).Count();
        }

        public int Count<TK>(int page, int pagesize, Func<T, TK> orderBy)
        {
            return All(page, pagesize, orderBy).Count();
        }

        public IEnumerable<T> All()
        {
            return _context.Set<T>();
        }

        public IEnumerable<T> All(Func<T, bool> filter)
        {
            return _context.Set<T>().Where(filter);
        }

        public IEnumerable<T> All<TK>(int page, int pagesize, Func<T, TK> orderBy)
        {
            var skip = page*pagesize;
            return _context.Set<T>().OrderBy(orderBy).Skip(skip).Take(pagesize);
        }

        public T Get(Func<T, bool> filter)
        {
            return All(filter).FirstOrDefault();
        }

        public T Get(TKey key)
        {
            return All(x => Equals(x.Id, key)).FirstOrDefault();
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public T Update(T item)
        {
            _context.Set<T>().AddOrUpdate(item);
            _context.SaveChanges();
            return All(x => Equals(x.Id, item.Id)).FirstOrDefault();
        }

        public T Add(T item)
        {
            _context.Set<T>().AddOrUpdate(item);
            _context.SaveChanges();
            return Get(item.Id);
        }
    }
}