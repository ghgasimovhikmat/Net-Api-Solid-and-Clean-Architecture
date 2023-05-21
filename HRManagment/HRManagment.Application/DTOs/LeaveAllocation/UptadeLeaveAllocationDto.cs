using HRManagment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagment.Application.DTOs.LeaveAllocation
{
    public class UptadeLeaveAllocationDto:BaseDto, ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
