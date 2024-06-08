namespace RentACarProject.DAL
{
    public class Car
    {
        public int CarId { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int? KM { get; set; }
        public string? FuelType { get; set; }
        public string? MotorPower { get; set; }
        public string? BodyType { get; set; }
        public string? Color { get; set; }
        public string ImageUrl { get; set; }
        public string Price { get; set; }
    }
}
