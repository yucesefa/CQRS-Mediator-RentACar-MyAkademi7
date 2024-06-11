namespace RentACarProject.MediatorPattern.Results
{
    public class GetCarByLocationQueryResult
    {
        public int CarId { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? FuelType { get; set; }
        public string? ImageUrl { get; set; }
        public string? Price { get; set; }
        public int ReceivingLocationId { get; set; }
        public int DeliveryLocationId { get; set; }
    }
}
