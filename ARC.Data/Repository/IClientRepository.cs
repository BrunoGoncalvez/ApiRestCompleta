using ARC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC.Data.Repository
{
    public interface IClienteRepository
    {

        // Retorna vários dados
        IQueryable<Client> GetAll();

        // Retorna uma task assicrona
        Task Add(Client client);

    }
}
