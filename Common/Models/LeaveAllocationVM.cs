using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Number Of Days")]
        public int NumberOfDays { get; set; }
        [Required]
        [Display(Name = "Allocation Period")]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}
