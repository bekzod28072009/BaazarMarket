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
    public class SalesmanRepository : ISalesmanRepository
    {
        private readonly AppDBContext dBContext;
        public SalesmanRepository()
        {
            dBContext = new AppDBContext();
        }
        public async Task Add(Salesman salesmans)
        {
            dBContext.salesmens.Add(salesmans);
            dBContext.SaveChanges();
        }

        public async Task Delete(int Id)
        {
            var salesman = dBContext.salesmens.FirstOrDefault(p => p.Id == Id);
            dBContext.salesmens.Remove(salesman);
            dBContext.SaveChangesAsync();
        }

        public List<Salesman> GetAllAsync()
            => dBContext.salesmens.ToList();

        public async Task Update(int Id, Salesman salesmans)
        {
            var salesman = dBContext.salesmens.FirstOrDefault(p => p.Id == Id);
            salesmans.Id = Id;

            dBContext.salesmens.Attach(salesman).CurrentValues.SetValues(salesmans);
            dBContext.SaveChanges();
        }
    }
}
