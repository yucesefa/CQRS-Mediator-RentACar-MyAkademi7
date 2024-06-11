using RentACarProject.CQRS.Commands;
using RentACarProject.DAL;

namespace RentACarProject.CQRS.Handlers
{
    public class RemoveCarCommandHandler
    {
        private readonly Context _context;

        public RemoveCarCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveCarCommand removeCarCommand)
        {
            var value = _context.Cars.Find(removeCarCommand.CarId);
            _context.Cars.Remove(value);
            _context.SaveChanges();
        }
    }
}
