CREATE TABLE [dbo].[Software] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (MAX) NOT NULL,
    [IdUser]            INT            NULL,
    [IdOperatingSystem] INT            NOT NULL,
    CONSTRAINT [Software_pk] PRIMARY KEY NONCLUSTERED ([Id] ASC),
    CONSTRAINT [Software_OC_Id_fk] FOREIGN KEY ([IdOperatingSystem]) REFERENCES [dbo].[OperatingSystem] ([Id]),
    CONSTRAINT [Software_User_Id_fk] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([Id])
);

