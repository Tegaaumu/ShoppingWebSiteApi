using ApiCall.InputData;
using Microsoft.EntityFrameworkCore;

namespace ApiCall.BusinessLogic
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<ShoppingInput> ShoppingInput { get; set;}
    }
}
