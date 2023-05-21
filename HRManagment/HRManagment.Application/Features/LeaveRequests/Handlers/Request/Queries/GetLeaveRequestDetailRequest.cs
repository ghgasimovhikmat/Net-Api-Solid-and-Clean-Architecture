using HRManagment.Application.DTOs;
using MediatR;

namespace HRManagment.Application.Features.LeaveRequests.Request.Queries
{
   public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
