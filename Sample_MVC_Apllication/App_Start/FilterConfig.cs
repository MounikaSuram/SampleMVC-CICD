﻿using System.Web;
using System.Web.Mvc;

namespace Sample_MVC_Apllication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
