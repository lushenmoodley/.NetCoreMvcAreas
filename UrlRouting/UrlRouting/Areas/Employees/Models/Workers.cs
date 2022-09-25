using System.ComponentModel.DataAnnotations;

namespace UrlRouting.Areas.Employees.Models
{
    public class Workers
    {
        public string FullName { get; set; }

        public string Occupation { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public double Salary { get; set; }

      
    }
}

