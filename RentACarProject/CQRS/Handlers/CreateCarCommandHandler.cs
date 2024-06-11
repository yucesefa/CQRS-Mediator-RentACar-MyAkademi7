using RentACarProject.CQRS.Commands;
using RentACarProject.DAL;

namespace RentACarProject.CQRS.Handlers
{
    public class CreateCarCommandHandler
    {
        private readonly Context _context;

        public CreateCarCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateCarCommand createCarCommand)
        {
            _context.Add(new Car
            {
                Brand = createCarCommand.Brand,
                Model = createCarCommand.Model,
                KM = createCarCommand.KM,
                FuelType = createCarCommand.FuelType,
                GearType = createCarCommand.GearType,
                MotorPower = createCarCommand.MotorPower,
                BodyType = createCarCommand.BodyType,
                Color = createCarCommand.Color,
                ImageUrl = createCarCommand.ImageUrl,
                Price = createCarCommand.Price
            });
            _context.SaveChanges();
        }
    }
}
