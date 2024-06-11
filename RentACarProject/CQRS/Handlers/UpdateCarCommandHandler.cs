using RentACarProject.CQRS.Commands;
using RentACarProject.CQRS.Queries;
using RentACarProject.CQRS.Results;
using RentACarProject.DAL;

namespace RentACarProject.CQRS.Handlers
{
    public class UpdateCarCommandHandler
    {
        private readonly Context _context;

        public UpdateCarCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateCarCommand updateCarCommand)
        {
            var value = _context.Cars.Find(updateCarCommand.CarId);
            value.Brand = updateCarCommand.Brand;
            value.Model = updateCarCommand.Model;
            value.KM = updateCarCommand.KM;
            value.FuelType = updateCarCommand.FuelType;
            value.GearType = updateCarCommand.GearType;
            value.MotorPower = updateCarCommand.MotorPower;
            value.BodyType = updateCarCommand.BodyType;
            value.Color = updateCarCommand.Color;
            value.ImageUrl = updateCarCommand.ImageUrl;
            value.Price = updateCarCommand.Price;
            _context.SaveChanges();
        }
    }
}
