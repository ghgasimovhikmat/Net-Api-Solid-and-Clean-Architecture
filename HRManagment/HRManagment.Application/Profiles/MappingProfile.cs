using AutoMapper;
using HRManagment.Application.DTOs;
using HRManagment.Application.DTOs.LeaveAllocation;
using HRManagment.Application.DTOs.LeaveRequest;
using HRManagment.Application.DTOs.LeaveType;
using HRManagment.Domain;

namespace HRManagment.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region LeaveRequest Mapping
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, UpdateLeaveRequestDto>().ReverseMap();
            #endregion LeaveRequest 

            #region LeaveAllocation Mapping
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation, CreateLeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation, UptadeLeaveAllocationDto>().ReverseMap();

            #endregion LeaveAllocation
            #region LeaveType Mapping
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeDto>().ReverseMap();
            #endregion LeaveType 

        }
    }
}
