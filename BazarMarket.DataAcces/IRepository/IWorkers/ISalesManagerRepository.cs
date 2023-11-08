using BazarMarket.Domein.Entity.Products;
using BazarMarket.Domein.Entity.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.DataAcces.IRepository.IWorkers
{
    public interface ISalesManagerRepository
    {
        List<SalesManager> GetAllAsync();

        Task Add(SalesManager salesManager);

        Task Update(int Id, SalesManager salesManager);

        Task Delete(int Id);
    }
}
