using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Sample_Application.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Display(Name = "Candidate Name")]
        public string StudentName { get; set; }

        [Display(Name = "Guradian Name")]
        public string GuardianName { get; set; }

        public int Age { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }
        public bool IsEnrolled { get; set; }

        [Display(Name = "Currently Lives In")]
        public CityEnum City { get; set; }
        public string Password { get; set; }
    }

    public enum CityEnum
    {
        Delhi = 1,
        Mumbai = 2,
        Calcutta = 3,
        Chennai = 4,
        Pune = 5,
        Bangalore = 6
    }
}
