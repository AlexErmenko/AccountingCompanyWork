CREATE TABLE [dbo].[User] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (MAX) NOT NULL,
    [MiddleName] NVARCHAR (MAX) NULL,
    [LastName]   NVARCHAR (MAX) NULL,
    CONSTRAINT [User_pk] PRIMARY KEY NONCLUSTERED ([Id] ASC)
);

