
using HRManagment.Application.DTOs;
using HRManagment.Application.DTOs.LeaveAllocation;
using MediatR;
using System.Collections.Generic;

namespace HRManagment.Application.Features.LeaveAllocations.Handlers.Request.Queries
{
    public class GetLeaveAllocationListRequest:IRequest<List<LeaveAllocationDto>>
    {
    }
}
