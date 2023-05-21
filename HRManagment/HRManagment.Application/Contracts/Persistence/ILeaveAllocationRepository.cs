using HRManagment.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRManagment.Application.Contracts.Persistence
{
    public interface ILeaveAllocationRepository:IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationDetail(int Id);
        Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails();
    }
}
