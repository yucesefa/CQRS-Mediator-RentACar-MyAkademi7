using RentACarProject.CQRS.Results;
using RentACarProject.DAL;

namespace RentACarProject.CQRS.Handlers
{
    public class GetCarQueryHandler
    {
        private readonly Context _context;

        public GetCarQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetCarQueryResult> Handle()
        {
            var result = _context.Cars.Select(x => new GetCarQueryResult
            {
                CarId = x.CarId,
                Brand = x.Brand,
                Model = x.Model,
                KM = x.KM,
                FuelType = x.FuelType,
                MotorPower = x.MotorPower,
                BodyType = x.BodyType,
                Color = x.Color,
                ImageUrl = x.ImageUrl,
                Price = x.Price

            }).ToList();
            return result;
        }
    }
}
