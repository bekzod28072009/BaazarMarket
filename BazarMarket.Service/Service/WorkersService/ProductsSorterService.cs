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
    public class ProductsSorterService : IProductsSorterService
    {
        public readonly IProductsSorterRepository repository;
        public ProductsSorterService()
        {
            repository = new ProductsSorterRepository();
        }
        public Task Add(ProductsSorter productsSorter)
            => repository.Add(productsSorter);

        public Task Delete(int Id)
            => repository.Delete(Id);

        public List<ProductsSorter> GetAllAsync()
            => repository.GetAllAsync();

        public Task Update(int Id, ProductsSorter productsSorter)
            => repository.Update(Id, productsSorter);
    }
}
