namespace RentACarProject.DAL
{
    public class ReceivingLocation
    {
        public int ReceivingLocationId { get; set; }
        public string ReceivingLocationName { get; set; }
        public List<RentACar> RentACars { get; set; }
    }
}
