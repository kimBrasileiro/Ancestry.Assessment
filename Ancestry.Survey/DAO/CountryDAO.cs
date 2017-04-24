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
    class CountryDAO
    {
        public List<CountryModel> GetList()
        {
            SurveyDBEntities surveyDBEntities = new SurveyDBEntities();
            
            var countries = from c in surveyDBEntities.Country
                            select c;

            List<CountryModel> contryModelList = new List<CountryModel>();

            foreach (var c in countries)
            {
                CountryModel countryModel = new CountryModel();
                countryModel.Description = c.Description;

                contryModelList.Add(countryModel);
            }

            return contryModelList;


        }
    }
}