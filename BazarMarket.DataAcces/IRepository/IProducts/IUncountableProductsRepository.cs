using BazarMarket.Domein.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.DataAcces.IRepository.Products
{
    public interface IUncountableProductsRepository
    {
        List<UncountableProducts> GetAllAsync();

        Task Add(UncountableProducts uncountables);

        Task Update(int Id, UncountableProducts uncountables);

        Task Delete(int Id);
    }
}
