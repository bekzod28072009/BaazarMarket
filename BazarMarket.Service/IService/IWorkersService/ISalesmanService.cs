using BazarMarket.Domein.Entity.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.Service.IService.IWorkersService
{
    public interface ISalesmanService
    {
        List<Salesman> GetAllAsync();

        Task Add(Salesman salesmans);

        Task Update(int Id, Salesman salesmans);

        Task Delete(int Id);
    }
}
