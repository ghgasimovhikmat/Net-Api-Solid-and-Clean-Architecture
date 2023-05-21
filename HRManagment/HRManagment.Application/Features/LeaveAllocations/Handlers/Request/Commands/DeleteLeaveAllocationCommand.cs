using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace HRManagment.Application.Features.LeaveAllocations.Handlers.Request.Commands
{
   public class DeleteLeaveAllocationCommand : IRequest
    {
        public int Id { get; set; }
    }
}
