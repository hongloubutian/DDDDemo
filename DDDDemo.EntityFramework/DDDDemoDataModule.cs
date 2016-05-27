using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using DDDDemo.EntityFramework;

namespace DDDDemo
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(DDDDemoCoreModule))]
    public class DDDDemoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<DDDDemoDbContext>(null);
        }
    }
}
