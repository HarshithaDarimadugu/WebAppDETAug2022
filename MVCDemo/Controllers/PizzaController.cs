using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;

namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaServices.GetAll();
            return View(pizzas);
        }

        public IActionResult Detail(int id)
        {
            Pizza p = PizzaServices.Get(id);
            return View(p);
        }

        //public IActionResult List(int id)
        //{
        //    Pizza p = PizzaServices.Get(id);
        //    return View(p);
        //}
        public IActionResult List(int id)
        {
            List<Pizza> pizzas = PizzaServices.GetAll();
            return View(pizzas);
        }
        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id, string name, int size, decimal price, bool Isglutenfree )
        {
            Pizza p = new Pizza { Id = id, Name = name, Size = (PizzaSize)size, Price = price, IsGlutenFree = Isglutenfree  };
            PizzaServices.Add(p);
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            Pizza P = PizzaServices.Get(id);
            if (P != null)
                return View(P);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Pizza p)
        {

            PizzaServices.Delete(p.Id);
            return RedirectToAction("List");

        }
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, string name, int size, decimal price, bool isglutenfree)
        {
            Pizza p = new Pizza { Id = id, Name = name, Size = (PizzaSize)size, Price = price, IsGlutenFree = isglutenfree };
            PizzaServices.Update(p);
            return RedirectToAction("List");
        }
    }
}
    

