// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Mvc;

namespace RazorWebSite.Controllers
{
    public class TemplateExpander : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult ViewWithLayout()
        {
            return View();
        }
    }
}