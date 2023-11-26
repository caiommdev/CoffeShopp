using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Data;

namespace WebApp.Views.Order
{
    public class CreateOrderModel : PageModel
    {
        private OrderContex _contex;

        [BindProperty]
        public Models.Coffe.Order NewOrder { get; set; }
      
        public CreateOrderModel(OrderContex dbContext)
        {
            _contex = dbContext;            
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            _contex.Orders.Add(NewOrder);

            _contex.SaveChanges();

            return RedirectToPage("Home/Index");
        }
    }
}
