using BazarMarket.Domein.Entity.Products;
using BazarMarket.Service.IService.IProductsService;
using BazarMarket.DataAcces.IRepository.IProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazarMarket.DataAcces.Repository.Products;

namespace BazarMarket.Service.Service.ProductsService
{
    public class CountableProductsService : ICountableProductsService
    {
        public readonly ICountableProductsRepository repository;
        public CountableProductsService()
        {
            repository = new CountableProductsRepository();
        }

        public Task Add(СountableProducts countables)
            => repository.Add(countables);

        public Task Delete(int Id)
            => repository.Delete(Id);

        public List<СountableProducts> GetAllAsync()
            => repository.GetAllAsync();

        public Task Update(int Id, СountableProducts countables)
            => repository.Update(Id, countables);
    }
}
