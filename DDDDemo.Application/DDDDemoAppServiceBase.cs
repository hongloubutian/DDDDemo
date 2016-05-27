using Abp.Application.Services;

namespace DDDDemo
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class DDDDemoAppServiceBase : ApplicationService
    {
        protected DDDDemoAppServiceBase()
        {
            LocalizationSourceName = DDDDemoConsts.LocalizationSourceName;
        }
    }
}