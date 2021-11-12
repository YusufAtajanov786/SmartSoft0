using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IBaseContract<T>
    {
        public IQueryable<T> FindAll(bool tracking);
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool tracking);
        public void Update(T entity);
        public void Delete(T entity);
        public T Create(T entity);
    }
}
