using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Car_Rental.Interfaces
{
   public interface IRepository <TEntity>  where TEntity : class
    {
        TEntity Get(Guid id);
        IList<TEntity> GetAll();
        IList<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
    }
}
