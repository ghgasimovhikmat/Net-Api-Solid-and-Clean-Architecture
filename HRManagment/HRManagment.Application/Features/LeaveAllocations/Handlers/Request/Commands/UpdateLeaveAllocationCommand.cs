using HRManagment.Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagment.Application.Features.LeaveAllocations.Handlers.Request.Commands
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>      
    {
        //public int Id { get; set; }
        public UptadeLeaveAllocationDto LeaveAllocationDto { get; set; }
        //public UptadeLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
