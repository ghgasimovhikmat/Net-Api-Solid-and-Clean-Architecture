using HRManagment.Application.Contracts.Persistence;
using HRManagment.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Persistence.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly HrLeaveManagmentDbContext _dbContext;

        public LeaveAllocationRepository(HrLeaveManagmentDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LeaveAllocation> GetLeaveAllocationDetail(int Id)
        {
            var leaveAllocations = await _dbContext.LeaveAllocations
                 .Include(e => e.LeaveType)
                 .FirstOrDefaultAsync(e => e.Id == Id);
            return leaveAllocations;
        }

        public async Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails()
        {
            var leaveAllocations = await _dbContext.LeaveAllocations
                .Include(e => e.LeaveType)
                .ToListAsync();
            return leaveAllocations;
        }
    }
}
