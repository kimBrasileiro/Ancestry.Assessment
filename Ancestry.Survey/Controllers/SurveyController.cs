using System;using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ancestry.Survey.ViewModels;
using Ancestry.Survey.BO;

namespace Ancestry.Survey.Controllers
{
    public class SurveyController : Controller
    {
        // GET: Survey
        public ActionResult Index()
        {
            CountryBO countryBO = new CountryBO();
            ViewBag.Countries = countryBO.GetList();

            return View();
        }

        [HttpPost]
        public ActionResult Index(SurveyViewModel surveyViewModel)
        {
            try
            {
                SurveyBO surveyBO = new SurveyBO();

                surveyViewModel.Origin = Session["Origin"].ToString();

                surveyBO.Create(surveyViewModel);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

            return View("~/Views/Home/Final.cshtml");
        }
    }
}