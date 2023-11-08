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
    public class SalesManagerRepository : ISalesManagerRepository
    {
        private readonly AppDBContext dBContext;
        public SalesManagerRepository()
        {
            dBContext = new AppDBContext();
        }
        public async Task Add(SalesManager salesManager)
        {
            dBContext.salesManager.Add(salesManager);
            dBContext.SaveChanges();
        }

        public async Task Delete(int Id)
        {
            var saleManager = dBContext.salesManager.FirstOrDefault(p => p.Id == Id);
            dBContext.salesManager.Remove(saleManager);
            dBContext.SaveChangesAsync();
        }

        public List<SalesManager> GetAllAsync()
            => dBContext.salesManager.ToList();

        public async Task Update(int Id, SalesManager salesManager)
        {
            var saleManager = dBContext.salesManager.FirstOrDefault(p => p.Id == Id);
            salesManager.Id = Id;

            dBContext.salesManager.Attach(saleManager).CurrentValues.SetValues(salesManager);
            dBContext.SaveChanges();
        }
    }
}
