using AutoMapper;
using HRManagment.MVC.Models;
using HRManagment.MVC.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagment.MVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap< CreateLeaveTypeDto, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveTypeDto, LeaveTypeVM>().ReverseMap();
        }
    }
}
