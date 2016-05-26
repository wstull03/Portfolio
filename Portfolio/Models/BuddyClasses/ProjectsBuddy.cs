using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    [MetadataType(typeof(ProjectsBuddy))]
    public partial class Project
    {
        public string ProjectListing
        {
            get { return this.ProjectName + ":"; }
            set { }
        }
    }

    public class ProjectsBuddy
    {

        public int ProjectID { get; set; }

        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        [Display(Name = "GitHub Link")]
        public string GitHubLink { get; set; }

    }
}