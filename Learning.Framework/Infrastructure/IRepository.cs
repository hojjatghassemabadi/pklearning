using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Framework.Infrastructure
{
    public interface IRepository<in Tkey, T>
    {
        void Create(T entity);
        List<T> GetAll();
        T Get(Tkey id);
        bool Exists(Expression<Func<T, bool>> expression);
        void Delete(Tkey id);
    }
}
