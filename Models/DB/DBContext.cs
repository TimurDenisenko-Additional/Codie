using System.Data.Entity;

namespace Codie.Models.DB
{
    public class DBContext : DbContext
    {
        public DbSet<AccountModel> Accounts { get; set; }

        public System.Data.Entity.DbSet<Codie.Models.SingleChoiseModel> SingleChoiseModels { get; set; }

        public System.Data.Entity.DbSet<Codie.Models.MultiChoiseModel> MultiChoiseModels { get; set; }
    }
}