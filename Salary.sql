CREATE TABLE [dbo].[Salary] (
    [SalaryId]   INT   IDENTITY (1, 1) NOT NULL,
    [EmployeeId] INT   NOT NULL,
    [Salary]     MONEY NOT NULL,
    CONSTRAINT [pkSalary] PRIMARY KEY CLUSTERED ([SalaryId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [ixSalary]
    ON [dbo].[Salary]([EmployeeId] ASC);