using System.Web;
using System.Web.Mvc;

namespace _01.Project_Template_Introduction
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
