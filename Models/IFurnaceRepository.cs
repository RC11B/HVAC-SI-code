using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro11WA.Models
{
    public interface IFurnaceRepository
    {
        Furnace Create(Furnace product);

        IQueryable<Furnace> GetAllProducts();
        Furnace GetProductById(int furnaceid);
        IQueryable<Furnace> GetProductsByKeyword(string keyword);

        Furnace UpdateProduct(Furnace product);

        bool DeleteProduct(int id);
    }
}
