using System.Data.Entity;

namespace Codie.Models.DB
{
    public class DBContext : DbContext
    {
        public DbSet<AccountModel> Accounts { get; set; }
    }
}