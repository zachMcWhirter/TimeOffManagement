using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeOffManagement.Models
{
    // The View Model is an abstraction of the acual Model.
    // It can sometimes contain fewer properties than the Model itself
    public class TimeOffTypeVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Date Created")]

        // The ? char makes the DateTime nullable.
        // So we can choose when to provide that value later
        public DateTime? DateCreated { get; set; }
    }
}
