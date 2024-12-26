using Core_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Api.DAL.APIContext
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=PREDATOR;database=Core_Db_API;integrated security=true");
        }

        public DbSet<Category> categories { get; set; }
    }
}
