using System.Data.Entity;

namespace Codie.Models.DB
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<DbContext>
    {
        protected override void Seed(DbContext db)
        {
            base.Seed(db);
        }
    }
}