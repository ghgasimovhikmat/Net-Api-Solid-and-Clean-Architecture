
using HRManagment.Application.DTOs.LeaveType;
using MediatR;


namespace HRManagment.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeDetailRequest:IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
