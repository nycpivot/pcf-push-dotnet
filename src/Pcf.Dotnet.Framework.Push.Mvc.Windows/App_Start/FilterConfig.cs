using System.Web;
using System.Web.Mvc;

namespace Pcf.Dotnet.Framework.Push.Mvc.Windows
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
