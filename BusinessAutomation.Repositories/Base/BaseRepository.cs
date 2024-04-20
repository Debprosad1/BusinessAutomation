using BusinessAutomation.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories.Base
{
    public abstract class BaseRepository<T> where T : class
    {
        protected DbContext _db;

        private DbSet<T> Table
        {
            get
            {
                return _db.Set<T>();
            }
        }


        public ICollection<T> GetAll()
        {
            return Table.ToList();
        }

        public virtual bool Add(T entity)
        {
            Table.Add(entity);

            return _db.SaveChanges() > 0;
        }

        public virtual bool Update(T product)
        {
            Table.Update(product);
            return _db.SaveChanges() > 0;
        }

        public bool Remove(T product)
        {

            Table.Remove(product);
            return _db.SaveChanges() > 0;
        }

    }
}
