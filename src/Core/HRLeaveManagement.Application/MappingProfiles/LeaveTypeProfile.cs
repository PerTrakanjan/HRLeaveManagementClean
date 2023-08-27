using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace HRLeaveManagement.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
    }
}