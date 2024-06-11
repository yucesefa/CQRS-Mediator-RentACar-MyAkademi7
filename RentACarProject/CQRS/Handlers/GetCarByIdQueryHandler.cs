using RentACarProject.CQRS.Commands;
using RentACarProject.CQRS.Queries;
using RentACarProject.CQRS.Results;
using RentACarProject.DAL;
using RentACarProject.MediatorPattern.Results;

namespace RentACarProject.CQRS.Handlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly Context _context;

        public GetCarByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetCarByIdQueryResult Handle(GetCarByIdQuery getCarByIdQuery)
        {
            var value = _context.Cars.Find(getCarByIdQuery.Id);
            return new GetCarByIdQueryResult
            {
                CarId = value.CarId,
                Brand = value.Brand,
                Model = value.Model,
                KM = value.KM,
                FuelType = value.FuelType,
                GearType = value.GearType,
                MotorPower = value.MotorPower,
                BodyType = value.BodyType,
                Color = value.Color,
                ImageUrl = value.ImageUrl,
                Price = value.Price
            };
        }
    }
}
