using BazarMarket.Domein.Entity.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.Service.IService.IWorkersService
{
    public interface ISalesManagerService
    {
        List<SalesManager> GetAllAsync();

        Task Add(SalesManager salesManager);

        Task Update(int Id, SalesManager salesManager);

        Task Delete(int Id);
    }
}
