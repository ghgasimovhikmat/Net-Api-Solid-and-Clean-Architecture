
using HRManagment.Application.DTOs.LeaveType;
using MediatR;

using System.Collections.Generic;


namespace HRManagment.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
    }
}
