using FormRegistrator.Models;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace FormRegistrator.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    } 
}