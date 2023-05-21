using HRManagment.Application.DTOs.Common;
using HRManagment.Application.DTOs.LeaveType;

namespace HRManagment.Application.DTOs.LeaveAllocation
{
    
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
