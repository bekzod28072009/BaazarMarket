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
    public class SalesmanService : ISalesmanService
    {
        public readonly ISalesmanRepository repository;
        public SalesmanService()
        {
            repository = new SalesmanRepository();
        }
        public Task Add(Salesman salesmans)
            => repository.Add(salesmans);

        public Task Delete(int Id)
            => repository.Delete(Id);

        public List<Salesman> GetAllAsync()
            => repository.GetAllAsync();

        public Task Update(int Id, Salesman salesmans)
            => repository.Update(Id, salesmans);
    }
}
