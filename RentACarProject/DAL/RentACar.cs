namespace RentACarProject.DAL
{
    public class RentACar
    {
        public int RentACarId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public DateTime ReceivingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int ReceivingLocationId { get; set; }
        public ReceivingLocation ReceivingLocation {  get; set; }
        public int DeliveryLocationId { get; set; }
        public DeliveryLocation DeliveryLocation { get; set; }

    }
}
