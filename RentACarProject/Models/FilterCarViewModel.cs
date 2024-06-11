namespace RentACarProject.Models
{
    public class FilterCarViewModel
    {
        public int RecevingLocationId { get; set; }
        public int DeliveryLocationId { get; set; }
        public DateTime ReceivingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
