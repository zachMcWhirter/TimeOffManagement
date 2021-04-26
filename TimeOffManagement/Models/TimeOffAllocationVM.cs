using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TimeOffManagement.Data;

namespace TimeOffManagement.Models
{
    public class TimeOffAllocationVM
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }
        public TimeOffTypeVM TimeOffType { get; set; }
        public int TimeOffTypeId { get; set; }

        // Represents a dropdown list of employees in the db
        public IEnumerable<SelectListItem> Employees { get; set; }

        // Represents a dropdown list containing types of time-off
        public IEnumerable<SelectListItem> TimeOffTypesTypes { get; set; }
    }
}
