using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class TopicRegistrationViewModel
    {
        [Required]
        [Display(Name = "Employee")]
        public int SelectedEmployee { get; set; }
        public IList<SelectListItem> Employees { get; set; } = new List<SelectListItem>();

        [Required]
        [Display(Name = "Topic")]
        public int SelectedTopic { get; set; }
        public IList<SelectListItem> Topics { get; set; } = new List<SelectListItem>();

        [Required]
        [Display(Name = "Subject")]
        public int SelectedSubject { get; set; }
        public IList<SelectListItem> Subjects { get; set; } = new List<SelectListItem>();
    }
}
