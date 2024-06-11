using MediatR;
using RentACarProject.MediatorPattern.Results;

namespace RentACarProject.MediatorPattern.Queries
{
    public class GetCarByLocationQuery : IRequest<List<GetCarByLocationQueryResult>>
    {
        public int ReceivingLocationId { get; set; }
        public int DeliveryLocationId { get; set; }
        public DateTime ReceivingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public GetCarByLocationQuery(int receivingLocationId,int deliveryLocationId,DateTime receivingDate,DateTime deliveryDate)
        {
            ReceivingLocationId = receivingLocationId;
            DeliveryLocationId = deliveryLocationId;
            DeliveryDate = deliveryDate;
            ReceivingDate = receivingDate;
        }

    }
}
