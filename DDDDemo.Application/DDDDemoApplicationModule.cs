using System.Reflection;
using Abp.Modules;

namespace DDDDemo
{
    [DependsOn(typeof(DDDDemoCoreModule))]
    public class DDDDemoApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
