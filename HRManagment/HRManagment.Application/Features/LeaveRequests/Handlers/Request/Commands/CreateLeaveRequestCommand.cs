using System;
using System.Collections.Generic;
using System.Text;
using HRManagment.Application.DTOs.LeaveRequest;
using HRManagment.Application.Responses;
using MediatR;
namespace HRManagment.Application.Features.LeaveRequests.Handlers.Request.Commands
{
    public class CreateLeaveRequestCommand:IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
