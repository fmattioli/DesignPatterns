using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Infrastructure.Read.Persistence.Interfaces
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate = null);
        T Find(int id);
    }
}
