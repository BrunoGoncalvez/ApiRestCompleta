using ARC.Data.Repository;
using ARC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Data.Implement
{
    public class ClientRepository : IClientRepository
    {

        private readonly MainContext _db;

        public ClientRepository(MainContext db)
        {
            _db = db;
        }

        public async Task Add(Client client)
        {
            await _db.AddAsync(client);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Client> GetAll()
        {
            return _db.Client;
        }

    }
}
