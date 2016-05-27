using Abp.Web.Mvc.Views;

namespace DDDDemo.Web.Views
{
    public abstract class DDDDemoWebViewPageBase : DDDDemoWebViewPageBase<dynamic>
    {

    }

    public abstract class DDDDemoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected DDDDemoWebViewPageBase()
        {
            LocalizationSourceName = DDDDemoConsts.LocalizationSourceName;
        }
    }
}