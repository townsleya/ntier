CREATE TABLE [dbo].[Department] (
    [DepartmentId]  INT          IDENTITY (1, 1) NOT NULL,
    [DepartmenName] VARCHAR (20) NOT NULL,
    CONSTRAINT [pkDepartment] PRIMARY KEY CLUSTERED ([DepartmentId] ASC)
);