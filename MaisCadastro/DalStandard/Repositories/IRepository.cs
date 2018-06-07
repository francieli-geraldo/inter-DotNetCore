using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DalStandard.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity Get(object id);
        bool Update(object id);
        bool Delete(object id);
    }
}
