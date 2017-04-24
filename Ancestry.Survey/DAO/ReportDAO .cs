using Ancestry.Survey.Models;
using Ancestry.Survey.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Ancestry.Survey.DAO
{
    class ReportDAO
    {
        public ReportModel GetReport()
        {
            SurveyDBEntities surveyDBEntities = new SurveyDBEntities();

            var averageAge = (from s in surveyDBEntities.Survey
                        group s by new { Group = s.Age } into grouped
                        select new
                        {
                            AverageValue = grouped.Average(x => x.Age)
                        }).FirstOrDefault();

            var averageRating = (from s in surveyDBEntities.Survey
                             group s by new { Group = s.Rating } into grouped
                             select new
                             {
                                 AverageValue = grouped.Average(x => x.Rating)
                             }).FirstOrDefault();

            var genderDistribution = (from s in surveyDBEntities.Survey
                             group s by new { Group = s.Gender } into grouped
                             select new
                             {
                                 Gender = grouped.Key.Group,
                                 Distribution = grouped.Count()
                             }).ToList();

            var countryDistribution = (from s in surveyDBEntities.Survey
                                     group s by new { Group = s.Country } into grouped
                                     select new
                                     {
                                         Country = grouped.Key.Group,
                                         Distribution = grouped.Count()
                                     }).ToList();

            var totalResults = surveyDBEntities.Survey.Count();

            ReportModel reportModel = new ReportModel();

            reportModel.AverageAge = Convert.ToInt16(averageAge.AverageValue);
            reportModel.AverageRating = Convert.ToInt16(averageRating.AverageValue);
            reportModel.Total = totalResults;

            reportModel.GenderList = new List<GenderModel>();

            foreach (var g in genderDistribution)
            {
                GenderModel gender = new GenderModel();
                gender.Description = g.Gender;
                gender.Total = g.Distribution;

                reportModel.GenderList.Add(gender);
            }

            reportModel.CountryList = new List<CountryModel>();

            foreach (var c in countryDistribution)
            {
                CountryModel country = new CountryModel();
                country.Description = c.Country;
                country.Total = c.Distribution;

                reportModel.CountryList.Add(country);
            }

            return reportModel;
        }
    }
}