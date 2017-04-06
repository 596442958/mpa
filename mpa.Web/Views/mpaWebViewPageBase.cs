using Abp.Web.Mvc.Views;

namespace mpa.Web.Views
{
    public abstract class mpaWebViewPageBase : mpaWebViewPageBase<dynamic>
    {

    }

    public abstract class mpaWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected mpaWebViewPageBase()
        {
            LocalizationSourceName = mpaConsts.LocalizationSourceName;
        }
    }
}