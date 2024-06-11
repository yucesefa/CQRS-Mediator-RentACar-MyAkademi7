using Microsoft.AspNetCore.Mvc;

namespace RentACarProject.ViewComponents
{
    public class _AdminLayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
