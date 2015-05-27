using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BasicModels;
namespace DataLayer.Context
{
    public class AtlasCmsContext : DbContext
    {
        static AtlasCmsContext()
        {
            Database.SetInitializer<AtlasCmsContext>(
                new DropCreateDatabaseIfModelChanges<AtlasCmsContext>());
            //Database.SetInitializer<AtlasCmsContext>(
            //    new CreateDatabaseIfNotExists<AtlasCmsContext>());
        }
        public AtlasCmsContext() {
        }

        public DbSet<Country> Countries { get; set; }

    }
}
