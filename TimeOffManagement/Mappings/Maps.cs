using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeOffManagement.Data;
using TimeOffManagement.Models;

namespace TimeOffManagement.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<TimeOffType, TimeOffTypeVM>().ReverseMap();
            CreateMap<TimeOffAllocation, TimeOffAllocationVM>().ReverseMap();
            CreateMap<TimeOffHistory, TimeOffHistoryVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
