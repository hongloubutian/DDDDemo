using System.Data.Entity;
using Abp.EntityFramework;
using DDDDemo.Menu;
using DDDDemo.Role;

namespace DDDDemo.EntityFramework
{
    public class DDDDemoDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...
        public IDbSet<Users.Users> UserList { get; set; }

        public IDbSet<Roles> RoleList { get; set; }

        public IDbSet<Menus> MenuList { get; set; }

        public IDbSet<UserRole> UserRole { get; set; }

        public IDbSet<RoleMenu> RoleMenu { get; set; } 
        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public DDDDemoDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in DDDDemoDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of DDDDemoDbContext since ABP automatically handles it.
         */
        public DDDDemoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
