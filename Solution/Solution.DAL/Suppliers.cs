using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class Suppliers : ICRUD<data.Suppliers>
    {
        private Repository<data.Suppliers> _repository = null;
        public Suppliers(SolutionDBContext solutionDBContext) {
            _repository = new Repository<data.Suppliers>(solutionDBContext);
        }

        public void Delete(data.Suppliers t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Suppliers> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Suppliers GetOneById(int id)
        {
            return _repository.GetOnebyId(id);
        }

        public void Insert(data.Suppliers t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Updated(data.Suppliers t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
