using BazarMarket.DataAcces.BazarMarketDBContexts;
using BazarMarket.DataAcces.IRepository.Products;
using BazarMarket.Domein.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.DataAcces.Repository.Products
{
    public class UncountableProductsRepository : IUncountableProductsRepository
    {
        private readonly AppDBContext dBContext;
        public UncountableProductsRepository()
        {
            dBContext = new AppDBContext();
        }
        public async Task Add(UncountableProducts uncountables)
        {
            dBContext.uncountables.Add(uncountables);
            dBContext.SaveChanges();
        }

        public async Task Delete(int Id)
        {
            var uncoutable = dBContext.uncountables.FirstOrDefault(p => p.ID == Id);
            dBContext.Remove(uncoutable);
            dBContext.SaveChangesAsync();
        }

        public List<UncountableProducts> GetAllAsync()
            => dBContext.uncountables.ToList();

        public async Task Update(int Id, UncountableProducts uncountables)
        {
            var uncoutable = dBContext.uncountables.FirstOrDefault(p => p.ID == Id);
            uncountables.ID = Id;

            dBContext.uncountables.Attach(uncoutable).CurrentValues.SetValues(uncountables);
            dBContext.SaveChanges();
        }
    }
}
