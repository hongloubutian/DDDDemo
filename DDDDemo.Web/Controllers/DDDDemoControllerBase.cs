using Abp.Web.Mvc.Controllers;

namespace DDDDemo.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class DDDDemoControllerBase : AbpController
    {
        protected DDDDemoControllerBase()
        {
            LocalizationSourceName = DDDDemoConsts.LocalizationSourceName;
        }
    }
}