using System.Linq;

namespace Pro11WA.Models
{
    public class EfManufacturers : IManufacturersRepository
    {
        //fields
        private AppDbContext context;

        //constructors
        public EfManufacturers(AppDbContext context)
        {
            this.context = context;
        }

        //methods
        public Manufacturers AddManufacturer(Manufacturers m)
        {
            context.Manufacturers.Add(m);
            context.SaveChanges();
            return m;
        }

        //read

        public IQueryable<Manufacturers> GetAllManufacturers(int CompanyId)
        {
            return context.Manufacturers.Where(m => m.CompanyId == CompanyId)
                .OrderBy(m => m.CompanyProducts);
        }

        public Manufacturers GetManufacturersById(int id)
        {
            return context.Manufacturers.FirstOrDefault(m => m.Id == id);
        }

        //update
        public Manufacturers UpdateManufacturers(Manufacturers manufacturers)
        {
            Manufacturers manufacturersToUpdate = context.Manufacturers.SingleOrDefault(m => m.Id == manufacturers.Id);
            if (manufacturersToUpdate != null)
            {
                manufacturersToUpdate.CompanyId = manufacturers.CompanyId;
                manufacturersToUpdate.CompanyName = manufacturers.CompanyName;
                manufacturersToUpdate.CompanyProducts = manufacturers.CompanyProducts;
                context.SaveChanges();
            }
            return manufacturersToUpdate;
        }

        //delete
        public bool DeleteManufacturers(int id)
        {
            Manufacturers manufacturersToDelete = context.Manufacturers.SingleOrDefault(m => m.Id == id);
            if (manufacturersToDelete == null)
            {
                return false;
            }
            context.Manufacturers.Remove(manufacturersToDelete);
            context.SaveChanges();
            return true;
        }

    }
}
