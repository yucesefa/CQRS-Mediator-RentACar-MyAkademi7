using Microsoft.AspNetCore.Mvc;
using RentACarProject.CQRS.Commands;
using RentACarProject.CQRS.Handlers;
using RentACarProject.CQRS.Queries;

namespace RentACarProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly GetCarQueryHandler _getCarQueryhandler;
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;

        public AdminController(GetCarQueryHandler getCarQueryhandler, CreateCarCommandHandler createCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler, UpdateCarCommandHandler updateCarCommandHandler, GetCarByIdQueryHandler getCarByIdQueryHandler)
        {
            _getCarQueryhandler = getCarQueryhandler;
            _createCarCommandHandler = createCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
        }

        public IActionResult CarList()
        {
            var values = _getCarQueryhandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCar(CreateCarCommand createCarCommand)
        {
            _createCarCommandHandler.Handle(createCarCommand);
            return RedirectToAction("Carlist");
        }
        public IActionResult RemoveCar(int id)
        {
            _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return RedirectToAction("CarList");
        }
        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            var value = _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCar(UpdateCarCommand updateCarCommand)
        {
            _updateCarCommandHandler.Handle(updateCarCommand);
            return RedirectToAction("CarList");
        }
    }
}
