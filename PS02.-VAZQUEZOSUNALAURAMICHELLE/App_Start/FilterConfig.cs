﻿using System.Web;
using System.Web.Mvc;

namespace PS02._VAZQUEZOSUNALAURAMICHELLE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
