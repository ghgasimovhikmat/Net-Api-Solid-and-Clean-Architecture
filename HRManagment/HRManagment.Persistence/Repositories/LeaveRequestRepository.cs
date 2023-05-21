using HRManagment.Application.Contracts.Persistence;
using HRManagment.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HRManagment.Persistence.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly HrLeaveManagmentDbContext _dbContext;

        public LeaveRequestRepository(HrLeaveManagmentDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus)
        {
            leaveRequest.Approved = ApprovalStatus;
            _dbContext.Entry(leaveRequest).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<LeaveRequest> GetLeaveRequestDetail(int Id)
        {
            var leaveRequests = await _dbContext.LeaveRequests
                .Include(e => e.LeaveType)
                .FirstOrDefaultAsync(e=>e.Id==Id);
            return leaveRequests;
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestWithDetails()
        {
            var leaveRequests = await _dbContext.LeaveRequests
                .Include(e => e.LeaveType)
                .ToListAsync();
            return leaveRequests;
        }
    }
}
