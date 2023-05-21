using HRManagment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagment.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto:BaseDto
    {
        public bool Approved { get; set; }
    }
}
