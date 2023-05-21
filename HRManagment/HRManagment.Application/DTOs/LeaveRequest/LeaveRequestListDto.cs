using HRManagment.Application.DTOs.Common;
using HRManagment.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagment.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
    }
}
