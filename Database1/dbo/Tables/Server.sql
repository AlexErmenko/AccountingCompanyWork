CREATE TABLE [dbo].[Server] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [Server_pk] PRIMARY KEY NONCLUSTERED ([Id] ASC)
);

