using Microsoft.AspNetCore.Mvc;
using RentACarProject.CQRS.Handlers;

namespace RentACarProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetCarQueryHandler _handler;

        public DefaultController(GetCarQueryHandler handler)
        {
            _handler = handler;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CarList()
        {
            var values = _handler.Handle();
            return View(values);
        }
    }
}
