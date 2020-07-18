using Microsoft.EntityFrameworkCore;
using Solution.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Solution.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SolutionDBContext dbContext;
        public Repository(SolutionDBContext context)
        {
            dbContext = context;
        }

        public IQueryable<T> AsQueryble()
        {
            return dbContext.Set<T>().AsQueryable();
        }

        public void Commit()
        {
            dbContext.SaveChanges();
            dbContext.Database.CloseConnection();
        }

        public void Delete(T entity)
        {
            try
            {
                //if (dbContext.Entry<T>(entity).State == EntityState.Detached) {
                //    dbContext.Set<T>().Add(entity);
                //}          
                dbContext.Entry<T>(entity).State = EntityState.Deleted;
            }
            catch (Exception)
            {

            }

        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>();
        }

        public T GetOne(Expression<Func<T, bool>> predicado)
        {
            return dbContext.Set<T>().Where(predicado).FirstOrDefault();
        }

        public T GetOnebyId(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            if (dbContext.Entry<T>(entity).State == EntityState.Detached)
            {
                dbContext.Entry<T>(entity).State = EntityState.Added;
            }
            else
            {
                dbContext.Set<T>().Add(entity);
            }
        }

        public IEnumerable<T> Search(Expression<Func<T, bool>> predicado)
        {
            return dbContext.Set<T>().Where(predicado);
        }

        public void Update(T entity)
        {
            if (dbContext.Entry<T>(entity).State == EntityState.Detached)
            {
                dbContext.Set<T>().Attach(entity);
            }
            dbContext.Entry<T>(entity).State = EntityState.Modified;
        }
    }
}

