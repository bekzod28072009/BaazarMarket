using BazarMarket.DataAcces.BazarMarketDBContexts;
using BazarMarket.DataAcces.IRepository.IProducts;
using BazarMarket.Domein.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.DataAcces.Repository.Products
{
    public class CountableProductsRepository : ICountableProductsRepository
    {
        private readonly AppDBContext dBContext;
        public CountableProductsRepository()
        {
            dBContext = new AppDBContext();
        }
        public async Task Add(СountableProducts countables)
        {
            dBContext.countables.Add(countables);
            dBContext.SaveChanges();
        }
        public async Task Delete(int Id)
        {
            var countable = dBContext.countables.FirstOrDefault(p => p.ID == Id);

            dBContext.Remove(countable);

            dBContext.SaveChangesAsync();
        }

        public List<СountableProducts> GetAllAsync()
            => dBContext.countables.ToList();

        public async Task Update(int Id, СountableProducts countables)
        {
            var countable = dBContext.countables.FirstOrDefault(p => p.ID == Id);
            countables.ID = Id;

            dBContext.countables.Attach(countable).CurrentValues.SetValues(countables);
            dBContext.SaveChanges();
        }
    }
}
