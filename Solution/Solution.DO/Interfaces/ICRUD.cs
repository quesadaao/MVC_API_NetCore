using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.DO.Interfaces
{
    public interface ICRUD<T>
    {
        void Insert(T t);
        void Updated(T t);
        void Delete(T t);
        IEnumerable<T> GetAll();
        T GetOneById(int id);
    }
}
