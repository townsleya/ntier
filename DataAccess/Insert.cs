
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class Insert
    {
        public int InsertEmployee(Employee employee)
        {
            // default to failure...which is tested for in Middleware
            int newEmployeeId = -1;
            using (var db = new DBEntities())
            {
                Employee newEmployee = db.Employees.Add(employee);
                db.SaveChanges();
                // insure we got a valid newEmployee back
                if (newEmployee != null)
                {
                    newEmployeeId = newEmployee.EmployeeId;
                }
            }
            return newEmployeeId;
        }

        public bool InsertAddress(Address address)
        {
            using (var db = new DBEntities())
            {
                Address newAddress = db.Addresses.Add(address);
                db.SaveChanges();
                if (newAddress == null)
                {
                    return false;
                }
            }
            return true;
        }

        public bool InsertEmployeeDepartment(EmployeeDeparment employeeDeparment)
        {
            using (var db = new DBEntities())
            {
                EmployeeDeparment newEmployeeDeparment = db.EmployeeDeparments.Add(employeeDeparment);
                db.SaveChanges();
                if (newEmployeeDeparment == null)
                {
                    return false;
                }
            }
            return true;
        }

        public bool InsertEmployeeService(EmployeeService employeeService)
        {
            using (var db = new DBEntities())
            {
                EmployeeService newEmployeeService = db.EmployeeServices.Add(employeeService);
                db.SaveChanges();
                if (newEmployeeService == null)
                {
                    return false;
                }
            }
            return true;
        }

        public bool InsertSalary(Salary salary)
        {
            using (var db = new DBEntities())
            {
                Salary newSalary = db.Salaries.Add(salary);
                db.SaveChanges();
                if (newSalary == null)
                {
                    return false;
                }
            }
            return true;
        }

        public bool InsertSupervisor(Supervisor supervisor)
        {
            // check to see if a supervisor has been set, if it is 0, then just return true since
            // this is acceptable
            if (supervisor.SupervisorId == 0)
            {
                return true;
            }
            using (var db = new DBEntities())
            {
                Supervisor newSupervisor = db.Supervisors.Add(supervisor);
                db.SaveChanges();
                if (newSupervisor == null)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Get a list of all departments from the DB
        /// </summary>
        /// <returns>List of Departments</returns>
        public List<Department> GetDepartments()
        {
            using (var db = new DBEntities())
            {
                return db.Departments.ToList();
            }
        }

        /// <summary>
        /// Get a list of all employees from the DB
        /// Note: this is also used to get a list of supervisors since a supervisor must be listed as an employee 
        /// before they can be assigned as a supervisor
        /// </summary>
        /// <returns>List of Employees</returns>
        public List<Employee> GetEmployees()
        {
            using (var db = new DBEntities())
            {
                return db.Employees.ToList();
            }
        }

        /// <summary>
        /// Get a list of all employee addresses from the DB
        /// </summary>
        /// <returns>List of Addresses</returns>
        public List<Address> GetAddresses()
        {
            using (var db = new DBEntities())
            {
                return db.Addresses.ToList();
            }
        }

        /// <summary>
        /// Get a list of all employee departments from the DB
        /// </summary>
        /// <returns>List of EmployeeDeparments</returns>
        public List<EmployeeDeparment> GetEmployeeDeparments()
        {
            using (var db = new DBEntities())
            {
                return db.EmployeeDeparments.ToList();
            }
        }

        /// <summary>
        /// Get a list of all employee service dates from the DB
        /// </summary>
        /// <returns>List of EmployeeServices</returns>
        public List<EmployeeService> GetEmployeeServices()
        {
            using (var db = new DBEntities())
            {
                return db.EmployeeServices.ToList();
            }
        }

        /// <summary>
        /// Get a list of all salaries from the DB
        /// </summary>
        /// <returns>List of Salaries</returns>
        public List<Salary> GetSalaries()
        {
            using (var db = new DBEntities())
            {
                return db.Salaries.ToList();
            }
        }

        /// <summary>
        /// Get a list of all supervisors from the DB
        /// </summary>
        /// <returns>List of Supervisors</returns>
        public List<Supervisor> GetSupervisors()
        {
            using (var db = new DBEntities())
            {
                return db.Supervisors.ToList();
            }
        }
    }
}
