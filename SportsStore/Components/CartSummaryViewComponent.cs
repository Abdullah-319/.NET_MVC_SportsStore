using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart Cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            Cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(Cart);
        }
    }
}
