using System;
using System.Collections.Generic;

namespace DotBlog.Core.Contracts
{
    public interface IRepository<T, TKey> where T:IIdentity<TKey>
    {
        int Count();
        int Count(Func<T, bool> filter);
        int Count<TK>(int page, int pagesize, Func<T, TK> orderBy);

        IEnumerable<T> All();
        IEnumerable<T> All(Func<T, bool> filter);
        IEnumerable<T> All<TK>(int page, int pagesize, Func<T, TK> orderBy);

        T Get(Func<T, bool> filter);
        T Get(TKey key);

        void Delete(T item);
        T Update(T item);
        T Add(T item);
    }
}