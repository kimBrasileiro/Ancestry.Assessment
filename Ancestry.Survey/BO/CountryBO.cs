using Ancestry.Survey.ViewModels;
using Ancestry.Survey.Models;
using Ancestry.Survey.DAO;
using System.Collections.Generic;

namespace Ancestry.Survey.BO
{
    class CountryBO
    {
        public List<CountryViewModel> GetList()
        {
            CountryDAO countryDAO = new CountryDAO();
            var surveyModelList = countryDAO.GetList();

            List<CountryViewModel> countryViewModelList = new List<CountryViewModel>();

            foreach(var s in surveyModelList)
            {
                CountryViewModel countryViewModel = new CountryViewModel();
                countryViewModel.Description = s.Description;

                countryViewModelList.Add(countryViewModel);
            }

            return countryViewModelList;
        }
    }
}