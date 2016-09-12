using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Social_Media_App.Models
{
    public class Project
    {
        public Guid ProjectID { get; set; }

        [Required]
        [Display(Name = "Project Title")]
        public string ProjectTitle { get; set; }

        [Display(Name = "Project Type")]
        public string ProjectType { get; set; }

        [Required]
        [Display(Name = "Alloted Budget")]
        public decimal ProjectBudget { get; set; }

        [Display(Name = "Project Target")]
        public string ProjectTarget { get; set; }

        [Display(Name = "Start Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Expected End Date")]
        public DateTime ExpectedEndDate { get; set; }
    }
}