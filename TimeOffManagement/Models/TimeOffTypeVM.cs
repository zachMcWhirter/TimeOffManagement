using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeOffManagement.Models
{
    // The View Model is an abstraction of the acual Model.
    // It can sometimes contain fewer properties than the Model itself
    public class DetailsTimeOffTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class CreateTimeOffTypeVM
    {
        [Required]
        public string Name { get; set; }
    }
}
