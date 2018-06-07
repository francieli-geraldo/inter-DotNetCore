using System;
using System.Collections.Generic;

namespace DalStandard.Repositories
{
    public class ClienteRepository : IRepository<Models.Cliente>
    {
        private readonly MaisCadastrosContext Context;

        public ClienteRepository(MaisCadastrosContext context)
        {
            Context = context;
        }

        public bool Delete(object id)
        {
            var obj = Context.Clientes.Find(id);

            if (obj == null)
                return false;

            Context.Remove(obj);

            Context.SaveChanges();

            return true;
        }

        public Models.Cliente Get(object id)
        {
            throw new NotImplementedException();
        }

        public List<Models.Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(object id)
        {
            throw new NotImplementedException();
        }
    }
}
