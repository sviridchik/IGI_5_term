using Microsoft.AspNetCore.Mvc;

namespace WEB_953501_SVIRIDCHIK.Components
{
    public class CartViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}