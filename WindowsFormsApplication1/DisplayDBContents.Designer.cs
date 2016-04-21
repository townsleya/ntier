using System.Windows.Forms;
using Client.DBDataSet5TableAdapters;
using Middleware;

namespace Client
{
    partial class DisplayDBContents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private BusinessLogic businessLogic = new BusinessLogic();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_Employees = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet6 = new Client.DBDataSet6();
            this.dataGridView_Address = new System.Windows.Forms.DataGridView();
            this.addressIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet5 = new Client.DBDataSet5();
            this.dataGridView_Departments = new System.Windows.Forms.DataGridView();
            this.departmentIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet4 = new Client.DBDataSet4();
            this.dataGridView_Salaries = new System.Windows.Forms.DataGridView();
            this.salaryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet3 = new Client.DBDataSet3();
            this.dataGridView_Supervisors = new System.Windows.Forms.DataGridView();
            this.supervisorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorEmployeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet2 = new Client.DBDataSet2();
            this.dataGridView_EmployeeDepartment = new System.Windows.Forms.DataGridView();
            this.employeeDeparmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDeparmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet1 = new Client.DBDataSet1();
            this.dataGridView_EmployeeService = new System.Windows.Forms.DataGridView();
            this.employeeServiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Client.DBDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Employee = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Departments = new System.Windows.Forms.Label();
            this.label_Salaries = new System.Windows.Forms.Label();
            this.label_Supervisors = new System.Windows.Forms.Label();
            this.label_EmployeeDepartment = new System.Windows.Forms.Label();
            this.label_EmployeeService = new System.Windows.Forms.Label();
            this.employeeServiceTableAdapter = new Client.DBDataSetTableAdapters.EmployeeServiceTableAdapter();
            this.employeeDeparmentTableAdapter = new Client.DBDataSet1TableAdapters.EmployeeDeparmentTableAdapter();
            this.supervisorTableAdapter = new Client.DBDataSet2TableAdapters.SupervisorTableAdapter();
            this.salaryTableAdapter = new Client.DBDataSet3TableAdapters.SalaryTableAdapter();
            this.departmentTableAdapter = new Client.DBDataSet4TableAdapters.DepartmentTableAdapter();
            this.addressTableAdapter = new Client.DBDataSet5TableAdapters.AddressTableAdapter();
            this.employeeTableAdapter = new Client.DBDataSet6TableAdapters.EmployeeTableAdapter();
            this.dbDataSet51 = new Client.DBDataSet5();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Departments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Salaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supervisors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervisorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDeparmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet51)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Employees
            // 
            this.dataGridView_Employees.AllowUserToAddRows = false;
            this.dataGridView_Employees.AllowUserToDeleteRows = false;
            this.dataGridView_Employees.AutoGenerateColumns = false;
            this.dataGridView_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn5,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.sSNDataGridViewTextBoxColumn});
            this.dataGridView_Employees.DataSource = this.employeeBindingSource;
            this.dataGridView_Employees.Location = new System.Drawing.Point(107, 26);
            this.dataGridView_Employees.Name = "dataGridView_Employees";
            this.dataGridView_Employees.ReadOnly = true;
            this.dataGridView_Employees.Size = new System.Drawing.Size(510, 91);
            this.dataGridView_Employees.TabIndex = 0;
            // 
            // employeeIdDataGridViewTextBoxColumn5
            // 
            this.employeeIdDataGridViewTextBoxColumn5.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn5.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn5.Name = "employeeIdDataGridViewTextBoxColumn5";
            this.employeeIdDataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            this.sSNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dBDataSet6;
            // 
            // dBDataSet6
            // 
            this.dBDataSet6.DataSetName = "DBDataSet6";
            this.dBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_Address
            // 
            this.dataGridView_Address.AllowUserToAddRows = false;
            this.dataGridView_Address.AllowUserToDeleteRows = false;
            this.dataGridView_Address.AutoGenerateColumns = false;
            this.dataGridView_Address.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Address.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn4,
            this.streetNumberDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn});
            this.dataGridView_Address.DataSource = this.addressBindingSource;
            this.dataGridView_Address.Location = new System.Drawing.Point(107, 123);
            this.dataGridView_Address.Name = "dataGridView_Address";
            this.dataGridView_Address.ReadOnly = true;
            this.dataGridView_Address.Size = new System.Drawing.Size(510, 92);
            this.dataGridView_Address.TabIndex = 1;
            // 
            // addressIdDataGridViewTextBoxColumn
            // 
            this.addressIdDataGridViewTextBoxColumn.DataPropertyName = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.HeaderText = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.Name = "addressIdDataGridViewTextBoxColumn";
            this.addressIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn4
            // 
            this.employeeIdDataGridViewTextBoxColumn4.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn4.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn4.Name = "employeeIdDataGridViewTextBoxColumn4";
            this.employeeIdDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            this.streetNumberDataGridViewTextBoxColumn.DataPropertyName = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.HeaderText = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            this.streetNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            this.zipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "Address";
            this.addressBindingSource.DataSource = this.dBDataSet5;
            // 
            // dBDataSet5
            // 
            this.dBDataSet5.DataSetName = "DBDataSet5";
            this.dBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_Departments
            // 
            this.dataGridView_Departments.AllowUserToAddRows = false;
            this.dataGridView_Departments.AllowUserToDeleteRows = false;
            this.dataGridView_Departments.AutoGenerateColumns = false;
            this.dataGridView_Departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Departments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIdDataGridViewTextBoxColumn1,
            this.departmenNameDataGridViewTextBoxColumn});
            this.dataGridView_Departments.DataSource = this.departmentBindingSource;
            this.dataGridView_Departments.Location = new System.Drawing.Point(107, 221);
            this.dataGridView_Departments.Name = "dataGridView_Departments";
            this.dataGridView_Departments.ReadOnly = true;
            this.dataGridView_Departments.Size = new System.Drawing.Size(510, 96);
            this.dataGridView_Departments.TabIndex = 2;
            // 
            // departmentIdDataGridViewTextBoxColumn1
            // 
            this.departmentIdDataGridViewTextBoxColumn1.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn1.HeaderText = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn1.Name = "departmentIdDataGridViewTextBoxColumn1";
            this.departmentIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // departmenNameDataGridViewTextBoxColumn
            // 
            this.departmenNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmenName";
            this.departmenNameDataGridViewTextBoxColumn.HeaderText = "DepartmenName";
            this.departmenNameDataGridViewTextBoxColumn.Name = "departmenNameDataGridViewTextBoxColumn";
            this.departmenNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dBDataSet4;
            // 
            // dBDataSet4
            // 
            this.dBDataSet4.DataSetName = "DBDataSet4";
            this.dBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_Salaries
            // 
            this.dataGridView_Salaries.AllowUserToAddRows = false;
            this.dataGridView_Salaries.AllowUserToDeleteRows = false;
            this.dataGridView_Salaries.AutoGenerateColumns = false;
            this.dataGridView_Salaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Salaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn3,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView_Salaries.DataSource = this.salaryBindingSource;
            this.dataGridView_Salaries.Location = new System.Drawing.Point(107, 323);
            this.dataGridView_Salaries.Name = "dataGridView_Salaries";
            this.dataGridView_Salaries.ReadOnly = true;
            this.dataGridView_Salaries.Size = new System.Drawing.Size(510, 97);
            this.dataGridView_Salaries.TabIndex = 3;
            // 
            // salaryIdDataGridViewTextBoxColumn
            // 
            this.salaryIdDataGridViewTextBoxColumn.DataPropertyName = "SalaryId";
            this.salaryIdDataGridViewTextBoxColumn.HeaderText = "SalaryId";
            this.salaryIdDataGridViewTextBoxColumn.Name = "salaryIdDataGridViewTextBoxColumn";
            this.salaryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn3
            // 
            this.employeeIdDataGridViewTextBoxColumn3.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn3.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn3.Name = "employeeIdDataGridViewTextBoxColumn3";
            this.employeeIdDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "Salary";
            this.salaryBindingSource.DataSource = this.dBDataSet3;
            // 
            // dBDataSet3
            // 
            this.dBDataSet3.DataSetName = "DBDataSet3";
            this.dBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_Supervisors
            // 
            this.dataGridView_Supervisors.AllowUserToAddRows = false;
            this.dataGridView_Supervisors.AllowUserToDeleteRows = false;
            this.dataGridView_Supervisors.AutoGenerateColumns = false;
            this.dataGridView_Supervisors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Supervisors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supervisorIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn2,
            this.supervisorEmployeeIdDataGridViewTextBoxColumn,
            this.assignedDateDataGridViewTextBoxColumn,
            this.releasedDateDataGridViewTextBoxColumn});
            this.dataGridView_Supervisors.DataSource = this.supervisorBindingSource;
            this.dataGridView_Supervisors.Location = new System.Drawing.Point(107, 426);
            this.dataGridView_Supervisors.Name = "dataGridView_Supervisors";
            this.dataGridView_Supervisors.ReadOnly = true;
            this.dataGridView_Supervisors.Size = new System.Drawing.Size(510, 94);
            this.dataGridView_Supervisors.TabIndex = 4;
            // 
            // supervisorIdDataGridViewTextBoxColumn
            // 
            this.supervisorIdDataGridViewTextBoxColumn.DataPropertyName = "SupervisorId";
            this.supervisorIdDataGridViewTextBoxColumn.HeaderText = "SupervisorId";
            this.supervisorIdDataGridViewTextBoxColumn.Name = "supervisorIdDataGridViewTextBoxColumn";
            this.supervisorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn2
            // 
            this.employeeIdDataGridViewTextBoxColumn2.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn2.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn2.Name = "employeeIdDataGridViewTextBoxColumn2";
            this.employeeIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // supervisorEmployeeIdDataGridViewTextBoxColumn
            // 
            this.supervisorEmployeeIdDataGridViewTextBoxColumn.DataPropertyName = "SupervisorEmployeeId";
            this.supervisorEmployeeIdDataGridViewTextBoxColumn.HeaderText = "SupervisorEmployeeId";
            this.supervisorEmployeeIdDataGridViewTextBoxColumn.Name = "supervisorEmployeeIdDataGridViewTextBoxColumn";
            this.supervisorEmployeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assignedDateDataGridViewTextBoxColumn
            // 
            this.assignedDateDataGridViewTextBoxColumn.DataPropertyName = "AssignedDate";
            this.assignedDateDataGridViewTextBoxColumn.HeaderText = "AssignedDate";
            this.assignedDateDataGridViewTextBoxColumn.Name = "assignedDateDataGridViewTextBoxColumn";
            this.assignedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releasedDateDataGridViewTextBoxColumn
            // 
            this.releasedDateDataGridViewTextBoxColumn.DataPropertyName = "ReleasedDate";
            this.releasedDateDataGridViewTextBoxColumn.HeaderText = "ReleasedDate";
            this.releasedDateDataGridViewTextBoxColumn.Name = "releasedDateDataGridViewTextBoxColumn";
            this.releasedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supervisorBindingSource
            // 
            this.supervisorBindingSource.DataMember = "Supervisor";
            this.supervisorBindingSource.DataSource = this.dBDataSet2;
            // 
            // dBDataSet2
            // 
            this.dBDataSet2.DataSetName = "DBDataSet2";
            this.dBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_EmployeeDepartment
            // 
            this.dataGridView_EmployeeDepartment.AllowUserToAddRows = false;
            this.dataGridView_EmployeeDepartment.AllowUserToDeleteRows = false;
            this.dataGridView_EmployeeDepartment.AutoGenerateColumns = false;
            this.dataGridView_EmployeeDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmployeeDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeDeparmentIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn1,
            this.departmentIdDataGridViewTextBoxColumn});
            this.dataGridView_EmployeeDepartment.DataSource = this.employeeDeparmentBindingSource;
            this.dataGridView_EmployeeDepartment.Location = new System.Drawing.Point(107, 526);
            this.dataGridView_EmployeeDepartment.Name = "dataGridView_EmployeeDepartment";
            this.dataGridView_EmployeeDepartment.ReadOnly = true;
            this.dataGridView_EmployeeDepartment.Size = new System.Drawing.Size(510, 90);
            this.dataGridView_EmployeeDepartment.TabIndex = 5;
            // 
            // employeeDeparmentIdDataGridViewTextBoxColumn
            // 
            this.employeeDeparmentIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeDeparmentId";
            this.employeeDeparmentIdDataGridViewTextBoxColumn.HeaderText = "EmployeeDeparmentId";
            this.employeeDeparmentIdDataGridViewTextBoxColumn.Name = "employeeDeparmentIdDataGridViewTextBoxColumn";
            this.employeeDeparmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn1
            // 
            this.employeeIdDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn1.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn1.Name = "employeeIdDataGridViewTextBoxColumn1";
            this.employeeIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDeparmentBindingSource
            // 
            this.employeeDeparmentBindingSource.DataMember = "EmployeeDeparment";
            this.employeeDeparmentBindingSource.DataSource = this.dBDataSet1;
            // 
            // dBDataSet1
            // 
            this.dBDataSet1.DataSetName = "DBDataSet1";
            this.dBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_EmployeeService
            // 
            this.dataGridView_EmployeeService.AllowUserToAddRows = false;
            this.dataGridView_EmployeeService.AllowUserToDeleteRows = false;
            this.dataGridView_EmployeeService.AutoGenerateColumns = false;
            this.dataGridView_EmployeeService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmployeeService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeServiceIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dataGridView_EmployeeService.DataSource = this.employeeServiceBindingSource;
            this.dataGridView_EmployeeService.Location = new System.Drawing.Point(107, 622);
            this.dataGridView_EmployeeService.Name = "dataGridView_EmployeeService";
            this.dataGridView_EmployeeService.ReadOnly = true;
            this.dataGridView_EmployeeService.Size = new System.Drawing.Size(510, 77);
            this.dataGridView_EmployeeService.TabIndex = 6;
            // 
            // employeeServiceIdDataGridViewTextBoxColumn
            // 
            this.employeeServiceIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeServiceId";
            this.employeeServiceIdDataGridViewTextBoxColumn.HeaderText = "EmployeeServiceId";
            this.employeeServiceIdDataGridViewTextBoxColumn.Name = "employeeServiceIdDataGridViewTextBoxColumn";
            this.employeeServiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeServiceBindingSource
            // 
            this.employeeServiceBindingSource.DataMember = "EmployeeService";
            this.employeeServiceBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 748);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Employee
            // 
            this.label_Employee.AutoSize = true;
            this.label_Employee.Location = new System.Drawing.Point(13, 64);
            this.label_Employee.Name = "label_Employee";
            this.label_Employee.Size = new System.Drawing.Size(58, 13);
            this.label_Employee.TabIndex = 8;
            this.label_Employee.Text = "Employees";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(16, 168);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(56, 13);
            this.label_Address.TabIndex = 9;
            this.label_Address.Text = "Addresses";
            // 
            // label_Departments
            // 
            this.label_Departments.AutoSize = true;
            this.label_Departments.Location = new System.Drawing.Point(16, 268);
            this.label_Departments.Name = "label_Departments";
            this.label_Departments.Size = new System.Drawing.Size(67, 13);
            this.label_Departments.TabIndex = 10;
            this.label_Departments.Text = "Departments";
            // 
            // label_Salaries
            // 
            this.label_Salaries.AutoSize = true;
            this.label_Salaries.Location = new System.Drawing.Point(13, 372);
            this.label_Salaries.Name = "label_Salaries";
            this.label_Salaries.Size = new System.Drawing.Size(44, 13);
            this.label_Salaries.TabIndex = 11;
            this.label_Salaries.Text = "Salaries";
            // 
            // label_Supervisors
            // 
            this.label_Supervisors.AutoSize = true;
            this.label_Supervisors.Location = new System.Drawing.Point(13, 467);
            this.label_Supervisors.Name = "label_Supervisors";
            this.label_Supervisors.Size = new System.Drawing.Size(62, 13);
            this.label_Supervisors.TabIndex = 12;
            this.label_Supervisors.Text = "Supervisors";
            // 
            // label_EmployeeDepartment
            // 
            this.label_EmployeeDepartment.AutoSize = true;
            this.label_EmployeeDepartment.Location = new System.Drawing.Point(-3, 569);
            this.label_EmployeeDepartment.Name = "label_EmployeeDepartment";
            this.label_EmployeeDepartment.Size = new System.Drawing.Size(108, 13);
            this.label_EmployeeDepartment.TabIndex = 13;
            this.label_EmployeeDepartment.Text = "EmployeeDepartment";
            // 
            // label_EmployeeService
            // 
            this.label_EmployeeService.AutoSize = true;
            this.label_EmployeeService.Location = new System.Drawing.Point(16, 655);
            this.label_EmployeeService.Name = "label_EmployeeService";
            this.label_EmployeeService.Size = new System.Drawing.Size(89, 13);
            this.label_EmployeeService.TabIndex = 14;
            this.label_EmployeeService.Text = "EmployeeService";
            // 
            // employeeServiceTableAdapter
            // 
            this.employeeServiceTableAdapter.ClearBeforeFill = true;
            // 
            // employeeDeparmentTableAdapter
            // 
            this.employeeDeparmentTableAdapter.ClearBeforeFill = true;
            // 
            // supervisorTableAdapter
            // 
            this.supervisorTableAdapter.ClearBeforeFill = true;
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // dbDataSet51
            // 
            this.dbDataSet51.DataSetName = "DBDataSet5";
            this.dbDataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DisplayDBContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 824);
            this.Controls.Add(this.label_EmployeeService);
            this.Controls.Add(this.label_EmployeeDepartment);
            this.Controls.Add(this.label_Supervisors);
            this.Controls.Add(this.label_Salaries);
            this.Controls.Add(this.label_Departments);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Employee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_EmployeeService);
            this.Controls.Add(this.dataGridView_EmployeeDepartment);
            this.Controls.Add(this.dataGridView_Supervisors);
            this.Controls.Add(this.dataGridView_Salaries);
            this.Controls.Add(this.dataGridView_Departments);
            this.Controls.Add(this.dataGridView_Address);
            this.Controls.Add(this.dataGridView_Employees);
            this.Name = "DisplayDBContents";
            this.Text = "DisplayDBContents";
            this.Load += new System.EventHandler(this.DisplayDBContents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Departments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Salaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supervisors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervisorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDeparmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet51)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Employees;
        private DataGridView dataGridView_Address;
        private System.Windows.Forms.DataGridView dataGridView_Departments;
        private System.Windows.Forms.DataGridView dataGridView_Salaries;
        private System.Windows.Forms.DataGridView dataGridView_Supervisors;
        private System.Windows.Forms.DataGridView dataGridView_EmployeeDepartment;
        private System.Windows.Forms.DataGridView dataGridView_EmployeeService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Employee;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Departments;
        private System.Windows.Forms.Label label_Salaries;
        private System.Windows.Forms.Label label_Supervisors;
        private System.Windows.Forms.Label label_EmployeeDepartment;
        private System.Windows.Forms.Label label_EmployeeService;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource employeeServiceBindingSource;
        private DBDataSetTableAdapters.EmployeeServiceTableAdapter employeeServiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeServiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DBDataSet1 dBDataSet1;
        private System.Windows.Forms.BindingSource employeeDeparmentBindingSource;
        private DBDataSet1TableAdapters.EmployeeDeparmentTableAdapter employeeDeparmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDeparmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private DBDataSet2 dBDataSet2;
        private System.Windows.Forms.BindingSource supervisorBindingSource;
        private DBDataSet2TableAdapters.SupervisorTableAdapter supervisorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorEmployeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedDateDataGridViewTextBoxColumn;
        private DBDataSet3 dBDataSet3;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private DBDataSet3TableAdapters.SalaryTableAdapter salaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DBDataSet4 dBDataSet4;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DBDataSet4TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmenNameDataGridViewTextBoxColumn;
        private DBDataSet5 dBDataSet5;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private DBDataSet5TableAdapters.AddressTableAdapter addressTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private DBDataSet6 dBDataSet6;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DBDataSet6TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private DBDataSet5 dbDataSet51;
    }
}