﻿using System.Web;
using System.Web.Mvc;

namespace PVN1721050441
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
