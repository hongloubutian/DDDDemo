using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace DDDDemo
{
    [DependsOn(typeof(AbpWebApiModule), typeof(DDDDemoApplicationModule))]
    public class DDDDemoWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(DDDDemoApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
