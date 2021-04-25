using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeOffManagement.Data
{
    public class TimeOffAllocation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public Employee Employee { get; set; }
        // Usually I use an int for Id, but it can also be a long string with
        // unique charaters (which is what I did this time)
        public string EmployeeId { get; set; }
        public TimeOffType TimeOffType { get; set; }
        public int TimeOffTypeId { get; set; }
    }
}
