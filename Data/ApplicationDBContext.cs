using Microsoft.EntityFrameworkCore;

namespace JPBank.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {

        }
    }
}
