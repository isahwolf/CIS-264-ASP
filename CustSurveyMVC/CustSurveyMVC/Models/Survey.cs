using System.ComponentModel.DataAnnotations;

namespace CustSurveyMVC.Models
{
    public class Survey
    {
        [Key]
        public int SurveyID { get; set; }
        public int CID { get; set; }
        public int Response { get; set; }
        public int Efficiency { get; set; }
        public int Resolution { get; set; }

    }
}
