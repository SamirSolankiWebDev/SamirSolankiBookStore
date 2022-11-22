using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace SamirSolankiBooks.DataAccess.Repository.IRepository
{
   public interface IRepository<T> where T:class
    {
        T Get(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
            string includeProperties = null);

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,

            string includeProperties = null);
        void Add(T entity); //add an entity
        void Remove(int id); // to fremove4 an objecvt or category
        void Remove(T entity); //another way to remove an object 
        void RemoveRange(IEnumerable<T>entity); //removes a complete range of entities

    }
}
    