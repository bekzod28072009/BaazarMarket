using BazarMarket.Domein.Entity.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.Service.IService.IWorkersService
{
    public interface IProductsSorterService
    {
        List<ProductsSorter> GetAllAsync();

        Task Add(ProductsSorter productsSorter);

        Task Update(int Id, ProductsSorter productsSorter);

        Task Delete(int Id);
    }
}
