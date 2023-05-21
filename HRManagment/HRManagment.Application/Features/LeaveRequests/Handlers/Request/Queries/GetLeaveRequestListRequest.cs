
using HRManagment.Application.DTOs;
using HRManagment.Application.DTOs.LeaveRequest;
using MediatR;
using System.Collections.Generic;

namespace HRManagment.Application.Features.LeaveRequests.Handlers.Request.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestListDto>>
    {
    }
}
