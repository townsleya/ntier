CREATE TABLE [dbo].[EmployeeService] (
    [EmployeeServiceId] INT      IDENTITY (1, 1) NOT NULL,
    [EmployeeId]        INT      NOT NULL,
    [StartDate]         DATETIME NOT NULL,
    [EndDate]           DATETIME NULL,
    CONSTRAINT [pkEmployeeService] PRIMARY KEY CLUSTERED ([EmployeeServiceId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [ixEmployeeService]
    ON [dbo].[EmployeeService]([EmployeeId] ASC);