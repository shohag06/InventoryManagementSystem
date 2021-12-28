using System;
using System.Collections.Generic;
using System.Text;

namespace lms.Repository.Contracts
{
    public interface IRepository<T> where T:class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T enetity);
        T GetById(int id);
        ICollection<T> GetAll();
    }
}
