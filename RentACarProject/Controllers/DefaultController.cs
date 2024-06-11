using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACarProject.CQRS.Handlers;
using RentACarProject.DAL;
using RentACarProject.MediatorPattern.Queries;
using RentACarProject.Models;

namespace RentACarProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetCarQueryHandler _handler;
        private readonly IMediator _mediator;
        private Context _context;

        public DefaultController(GetCarQueryHandler handler, IMediator mediator, Context context)
        {
            _handler = handler;
            _mediator = mediator;
            _context = context;
        }

        public IActionResult Index()
        {
            List<SelectListItem> values = (from x in _context.ReceivingLocations.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.ReceivingLocationName,
                                               Value = x.ReceivingLocationId.ToString()
                                           }).ToList();
            ViewBag.ReceivingLocation = values;
            List<SelectListItem> values1 = (from x in _context.DeliveryLocations.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DeliveryLocationName,
                                               Value = x.DeliveryLocationId.ToString()
                                           }).ToList();
            ViewBag.DeliveryLocation = values1;
            return View();
        }
        public IActionResult CarList()
        {
            var values = _handler.Handle();
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> FilterCar(FilterCarViewModel filterCarViewModel)
        {
            var result = await _mediator.Send(new GetCarByLocationQuery(filterCarViewModel.RecevingLocationId, filterCarViewModel.DeliveryLocationId, filterCarViewModel.ReceivingDate, filterCarViewModel.DeliveryDate));
            return View(result);
        }
    }
}
