using lms.Repository.Contracts;
using lms.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Service.Base
{
    public class BaseService<T>: IBaseService<T> where T:class
    {

        private IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }


        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }

        public virtual bool Remove(T entity)
        {
            return _repository.Remove(entity);
        }

        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
