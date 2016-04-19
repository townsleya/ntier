CREATE TABLE [dbo].[Address] (
    [AddressId]    INT           IDENTITY (1, 1) NOT NULL,
    [EmployeeId]   INT           NOT NULL,
    [StreetNumber] VARCHAR (200) NOT NULL,
    [City]         VARCHAR (50)  NOT NULL,
    [State]        CHAR (2)      NOT NULL,
    [ZipCode]      NCHAR (10)    NOT NULL,
    CONSTRAINT [pkAddress] PRIMARY KEY CLUSTERED ([AddressId] ASC)
);