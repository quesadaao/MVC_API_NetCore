using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;


namespace Solution.DAL
{
    public class Categories : ICRUD<data.Categories>
    {
        private Repository<data.Categories> _repository = null;
        public Categories(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.Categories>(solutionDBContext);
        }

        public void Delete(data.Categories t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Categories> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Categories GetOneById(int id)
        {
            return _repository.GetOnebyId(id);
        }

        public void Insert(data.Categories t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Updated(data.Categories t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
