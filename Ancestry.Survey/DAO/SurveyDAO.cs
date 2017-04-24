using Ancestry.Survey.Models;
using Ancestry.Survey.Model;

namespace Ancestry.Survey.DAO
{
    class SurveyDAO
    {
        public void Create(SurveyModel surveyModel)
        {
            SurveyDBEntities surveyDBEntities = new SurveyDBEntities();

            Model.Survey survey = new Model.Survey();
            survey.Name = surveyModel.Name;
            survey.Email = surveyModel.Email;
            survey.Age = surveyModel.Age;
            survey.Gender = surveyModel.Gender;
            survey.Country = surveyModel.Country;
            survey.Rating = surveyModel.Rating;
            survey.Suggestion = surveyModel.Suggestion;
            survey.Origin = surveyModel.Origin;

            surveyDBEntities.Survey.Add(survey);
            surveyDBEntities.SaveChanges();
        }
    }
}