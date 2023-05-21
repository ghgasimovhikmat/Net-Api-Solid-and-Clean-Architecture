using HRManagment.Domain;
using HRManagment.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagment.Persistence.Repositories
{
    public class LeaveTypeRepository: GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly HrLeaveManagmentDbContext _dbContext;

        public LeaveTypeRepository(HrLeaveManagmentDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
