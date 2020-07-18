using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro11WA.Models
{
    public class EfFurnaceRepository : IFurnaceRepository
    {
        //   F i e l d s   &   P r o p e r t i e s

        private AppDbContext context;

        //   C o n s t r u c t o r s

        public EfFurnaceRepository(AppDbContext context)
        {
            this.context = context;
        }

        //   M e t h o d s

        public IQueryable<Furnace> GetAllProducts()
        {
            return context.Furnaces;
        }

        public Furnace GetProductById(int productId)
        {
            return context.Furnaces
               .Where(f => f.furnaceid == productId).Include(f => f.manufacturers)
               .FirstOrDefault();
        }

        public IQueryable<Furnace> GetProductsByKeyword(string keyword)
        {
            return context.Furnaces
               .Where(f => f.brand.Contains(keyword));
        }

        public Furnace UpdateProduct(Furnace product)
        {
            Furnace productToUpdate =
               context.Furnaces
               .SingleOrDefault(f => f.furnaceid == product.furnaceid);
            if (productToUpdate != null)
            {
                productToUpdate.modelnumber = product.modelnumber;
                productToUpdate.brand = product.brand;
                productToUpdate.serialnumber = product.serialnumber;
                context.SaveChanges();
            }
            return productToUpdate;
        }

        public Furnace Create(Furnace product)
        {
            context.Furnaces.Add(product);
            context.SaveChanges();
            return product;
        }

        public bool DeleteProduct(int id)
        {
            Furnace productToDelete =
               context.Furnaces.FirstOrDefault(f => f.furnaceid == id);
            if (productToDelete == null)
            {
                return false;
            }
            context.Furnaces.Remove(productToDelete);
            context.SaveChanges();
            return true;
        }

    }
}
