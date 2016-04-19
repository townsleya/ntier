using DataAccess;

namespace Middleware.Models
{
    public class EmployeeModel
    {
        public Address Address { get; set; }
        public Department Department { get; set; }
        public Employee Employee { get; set; }
        public EmployeeDeparment EmployeeDeparment { get; set; }
        public EmployeeService EmployeeService { get; set; }
        public Salary Salary { get; set; }
        public Supervisor Supervisor { get; set; }
    }
}
