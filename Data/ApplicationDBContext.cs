using JPBank.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace JPBank.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {

        }

        public DbSet<UserDbModel> Tbl_Users { get; set; } // Tbl_User is the table name
    }
}
