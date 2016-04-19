CREATE TABLE [dbo].[Supervisor] (
    [SupervisorId]         INT      IDENTITY (1, 1) NOT NULL,
    [EmployeeId]           INT      NOT NULL,
    [SupervisorEmployeeId] INT      NOT NULL,
    [AssignedDate]         DATETIME NOT NULL,
    [ReleasedDate]         DATETIME NULL,
    CONSTRAINT [pkSupervisor] PRIMARY KEY CLUSTERED ([SupervisorId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [ixEmployeeId]
    ON [dbo].[Supervisor]([EmployeeId] ASC);


GO
CREATE NONCLUSTERED INDEX [ixSupervisorEmployeeId]
    ON [dbo].[Supervisor]([SupervisorEmployeeId] ASC);