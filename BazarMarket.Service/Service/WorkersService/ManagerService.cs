using BazarMarket.DataAcces.IRepository.IWorkers;
using BazarMarket.DataAcces.Repository.Workers;
using BazarMarket.Domein.Entity.Workers;
using BazarMarket.Service.IService.IWorkersService;

namespace BazarMarket.Service.Service.WorkersService
{
    public class ManagerService : IManagerService
    {
        public readonly IManagerRepository repository;
        public ManagerService()
        {
            repository = new ManagerRepository();
        }
        public Task Add(Manager managers)
            => repository.Add(managers);

        public Task Delete(int Id)
            => repository.Delete(Id);

        public List<Manager> GetAllAsync()
            => repository.GetAllAsync();

        public Task Update(int Id, Manager managers)
            => repository.Update(Id, managers);
    }
}
