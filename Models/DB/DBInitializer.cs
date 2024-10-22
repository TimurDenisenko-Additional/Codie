using System.Data.Entity;

namespace Codie.Models.DB
{
    public class DBInitializer : CreateDatabaseIfNotExists<DbContext>
    {
        protected override void Seed(DbContext db)
        {
            base.Seed(db);
        }
    }
}