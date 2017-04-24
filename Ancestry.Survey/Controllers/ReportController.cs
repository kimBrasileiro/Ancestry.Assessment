﻿using Ancestry.Survey.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ancestry.Survey.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            ReportBO reportBO = new ReportBO();
            var model = reportBO.GetReport();

            return View(model);
        }
    }
}