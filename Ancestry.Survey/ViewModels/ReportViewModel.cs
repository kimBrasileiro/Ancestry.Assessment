using System.Collections.Generic;

namespace Ancestry.Survey.ViewModels
{
    public class ReportViewModel
    {
        public int AverageAge { get; set; }

        public int AverageRating { get; set; }

        public List<CountryViewModel> CountryList { get; set; }

        public List<GenderViewModel> GenderList { get; set; }

        public int Total { get; set; }
    }
}