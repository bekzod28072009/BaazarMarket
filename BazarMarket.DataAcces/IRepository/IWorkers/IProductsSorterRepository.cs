using BazarMarket.Domein.Entity.Products;
using BazarMarket.Domein.Entity.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.DataAcces.IRepository.IWorkers
{
    public interface IProductsSorterRepository
    {
        List<ProductsSorter> GetAllAsync();

        Task Add(ProductsSorter productsSorter);

        Task Update(int Id, ProductsSorter productsSorter);

        Task Delete(int Id);
    }
}
