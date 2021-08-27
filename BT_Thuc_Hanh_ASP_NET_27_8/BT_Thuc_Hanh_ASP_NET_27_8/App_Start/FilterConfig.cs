using System.Web;
using System.Web.Mvc;

namespace BT_Thuc_Hanh_ASP_NET_27_8
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
