using HRManagment.Application.DTOs.LeaveType;
using HRManagment.Application.Responses;
using MediatR;

namespace HRManagment.Application.Features.LeaveTypes.Request.Queries
{   
    public class CreateLeaveTypeCommand:IRequest<BaseCommandResponse>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
        // public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
