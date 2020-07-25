using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;
using Solution.DO.Interfaces;
using Solution.DAL.EF;
using Solution.DAL;


namespace Solution.BS
{
    public class Categories : ICRUD<data.Categories>
    {
        private SolutionDBContext _solutionDBContext = null;
        public Categories(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }
        public void Delete(data.Categories t)
        {
            new Solution.DAL.Categories(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Categories> GetAll()
        {
            return new Solution.DAL.Categories(_solutionDBContext).GetAll();
        }

        public data.Categories GetOneById(int id)
        {
            return new Solution.DAL.Categories(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Categories t)
        {
            t.CategoryId = null;
            new Solution.DAL.Categories(_solutionDBContext).Insert(t);
        }

        public void Updated(data.Categories t)
        {
            new Solution.DAL.Categories(_solutionDBContext).Updated(t);
        }
    }
}
