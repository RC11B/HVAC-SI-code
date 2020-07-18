using Microsoft.AspNetCore.Mvc;
using Pro11WA.Models;
using System.Linq;

namespace Pro11WA.Controllers
{
    public class FurnaceController : Controller
    {
        //   F i e l d s   &   P r o p e r t i e s
        private int pageSize = 4;

        private IFurnaceRepository repository;

        public int PageSize { get; set; } = 4;

        //   C o n s t r u c t o r s

        public FurnaceController(IFurnaceRepository repository)
        {
            this.repository = repository;
        }

        //   M e t h o d s


        public IActionResult Index(int productPage = 1)
        {
            IQueryable<Furnace> someProducts =
               repository.GetAllProducts()
                         .OrderBy(f => f.furnaceid)
                         .Skip((productPage - 1) * PageSize)
                         .Take(PageSize);
            return View(someProducts);
        }


        public IActionResult Detail(int id)
        {
            Furnace product = repository.GetProductById(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Search(string id)
        {
            IQueryable<Furnace> products =
               repository.GetProductsByKeyword(id);
            return View(products);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Furnace product = repository.GetProductById(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }

        [HttpPut]
        public IActionResult Update(Furnace product, int id)
        {
            product.furnaceid = id;
            repository.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            Furnace newProduct = new Furnace();
            return View(newProduct);
        }

        [HttpPost]
        public IActionResult Create(Furnace product)
        {
            repository.Create(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Furnace product = repository.GetProductById(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Furnace product, int id)
        {
            repository.DeleteProduct(id);
            return RedirectToAction("Index");
        }

    }
}
