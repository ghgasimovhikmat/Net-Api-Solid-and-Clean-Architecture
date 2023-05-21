using System;

using HRManagment.Domain.Common;
namespace HRManagment.Domain
{
    public class LeaveType : BaseDomainEntity
    {    
        public string Name { get; set; }
        public int DefaultDays { get; set; }
       
    }
}
