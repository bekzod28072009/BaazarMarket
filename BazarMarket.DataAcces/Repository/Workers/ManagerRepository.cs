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
    public class ManagerRepository : IManagerRepository
    {
        private readonly AppDBContext dBContext;
        public ManagerRepository()
        {
            dBContext = new AppDBContext();
        }
        public async Task Add(Manager managers)
        {
            dBContext.managers.Add(managers);
            dBContext.SaveChanges();
        }

        public async Task Delete(int Id)
        {
            var manager = dBContext.managers.FirstOrDefault(p => p.Id == Id);
            dBContext.managers.Remove(manager);
            dBContext.SaveChangesAsync();
        }

        public List<Manager> GetAllAsync()
            => dBContext.managers.ToList();

        public async Task Update(int Id, Manager managers)
        {
            var manager = dBContext.managers.FirstOrDefault(p => p.Id == Id);
            managers.Id = Id;

            dBContext.managers.Attach(manager).CurrentValues.SetValues(managers);
            dBContext.SaveChanges();
        }
    }
}
