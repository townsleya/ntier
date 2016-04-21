using System.Collections.Generic;
using System.Data;
using Middleware.Models;
using DataAccess;

namespace Middleware
{
    public class BusinessLogic
    {
        // instantiate the datalayer object for the class once
        private Insert data = new Insert();

        /// <summary>
        /// Inserts a new employee into the DB. This method handles all FK and returns a string to the client
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public string AddEmployee(EmployeeModel employee)
        {
            int newEmployeeId = data.InsertEmployee(employee.Employee);
            // check to see we got a valid employee back before continuing with the rest or our keys will break
            if (newEmployeeId == -1)
            {
                return "Error adding to Employee table";
            }

            // add addresses
            employee.Address.EmployeeId = newEmployeeId;
            if (!data.InsertAddress(employee.Address))
            {
                return "Error adding to Address table";
            }

            // add an employeeDepartment
            employee.EmployeeDeparment.EmployeeId = newEmployeeId;
            if (!data.InsertEmployeeDepartment(employee.EmployeeDeparment))
            {
                return "Error adding to EmployeeDepartment table";
            }

            // add a salary
            employee.Salary.EmployeeId = newEmployeeId;
            if (!data.InsertSalary(employee.Salary))
            {
                return "Error adding to Salary table";
            }

            // add a employee service
            employee.EmployeeService.EmployeeId = newEmployeeId;
            if (!data.InsertEmployeeService(employee.EmployeeService))
            {
                return "Error adding to EmployeeService table";
            }

            // add a supervisor
            // note an employee may or may not have a supervisor
            employee.Supervisor.EmployeeId = newEmployeeId;
            if (!data.InsertSupervisor(employee.Supervisor))
            {
                return "Error adding to Supervisor table";
            }

            // if we got here, everything was added correctly, so return a successful status
            return "Employee added";
        }

        /// <summary>
        /// Gets a list of Departments from the data layer
        /// </summary>
        /// <returns>List of Departments</returns>
        public List<Department> FillDepartments()
        {
            return data.GetDepartments();
        }

        /// <summary>
        /// Gets a list of Employees from the data layer
        /// This list CAN be used to pick a supervisor for a new employee
        /// </summary>
        /// <returns>List of Employees</returns>
        public List<Employee> FillEmployees()
        {
            return data.GetEmployees();
        }

        /// <summary>
        /// Gets a list of Addresses from the data layer
        /// </summary>
        /// <returns>List of Addresses</returns>
        public DataTable FillAddresses()
        {
            return data.GetAddresses();
        }

        /// <summary>
        /// Gets a list of EmployeeDeparments from the data layer
        /// </summary>
        /// <returns>List of EmployeeDeparments</returns>
        public List<EmployeeDeparment> FillEmployeeDepartments()
        {
            return data.GetEmployeeDeparments();
        }

        /// <summary>
        /// Gets a list of Departments from the data layer
        /// </summary>
        /// <returns>List of Departments</returns>
        public List<EmployeeService> FillEmployeeServices()
        {
            return data.GetEmployeeServices();
        }

        /// <summary>
        /// Gets a list of Salaries from the data layer
        /// </summary>
        /// <returns>List of Salaries</returns>
        public List<Salary> FillSalaries()
        {
            return data.GetSalaries();
        }

        /// <summary>
        /// Gets a list of Supervisors from the data layer
        /// </summary>
        /// <returns>List of Supervisors</returns>
        public List<Supervisor> FillSupvisors()
        {
            return data.GetSupervisors();
        }
    }
}
