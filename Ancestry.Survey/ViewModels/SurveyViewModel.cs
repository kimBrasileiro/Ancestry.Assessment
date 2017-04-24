using System.ComponentModel.DataAnnotations;

namespace Ancestry.Survey.ViewModels
{
    public class SurveyViewModel
    {
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Country { get; set; }

        public int Rating { get; set; }

        public string Suggestion { get; set; }

        public string Origin { get; set; }
    }
}