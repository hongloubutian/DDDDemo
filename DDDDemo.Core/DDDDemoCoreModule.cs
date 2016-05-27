using System.Reflection;
using Abp.Modules;

namespace DDDDemo
{
    public class DDDDemoCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
