namespace RentACarProject.CQRS.Queries
{
    public class GetCarByIdQuery
    {
        public int Id { get; set; }
        public GetCarByIdQuery(int id)
        {

            Id = id;

        }
    }
}
