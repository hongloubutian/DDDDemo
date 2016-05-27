using System.Data.Entity.Migrations;

namespace DDDDemo.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DDDDemo.EntityFramework.DDDDemoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DDDDemo";
        }

        protected override void Seed(DDDDemo.EntityFramework.DDDDemoDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
