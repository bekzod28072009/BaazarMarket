using BazarMarket.Domein.Entity.Products;
using BazarMarket.Domein.Entity.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.DataAcces.IRepository.IWorkers
{
    public interface IManagerRepository
    {
        List<Manager> GetAllAsync();

        Task Add(Manager managers);

        Task Update(int Id, Manager managers);

        Task Delete(int Id);
    }
}
