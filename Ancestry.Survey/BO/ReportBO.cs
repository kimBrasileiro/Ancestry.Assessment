using Ancestry.Survey.ViewModels;
using Ancestry.Survey.Models;
using Ancestry.Survey.DAO;
using System.Collections.Generic;

namespace Ancestry.Survey.BO
{
    class ReportBO
    {
        public ReportViewModel GetReport()
        {
            ReportDAO reportDAO = new ReportDAO();
            var report = reportDAO.GetReport();

            ReportViewModel reportViewModel = new ReportViewModel();

            reportViewModel.AverageAge = report.AverageAge;
            reportViewModel.AverageRating = report.AverageRating;

            reportViewModel.GenderList = new List<GenderViewModel>();

            foreach (var g in report.GenderList)
            {
                GenderViewModel gender = new GenderViewModel();
                gender.Description = g.Description;
                gender.Total = g.Total;

                reportViewModel.GenderList.Add(gender);
            }

            reportViewModel.CountryList = new List<CountryViewModel>();

            foreach (var g in report.CountryList)
            {
                CountryViewModel country = new CountryViewModel();
                country.Description = g.Description;
                country.Total = g.Total;

                reportViewModel.CountryList.Add(country);
            }

            reportViewModel.Total = report.Total;

            return reportViewModel;
        }
    }
}