using BazarMarket.Domein.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.Service.IService.IProductsService
{
    public interface ICountableProductsService
    {
        List<СountableProducts> GetAllAsync();

        Task Add(СountableProducts countables);

        Task Update(int Id, СountableProducts countables);

        Task Delete(int Id);
    }
}
