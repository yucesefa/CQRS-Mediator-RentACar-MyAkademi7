using MediatR;
using Microsoft.EntityFrameworkCore;
using RentACarProject.DAL;
using RentACarProject.MediatorPattern.Queries;
using RentACarProject.MediatorPattern.Results;

namespace RentACarProject.MediatorPattern.Handlers
{
    public class GetCarByLocationQueryHandler:IRequestHandler<GetCarByLocationQuery,List<GetCarByLocationQueryResult>>
    {
        private readonly Context _context;

        public GetCarByLocationQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetCarByLocationQueryResult>> Handle(GetCarByLocationQuery request, CancellationToken cancellationToken)
        {
           var values = await _context.RentACars.Include(x=>x.Car).Include(x=>x.ReceivingLocation)
                .Include(x=>x.DeliveryLocation).Where(x=>x.ReceivingLocationId==request.ReceivingLocationId ||
                x.DeliveryLocationId==request.DeliveryLocationId || x.ReceivingDate==request.ReceivingDate ||
                x.DeliveryDate==request.DeliveryDate).ToListAsync();
            return values.Select(x=> new GetCarByLocationQueryResult
            {
                CarId = x.CarId,
                Brand = x.Car.Brand,
                Model = x.Car.Model,
                FuelType = x.Car.FuelType,
                ImageUrl = x.Car.ImageUrl,
                Price = x.Car.Price,
                ReceivingLocationId = x.ReceivingLocationId,
                DeliveryLocationId = x.DeliveryLocationId,
            }).ToList();
        }
    }
}
