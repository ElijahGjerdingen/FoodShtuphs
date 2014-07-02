using System.Web;
using System.Web.Mvc;
using FoodShtuphs.Infastructure;

namespace FoodShtuphs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogAttribute());
        }
    }
}
