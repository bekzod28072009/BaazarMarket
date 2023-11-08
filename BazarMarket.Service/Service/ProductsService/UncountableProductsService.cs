using BazarMarket.DataAcces.IRepository.Products;
using BazarMarket.DataAcces.Repository.Products;
using BazarMarket.Domein.Entity.Products;
using BazarMarket.Service.IService.IProductsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.Service.Service.ProductsService
{
    public class UncountableProductsService : IUncountableProductsService
    {
        public readonly IUncountableProductsRepository repository;
        public UncountableProductsService()
        {
            repository = new UncountableProductsRepository();
        }

        public Task Add(UncountableProducts uncountables)
            => repository.Add(uncountables);

        public Task Delete(int Id)
            => repository.Delete(Id);

        public List<UncountableProducts> GetAllAsync()
            => repository.GetAllAsync();

        public Task Update(int Id, UncountableProducts uncountables)
            => repository.Update(Id, uncountables);
    }
}
