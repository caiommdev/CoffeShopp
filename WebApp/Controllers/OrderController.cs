using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models.Coffe;

namespace WebApp.Controllers
{
    public class OrderController : Controller
    {
        private OrderContex _contex;
        public OrderController(OrderContex dbContext)
        {
            _contex = dbContext;
        }
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(Order newOrder)
        {
            _contex.Orders.Add(newOrder);

            _contex.SaveChanges();

            return View();
        }
    }
}
