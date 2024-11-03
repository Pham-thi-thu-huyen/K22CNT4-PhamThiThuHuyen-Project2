using System.Web;
using System.Web.Mvc;

namespace K22CNT4_TTCD1_PhamThiThuHuyen
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
