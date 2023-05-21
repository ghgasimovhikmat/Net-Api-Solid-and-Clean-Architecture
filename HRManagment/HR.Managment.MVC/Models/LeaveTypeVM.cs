using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagment.MVC.Models
{
    public class LeaveTypeVM : CreateLeaveTypeVM
    {
        public int Id { get; set; }
    }
    public class CreateLeaveTypeVM
    {
        [Required]
        public int Name { get; set; }
        [Required]
        [Display(Name="Default Number of Days")]
        public int DefaultDays { get; set; }
    }
}
