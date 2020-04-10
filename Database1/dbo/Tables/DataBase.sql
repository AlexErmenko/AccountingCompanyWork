CREATE TABLE [dbo].[DataBase] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NOT NULL,
    [IdServer] INT            NULL,
    CONSTRAINT [DataBase_pk] PRIMARY KEY NONCLUSTERED ([Id] ASC),
    CONSTRAINT [DataBase_Server_Id_fk] FOREIGN KEY ([IdServer]) REFERENCES [dbo].[Server] ([Id])
);

