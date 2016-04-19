CREATE TABLE [dbo].[Employee] (
    [EmployeeId] INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (MAX) NOT NULL,
    [MiddleName] VARCHAR (MAX) NULL,
    [LastName]   VARCHAR (MAX) NOT NULL,
    [SSN]        VARCHAR (20)  NOT NULL,
    CONSTRAINT [pkEmployeeId] PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);