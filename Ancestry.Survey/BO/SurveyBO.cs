using Ancestry.Survey.ViewModels;
using Ancestry.Survey.Models;
using Ancestry.Survey.DAO;

namespace Ancestry.Survey.BO
{
    class SurveyBO
    {
        public void Create(SurveyViewModel surveyViewModel)
        {
            SurveyDAO surveyDAO = new SurveyDAO();

            SurveyModel surveyModel = new SurveyModel();
            surveyModel.Name = surveyViewModel.Name;
            surveyModel.Email = surveyViewModel.Email;
            surveyModel.Age = surveyViewModel.Age;
            surveyModel.Gender = surveyViewModel.Gender;
            surveyModel.Country = surveyViewModel.Country;
            surveyModel.Rating = surveyViewModel.Rating;
            surveyModel.Suggestion = surveyViewModel.Suggestion;
            surveyModel.Origin = surveyViewModel.Origin;

            surveyDAO.Create(surveyModel);
        }
    }
}