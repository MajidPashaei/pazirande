using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DataLayer.Entities;
using DataLayer.Entities.Portal;

namespace DataLayer.Context
{
    public class HampadcoContext : DbContext
    {
        public HampadcoContext(DbContextOptions<HampadcoContext> options) : base(options)
        {
        }
        /* Tbls */
        public DbSet<Tbl_User> Tbl_Users { get; set; }
        public DbSet<Tbl_PazirandeUser> Tbl_PazirandeUsers { get; set; }
        public DbSet<Tbl_Pazirande> Tbl_Pazirandes { get; set; }
        public DbSet<Tbl_Support> Tbl_Supports {get; set;}
        public DbSet<Tbl_ClassCodes> Tbl_ClassCodess {get; set;}
    }
    public class ToDoContextFactory : IDesignTimeDbContextFactory<HampadcoContext>
    {
        public HampadcoContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HampadcoContext>();
            builder.UseSqlServer("Data Source=.;initial Catalog=Pazirande;integrated Security=SSPI;MultipleActiveResultSets=true");
            //  builder.UseSqlServer("Data Source=193.141.64.76,2019;initial Catalog=hampadco;USER ID=hampadco;PASSWORD=12345@iran;MultipleActiveResultSets=true");

            return new HampadcoContext(builder.Options);
        }
    }
}