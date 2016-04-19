using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Middleware;
using DataAccess;
using Middleware.Models;

namespace Client
{
    public partial class AddEmployee : Form
    {
        public enum States
        {
            AL,
            AK,
            AS,
            AZ,
            AR,
            CA,
            CO,
            CT,
            DE,
            DC,
            FM,
            FL,
            GA,
            GU,
            HI,
            ID,
            IL,
            IN,
            IA,
            KS,
            KY,
            LA,
            ME,
            MH,
            MD,
            MA,
            MI,
            MN,
            MS,
            MO,
            MT,
            NE,
            NV,
            NH,
            NJ,
            NM,
            NY,
            NC,
            ND,
            MP,
            OH,
            OK,
            OR,
            PW,
            PA,
            PR,
            RI,
            SC,
            SD,
            TN,
            TX,
            UT,
            VT,
            VI,
            VA,
            WA,
            WV,
            WI,
            WY
        }

        private List<Department> departments;
        private List<Employee> supervisors;
        private BusinessLogic businessLogic = new BusinessLogic();

        public AddEmployee()
        {
            InitializeComponent();
            // update the comboboxes
            UpdateComboBoxes();
        }

        private void UpdateComboBoxes()
        {
            // populate departments combobox
            departments = businessLogic.FillDepartments();
            foreach (Department d in departments)
            {
                cb_departmentName.Items.Add(d.DepartmenName);
            }

            // populate supervisors combobox
            supervisors = businessLogic.FillEmployees();
            foreach (Employee e in supervisors)
            {
                string name = e.MiddleName == string.Empty
                    ? e.FirstName + " " + e.LastName
                    : e.FirstName + " " + e.MiddleName + " " + e.LastName;
                cb_supervisor.Items.Add(name);
            }

            // populate states combobox
            cb_state.DataSource = Enum.GetValues(typeof(States));
            cb_state.FormattingEnabled = true;
        }

        private void InitializeComponent()
        {
            this.label_firstName = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.label_MiddleName = new System.Windows.Forms.Label();
            this.tb_middleName = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.label_SSN = new System.Windows.Forms.Label();
            this.tb_ssn = new System.Windows.Forms.TextBox();
            this.label_hdr_PersonalInfo = new System.Windows.Forms.Label();
            this.label_hdr_Address = new System.Windows.Forms.Label();
            this.tb_streetNumber = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.tb_zipCode = new System.Windows.Forms.TextBox();
            this.label_zip = new System.Windows.Forms.Label();
            this.cb_state = new System.Windows.Forms.ComboBox();
            this.label_hdr_salary = new System.Windows.Forms.Label();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.label_salary = new System.Windows.Forms.Label();
            this.label_hdr_department = new System.Windows.Forms.Label();
            this.cb_departmentName = new System.Windows.Forms.ComboBox();
            this.label_department = new System.Windows.Forms.Label();
            this.label_hdr_supervisor = new System.Windows.Forms.Label();
            this.cb_supervisor = new System.Windows.Forms.ComboBox();
            this.label_supervisor = new System.Windows.Forms.Label();
            this.label_hdr_datesEmployeed = new System.Windows.Forms.Label();
            this.label_startDate = new System.Windows.Forms.Label();
            this.label_EndDate = new System.Windows.Forms.Label();
            this.datePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.datePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(16, 82);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(57, 13);
            this.label_firstName.TabIndex = 0;
            this.label_firstName.Text = "First Name";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(91, 82);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(170, 20);
            this.tb_firstName.TabIndex = 1;
            // 
            // label_MiddleName
            // 
            this.label_MiddleName.AutoSize = true;
            this.label_MiddleName.Location = new System.Drawing.Point(16, 104);
            this.label_MiddleName.Name = "label_MiddleName";
            this.label_MiddleName.Size = new System.Drawing.Size(69, 13);
            this.label_MiddleName.TabIndex = 2;
            this.label_MiddleName.Text = "Middle Name";
            // 
            // tb_middleName
            // 
            this.tb_middleName.Location = new System.Drawing.Point(91, 104);
            this.tb_middleName.Name = "tb_middleName";
            this.tb_middleName.Size = new System.Drawing.Size(170, 20);
            this.tb_middleName.TabIndex = 3;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(16, 127);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(58, 13);
            this.label_LastName.TabIndex = 4;
            this.label_LastName.Text = "Last Name";
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(91, 127);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(170, 20);
            this.tb_lastName.TabIndex = 5;
            // 
            // label_SSN
            // 
            this.label_SSN.AutoSize = true;
            this.label_SSN.Location = new System.Drawing.Point(16, 151);
            this.label_SSN.Name = "label_SSN";
            this.label_SSN.Size = new System.Drawing.Size(29, 13);
            this.label_SSN.TabIndex = 6;
            this.label_SSN.Text = "SSN";
            // 
            // tb_ssn
            // 
            this.tb_ssn.Location = new System.Drawing.Point(91, 151);
            this.tb_ssn.Name = "tb_ssn";
            this.tb_ssn.Size = new System.Drawing.Size(100, 20);
            this.tb_ssn.TabIndex = 7;
            // 
            // label_hdr_PersonalInfo
            // 
            this.label_hdr_PersonalInfo.AutoSize = true;
            this.label_hdr_PersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hdr_PersonalInfo.Location = new System.Drawing.Point(15, 50);
            this.label_hdr_PersonalInfo.Name = "label_hdr_PersonalInfo";
            this.label_hdr_PersonalInfo.Size = new System.Drawing.Size(194, 22);
            this.label_hdr_PersonalInfo.TabIndex = 8;
            this.label_hdr_PersonalInfo.Text = "Personal Information";
            // 
            // label_hdr_Address
            // 
            this.label_hdr_Address.AutoSize = true;
            this.label_hdr_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hdr_Address.Location = new System.Drawing.Point(15, 181);
            this.label_hdr_Address.Name = "label_hdr_Address";
            this.label_hdr_Address.Size = new System.Drawing.Size(83, 22);
            this.label_hdr_Address.TabIndex = 9;
            this.label_hdr_Address.Text = "Address";
            // 
            // tb_streetNumber
            // 
            this.tb_streetNumber.Location = new System.Drawing.Point(91, 214);
            this.tb_streetNumber.Name = "tb_streetNumber";
            this.tb_streetNumber.Size = new System.Drawing.Size(239, 20);
            this.tb_streetNumber.TabIndex = 11;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(16, 214);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(45, 13);
            this.label_Address.TabIndex = 10;
            this.label_Address.Text = "Address";
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(91, 237);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(149, 20);
            this.tb_city.TabIndex = 12;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(16, 240);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(24, 13);
            this.label_city.TabIndex = 13;
            this.label_city.Text = "City";
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Location = new System.Drawing.Point(16, 263);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(32, 13);
            this.label_state.TabIndex = 14;
            this.label_state.Text = "State";
            // 
            // tb_zipCode
            // 
            this.tb_zipCode.Location = new System.Drawing.Point(91, 283);
            this.tb_zipCode.Name = "tb_zipCode";
            this.tb_zipCode.Size = new System.Drawing.Size(100, 20);
            this.tb_zipCode.TabIndex = 17;
            // 
            // label_zip
            // 
            this.label_zip.AutoSize = true;
            this.label_zip.Location = new System.Drawing.Point(16, 286);
            this.label_zip.Name = "label_zip";
            this.label_zip.Size = new System.Drawing.Size(50, 13);
            this.label_zip.TabIndex = 16;
            this.label_zip.Text = "Zip Code";
            // 
            // cb_state
            // 
            this.cb_state.Location = new System.Drawing.Point(91, 260);
            this.cb_state.Name = "cb_state";
            this.cb_state.Size = new System.Drawing.Size(49, 21);
            this.cb_state.TabIndex = 15;
            // 
            // label_hdr_salary
            // 
            this.label_hdr_salary.AutoSize = true;
            this.label_hdr_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hdr_salary.Location = new System.Drawing.Point(15, 320);
            this.label_hdr_salary.Name = "label_hdr_salary";
            this.label_hdr_salary.Size = new System.Drawing.Size(67, 22);
            this.label_hdr_salary.TabIndex = 18;
            this.label_hdr_salary.Text = "Salary";
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(91, 348);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(100, 20);
            this.tb_salary.TabIndex = 20;
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(16, 355);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(36, 13);
            this.label_salary.TabIndex = 19;
            this.label_salary.Text = "Salary";
            // 
            // label_hdr_department
            // 
            this.label_hdr_department.AutoSize = true;
            this.label_hdr_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hdr_department.Location = new System.Drawing.Point(15, 388);
            this.label_hdr_department.Name = "label_hdr_department";
            this.label_hdr_department.Size = new System.Drawing.Size(113, 22);
            this.label_hdr_department.TabIndex = 21;
            this.label_hdr_department.Text = "Department";
            // 
            // cb_departmentName
            // 
            this.cb_departmentName.FormattingEnabled = true;
            this.cb_departmentName.Location = new System.Drawing.Point(91, 418);
            this.cb_departmentName.Name = "cb_departmentName";
            this.cb_departmentName.Size = new System.Drawing.Size(120, 21);
            this.cb_departmentName.TabIndex = 23;
            // 
            // label_department
            // 
            this.label_department.AutoSize = true;
            this.label_department.Location = new System.Drawing.Point(16, 426);
            this.label_department.Name = "label_department";
            this.label_department.Size = new System.Drawing.Size(62, 13);
            this.label_department.TabIndex = 22;
            this.label_department.Text = "Department";
            // 
            // label_hdr_supervisor
            // 
            this.label_hdr_supervisor.AutoSize = true;
            this.label_hdr_supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hdr_supervisor.Location = new System.Drawing.Point(15, 465);
            this.label_hdr_supervisor.Name = "label_hdr_supervisor";
            this.label_hdr_supervisor.Size = new System.Drawing.Size(106, 22);
            this.label_hdr_supervisor.TabIndex = 24;
            this.label_hdr_supervisor.Text = "Supervisor";
            // 
            // cb_supervisor
            // 
            this.cb_supervisor.FormattingEnabled = true;
            this.cb_supervisor.Location = new System.Drawing.Point(91, 495);
            this.cb_supervisor.Name = "cb_supervisor";
            this.cb_supervisor.Size = new System.Drawing.Size(149, 21);
            this.cb_supervisor.TabIndex = 26;
            // 
            // label_supervisor
            // 
            this.label_supervisor.AutoSize = true;
            this.label_supervisor.Location = new System.Drawing.Point(17, 503);
            this.label_supervisor.Name = "label_supervisor";
            this.label_supervisor.Size = new System.Drawing.Size(57, 13);
            this.label_supervisor.TabIndex = 25;
            this.label_supervisor.Text = "Supervisor";
            // 
            // label_hdr_datesEmployeed
            // 
            this.label_hdr_datesEmployeed.AutoSize = true;
            this.label_hdr_datesEmployeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hdr_datesEmployeed.Location = new System.Drawing.Point(15, 533);
            this.label_hdr_datesEmployeed.Name = "label_hdr_datesEmployeed";
            this.label_hdr_datesEmployeed.Size = new System.Drawing.Size(166, 22);
            this.label_hdr_datesEmployeed.TabIndex = 27;
            this.label_hdr_datesEmployeed.Text = "Dates Employeed";
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Location = new System.Drawing.Point(16, 567);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(55, 13);
            this.label_startDate.TabIndex = 28;
            this.label_startDate.Text = "Start Date";
            // 
            // label_EndDate
            // 
            this.label_EndDate.AutoSize = true;
            this.label_EndDate.Location = new System.Drawing.Point(16, 593);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(52, 13);
            this.label_EndDate.TabIndex = 30;
            this.label_EndDate.Text = "End Date";
            // 
            // datePicker_startDate
            // 
            this.datePicker_startDate.Location = new System.Drawing.Point(91, 561);
            this.datePicker_startDate.Name = "datePicker_startDate";
            this.datePicker_startDate.Size = new System.Drawing.Size(200, 20);
            this.datePicker_startDate.TabIndex = 29;
            // 
            // datePicker_endDate
            // 
            this.datePicker_endDate.Location = new System.Drawing.Point(91, 587);
            this.datePicker_endDate.Name = "datePicker_endDate";
            this.datePicker_endDate.Size = new System.Drawing.Size(200, 20);
            this.datePicker_endDate.TabIndex = 31;
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.Location = new System.Drawing.Point(67, 637);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(142, 23);
            this.btn_addEmployee.TabIndex = 32;
            this.btn_addEmployee.Text = "Save Employee";
            this.btn_addEmployee.UseVisualStyleBackColor = true;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Display DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddEmployee
            // 
            this.ClientSize = new System.Drawing.Size(482, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addEmployee);
            this.Controls.Add(this.datePicker_endDate);
            this.Controls.Add(this.datePicker_startDate);
            this.Controls.Add(this.label_startDate);
            this.Controls.Add(this.label_EndDate);
            this.Controls.Add(this.label_hdr_datesEmployeed);
            this.Controls.Add(this.cb_supervisor);
            this.Controls.Add(this.label_supervisor);
            this.Controls.Add(this.label_hdr_supervisor);
            this.Controls.Add(this.cb_departmentName);
            this.Controls.Add(this.label_department);
            this.Controls.Add(this.label_hdr_department);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.label_hdr_salary);
            this.Controls.Add(this.cb_state);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.tb_zipCode);
            this.Controls.Add(this.label_zip);
            this.Controls.Add(this.tb_streetNumber);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_hdr_Address);
            this.Controls.Add(this.label_hdr_PersonalInfo);
            this.Controls.Add(this.tb_ssn);
            this.Controls.Add(this.label_SSN);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.tb_middleName);
            this.Controls.Add(this.label_MiddleName);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.label_firstName);
            this.Name = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            // build employee section
            Employee emp = new Employee
            {
                FirstName = tb_firstName.Text,
                MiddleName = tb_middleName.Text,
                LastName = tb_lastName.Text,
                SSN = tb_ssn.Text
            };

            // build address section
            Address addr = new Address
            {
                StreetNumber = tb_streetNumber.Text,
                City = tb_city.Text,
                State = cb_state.SelectedValue.ToString(),
                ZipCode = tb_zipCode.Text
            };

            // build salary section
            Salary sal = new Salary();
            decimal money = 0;
            decimal.TryParse(tb_salary.Text, out money);
            sal.Salary1 = money;

            // build department section
            // if nothing is set, then assume employee is assigned to "Not Assigned" which has an id of 1 
            int id = 1;
            foreach (Department d in departments.Where(d => cb_departmentName.SelectedIndex.ToString() == d.DepartmenName))
            {
                id = d.DepartmentId;
            }
            EmployeeDeparment empDep = new EmployeeDeparment
            {
                DepartmentId = id
            };

            id = 0;
            // build supervisor section
            // note: not everyone has to have a supervisor...
            foreach (Employee employee in from employee in supervisors let name = employee.MiddleName == string.Empty
                ? employee.FirstName + " " + employee.LastName
                : employee.FirstName + " " + employee.MiddleName + " " + employee.LastName
                                          where name == cb_supervisor.SelectedIndex.ToString() select employee)
            {
                id = employee.EmployeeId;
            }
            Supervisor super = new Supervisor
            {
                SupervisorEmployeeId = id
            };

            // build dates employeed
            // note: ending date can be empty...since they can be currently employed
            EmployeeService empService = new EmployeeService
            {
                StartDate = datePicker_startDate.Value,
                EndDate = datePicker_endDate.Value
            };

            // create new employee model
            EmployeeModel newEmployee = new EmployeeModel
            {
                Employee = emp,
                Address = addr,
                Salary = sal,
                EmployeeDeparment = empDep,
                Supervisor = super,
                EmployeeService = empService
            };

            // finally build the complete model to pass down

            // call middleware to do logic prior to adding employee to DB
            string result = businessLogic.AddEmployee(newEmployee);

            if (result == "Employee added")
            {
                ClearControls();
                UpdateComboBoxes();
            }

            MessageBox.Show(result);
        }

        /// <summary>
        /// Clears the current values of the form...only called on a successful call so that the user
        /// can correct any errors reported back...
        /// </summary>
        private void ClearControls()
        {
            this.datePicker_endDate.Value = DateTime.Now;
            this.datePicker_startDate.Value = DateTime.Now;
            this.cb_supervisor.Items.Clear();
            this.cb_departmentName.Items.Clear();
            this.tb_salary.Text = String.Empty;
            this.tb_city.Text = String.Empty;
            this.tb_zipCode.Text = String.Empty;
            this.tb_streetNumber.Text = String.Empty;
            this.tb_ssn.Text = String.Empty;
            this.tb_lastName.Text = String.Empty;
            this.tb_middleName.Text = String.Empty;
            this.tb_firstName.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dbContents = new DisplayDBContents();
            dbContents.Closed += (s, args) => this.Close();
            dbContents.Show();
        }
    }
}
