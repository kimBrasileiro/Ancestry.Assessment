using System.Collections.Generic;

namespace Ancestry.Survey.Models
{
    public class ReportModel
    {
        public int AverageAge { get; set; }

        public int AverageRating { get; set; }

        public List<CountryModel> CountryList {get;set; }

        public List<GenderModel> GenderList { get; set; }

        public int Total { get; set; }
    }
}