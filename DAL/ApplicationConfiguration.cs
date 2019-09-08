using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace FormRegistrator.DAL
{
    public class ApplicationConfiguration : DbConfiguration
    {
        public ApplicationConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}