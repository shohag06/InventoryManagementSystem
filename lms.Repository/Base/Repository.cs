using Ims.Data;
using lms.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lms.Repository.Base
{
    public class Repository<T>:IRepository<T> where T : class
    {

        private readonly ApplicationDbContext _db;
        public Repository(ApplicationDbContext db)
        {
           this._db = db;
        }

        private DbSet<T> Table
        {
            get { return _db.Set<T>(); }
        }

        public virtual bool Add(T entity)
        {
            
            
            Table.Add(entity);
            return _db.SaveChanges() > 0;
        }

        public virtual bool Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return _db.SaveChanges() > 0;
        }

        public virtual bool Remove(T entity)
        {
            Table.Remove(entity);
            return _db.SaveChanges() > 0;
        }

        public virtual T GetById(int id)
        {
            return Table.Find(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return Table.ToList();
        }

    }
}
