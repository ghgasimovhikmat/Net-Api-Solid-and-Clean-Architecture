using HRManagment.Application.DTOs;
using HRManagment.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagment.Application.Features.LeaveTypes.Handlers.Request.Commands
{
    public class UpdateLeaveTypeCommand:IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
    