CREATE TABLE [dbo].[EmployeeDeparment] (
    [EmployeeDeparmentId] INT IDENTITY (1, 1) NOT NULL,
    [EmployeeId]          INT NOT NULL,
    [DepartmentId]        INT NOT NULL,
    CONSTRAINT [pkEmployeeDeparment] PRIMARY KEY CLUSTERED ([EmployeeDeparmentId] ASC),
    CONSTRAINT [fk_EmployeeDeparment_Department] FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([DepartmentId]),
    CONSTRAINT [fk_EmployeeDeparment_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([EmployeeId])
);