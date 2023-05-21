
using MediatR;
using HRManagment.Application.DTOs.LeaveAllocation;
namespace HRManagment.Application.Features.LeaveAllocations.Handlers.Request.Queries
{
   public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
