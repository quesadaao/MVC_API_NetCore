using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Solution.DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> AsQueryble();
        IEnumerable<T> GetAll();
        IEnumerable<T> Search(Expression<Func<T, bool>> predicado);
        T GetOne(Expression<Func<T, bool>> predicado);
        T GetOnebyId(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Commit();
    }
}
