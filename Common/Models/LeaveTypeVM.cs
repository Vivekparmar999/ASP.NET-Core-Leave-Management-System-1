using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveTypeVM
    {

        public int Id { get; set; }
        [Required]
        [Display(Name = "Leave Type Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Default Number Of Days")]
        public int DefaultDays { get; set; }
    }
}
