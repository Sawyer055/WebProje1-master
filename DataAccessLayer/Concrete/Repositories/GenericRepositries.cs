using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepositries<T> : IRepository<T> where T : class
    {

        Context c = new Context();

        DbSet<T> _object;

        public GenericRepositries()
        {
            _object = c.Set<T>();
        }
        public void delete(T entity)
        {
            var deletedEntity = c.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
                return _object.SingleOrDefault(filter);
        }

        public void insert(T entity)
        {
            var addedEntity = c.Entry(entity);
            addedEntity.State = EntityState.Added;
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void update(T entity)
        {
            var updatedEntity = c.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
