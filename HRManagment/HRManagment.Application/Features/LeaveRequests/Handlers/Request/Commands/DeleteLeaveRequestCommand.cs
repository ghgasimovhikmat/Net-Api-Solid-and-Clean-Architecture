using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagment.Application.Features.LeaveRequests.Handlers.Request.Commands
{
    public  class DeleteLeaveRequestCommand : IRequest
    {
        public int Id { get; set; }
    }
}
