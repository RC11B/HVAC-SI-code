using System.Linq;

namespace Pro11WA.Models
{
    public class FurnaceProductRepository : IFurnaceRepository
    {
        public Furnace Create(Furnace product)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Furnace> GetAllProducts()
        {
            Furnace[] Furnaces = new Furnace[3];

            Furnaces[0] = new Furnace
            {
                brand = "Bryant",
                furnaceid = 1,
                CompanyId = 1,
                serialnumber = "110A3B4o",
                modelnumber = "42A",
                tonnage = 3.5,
                size = 20,
                year = 2019
            };

            Furnaces[1] = new Furnace
            {
                brand = "Carrier",
                furnaceid = 2,
                CompanyId = 2,
                serialnumber = "1131A3B3",
                modelnumber = "35C",
                tonnage = 3,
                size = 20,
                year = 2017
            };

            Furnaces[2] = new Furnace
            {
                brand = "Lennox",
                furnaceid = 3,
                CompanyId = 3,
                serialnumber = "Len42Ab30",
                modelnumber = "L34B8Aft",
                tonnage = 3.5,
                size = 20,
                year = 2018
            };

            return Furnaces.AsQueryable<Furnace>();
        }

        public Furnace GetProductById(int furnaceid)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Furnace> GetProductsByKeyword(string keyword)
        {
            throw new System.NotImplementedException();
        }

        public Furnace UpdateProduct(Furnace product)
        {
            throw new System.NotImplementedException();
        }
    }
}
