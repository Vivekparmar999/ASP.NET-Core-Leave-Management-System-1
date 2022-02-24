using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Data
{
    public class LeaveAllocation : BaseEntity
    {

        //Foregin Key must be NavigationPropertyName+Id  or  [ForeginKey("LeaveTypeId")] in NavigationPropertyName
        
        public LeaveType? LeaveType { get; set; }
        public int? LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }
        public int Period { get; set; }
        public int NumberOfDays { get; set; }
    }
}
