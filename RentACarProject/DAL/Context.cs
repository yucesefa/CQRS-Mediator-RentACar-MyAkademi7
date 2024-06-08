using Microsoft.EntityFrameworkCore;

namespace RentACarProject.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=YUCESAFA\\SQLEXPRESS; initial Catalog=RentACarDb; integrated Security=true");
        }
        public DbSet<Car> Cars { get; set; }
    }
}
