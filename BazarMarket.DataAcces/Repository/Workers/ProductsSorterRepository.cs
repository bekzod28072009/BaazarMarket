using BazarMarket.DataAcces.BazarMarketDBContexts;
using BazarMarket.DataAcces.IRepository.IWorkers;
using BazarMarket.Domein.Entity.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.DataAcces.Repository.Workers
{
    public class ProductsSorterRepository : IProductsSorterRepository
    {
        private readonly AppDBContext dBContext;
        public ProductsSorterRepository()
        {
            dBContext = new AppDBContext();
        }
        public async Task Add(ProductsSorter productsSorter)
        {
            dBContext.productsSorter.Add(productsSorter);
            dBContext.SaveChanges();
        }

        public async Task Delete(int Id)
        {
            var productSorter = dBContext.productsSorter.FirstOrDefault(p => p.Id == Id);

            dBContext.productsSorter.Remove(productSorter);
            dBContext.SaveChangesAsync();
        }

        public List<ProductsSorter> GetAllAsync()
            => dBContext.productsSorter.ToList();

        public async Task Update(int Id, ProductsSorter productsSorter)
        {
            var productSorter = dBContext.productsSorter.FirstOrDefault(p => p.Id == Id);
            productsSorter.Id = Id;

            dBContext.productsSorter.Attach(productsSorter).CurrentValues.SetValues(productsSorter);
            dBContext.SaveChanges();
        }
    }
}
