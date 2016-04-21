using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Middleware;

namespace Client
{
    public partial class DisplayDBContents : Form
    {
        public DisplayDBContents()
        {
            InitializeComponent();
        }

        /// <summary>
        /// redirect back to the add employee page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addEmployee = new AddEmployee();
            addEmployee.Closed += (s, args) => this.Close();
            addEmployee.Show();
        }

        // I know I am doing something wrong here...and it is probably something really stupid, but I cannot see it...
        // GRRRRR....
        private void DisplayDBContents_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.dBDataSet6.Employee);
            //this.addressTableAdapter.Fill(this.dBDataSet5.Address);
            //ds.Tables.Add(businessLogic.FillAddresses();
            //DataSet ds = new DBDataSet();
            //ds.Tables.Add(businessLogic.FillAddresses());

            // fill Address table
            DataTable dt = new DataTable();
            BindingSource bsSource = new BindingSource {DataSource = businessLogic.FillAddresses()};
            DataGridView addressTableAdapter = dataGridView_Address;
            addressTableAdapter.AutoGenerateColumns = false;
            addressTableAdapter.DataSource = dt;
            addressTableAdapter.DataSource = bsSource;
            addressTableAdapter.Refresh();

            this.departmentTableAdapter.Fill(this.dBDataSet4.Department);
            this.salaryTableAdapter.Fill(this.dBDataSet3.Salary);
            this.supervisorTableAdapter.Fill(this.dBDataSet2.Supervisor);
            this.employeeDeparmentTableAdapter.Fill(this.dBDataSet1.EmployeeDeparment);
            this.employeeServiceTableAdapter.Fill(this.dBDataSet.EmployeeService);
        }
    }
}
