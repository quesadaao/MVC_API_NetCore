using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;
using Solution.DO.Interfaces;
using Solution.DAL.EF;
using Solution.DAL;

namespace Solution.BS
{
    public class Suppliers : ICRUD<data.Suppliers>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Suppliers(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.Suppliers t)
        {
            new Solution.DAL.Suppliers(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Suppliers> GetAll()
        {
            return new Solution.DAL.Suppliers(_solutionDBContext).GetAll();
        }

        public data.Suppliers GetOneById(int id)
        {
            return new Solution.DAL.Suppliers(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Suppliers t)
        {
            new Solution.DAL.Suppliers(_solutionDBContext).Insert(t);
        }

        public void Updated(data.Suppliers t)
        {
            new Solution.DAL.Suppliers(_solutionDBContext).Updated(t);
        }
    }
}
