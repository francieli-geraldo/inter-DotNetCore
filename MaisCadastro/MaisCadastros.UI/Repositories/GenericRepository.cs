using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MaisCadastrosContext Context;
        protected readonly DbSet<TEntity> DbSet;

        public GenericRepository(MaisCadastrosContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public bool Delete(object id)
        {
            var obj = DbSet.Find(id);

            if (obj == null)
                return false;

            Context.Remove(obj);

            Context.SaveChanges();

            return true;
        }

        public TEntity Get(object id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(object id)
        {
            throw new NotImplementedException();
        }
    }
}
