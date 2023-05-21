using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace HRManagment.Application.Features.LeaveTypes.Handlers.Request.Commands
{
    public class DeleteLeaveTypeCommand:IRequest
    {
        public int Id { get; set; }
    }
}
