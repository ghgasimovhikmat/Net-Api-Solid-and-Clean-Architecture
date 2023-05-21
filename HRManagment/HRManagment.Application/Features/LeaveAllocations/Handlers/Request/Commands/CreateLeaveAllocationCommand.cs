using System;
using System.Collections.Generic;
using System.Text;
using HRManagment.Application.DTOs.LeaveAllocation;
using MediatR;
namespace HRManagment.Application.Features.LeaveAllocations.Handlers.Request.Commands
{
    public class CreateLeaveAllocationCommand:IRequest<int>
    {
        public CreateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
