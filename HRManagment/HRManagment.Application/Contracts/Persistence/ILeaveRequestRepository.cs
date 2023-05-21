using HRManagment.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Application.Contracts.Persistence
{
    public interface ILeaveRequestRepository: IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestDetail(int Id);
        Task<List<LeaveRequest>> GetLeaveRequestWithDetails();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest,bool? ApprovalStatus);
    }
}
