using BazarMarket.DataAcces.IRepository.IWorkers;
using BazarMarket.DataAcces.Repository.Workers;
using BazarMarket.Domein.Entity.Workers;
using BazarMarket.Service.IService.IWorkersService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.Service.Service.WorkersService
{
    public class SalesManagerService : ISalesManagerService
    {
        public readonly ISalesManagerRepository repository;
        public SalesManagerService()
        {
            repository = new SalesManagerRepository();
        }
        public Task Add(SalesManager salesManager)
            => repository.Add(salesManager);

        public Task Delete(int Id)
            => repository.Delete(Id);

        public List<SalesManager> GetAllAsync()
            => repository.GetAllAsync();

        public Task Update(int Id, SalesManager salesManager)
            => repository.Update(Id, salesManager);
    }
}
