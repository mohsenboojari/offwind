﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Offwind.Web.Core;

namespace Offwind.Web.Controllers
{
    public class DiscussionsController : PagesController
    {
        public ActionResult Index()
        {
            return ShowByType(PageType.Discussions);
        }
    }
}
