using System.Collections.Generic;

namespace LeaveManagement.Common.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
        public List<LeaveAllocationVM> leaveAllocations { get; set; }
    }
}
