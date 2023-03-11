using System.Web;
using System.Web.Mvc;

namespace leminhsang_2011143452
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
