﻿using System.Web;
using System.Web.Mvc;

namespace Rad302SummerWebAPIdmulligan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
