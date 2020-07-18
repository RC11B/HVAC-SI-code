using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pro11WA.Models;

namespace Pro11WA.Controllers
{
    public class ManufacturersController : Controller
    {

        //fields
        private IManufacturersRepository repository;

        //constructors
        public ManufacturersController(IManufacturersRepository repository)
        {
            this.repository = repository;
        }

        //methods

        //create
        [HttpGet]
        public IActionResult Add(int id)
        {
            Manufacturers m = new Manufacturers();
            m.CompanyId = id;
            return View(m);

        }

        [HttpPost]
        public IActionResult Add(Manufacturers m)
        {
            m.Id = 0;
            repository.AddManufacturers(m);
            return RedirectToAction("Detail", "Furnace", new { id = m.CompanyId });
        }

        //read

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            Manufacturers manufacturers = repository.GetManufacturersById(id);
            return View(manufacturers);
        }

        //update

        //delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Manufacturers manufacturers = repository.GetManufacturersById(id);
            return View(manufacturers);
        }

        [HttpPost]
        public IActionResult Delete(Manufacturers m)
        {
            repository.DeleteManufactures(m.Id);
            return RedirectToAction("Index", "Furnace");
        }
    }
}
