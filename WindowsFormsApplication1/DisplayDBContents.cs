using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Middleware;

namespace Client
{
    public partial class DisplayDBContents : Form
    {
        public DisplayDBContents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addEmployee = new AddEmployee();
            addEmployee.Closed += (s, args) => this.Close();
            addEmployee.Show();
        }

        private void DisplayDBContents_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.dBDataSet6.Employee);
            this.addressTableAdapter.Fill(this.dBDataSet5.Address);
            this.departmentTableAdapter.Fill(this.dBDataSet4.Department);
            this.salaryTableAdapter.Fill(this.dBDataSet3.Salary);
            this.supervisorTableAdapter.Fill(this.dBDataSet2.Supervisor);
            this.employeeDeparmentTableAdapter.Fill(this.dBDataSet1.EmployeeDeparment);
            this.employeeServiceTableAdapter.Fill(this.dBDataSet.EmployeeService);
        }
    }
}
