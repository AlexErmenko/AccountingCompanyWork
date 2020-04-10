CREATE TABLE [dbo].[SoftwareDataBase] (
    [IdSoftware] INT NOT NULL,
    [IdDataBase] INT NOT NULL,
    CONSTRAINT [SoftwareDataBase_pk] PRIMARY KEY NONCLUSTERED ([IdSoftware] ASC, [IdDataBase] ASC),
    CONSTRAINT [SoftwareDataBase_DataBase_Id_fk] FOREIGN KEY ([IdDataBase]) REFERENCES [dbo].[DataBase] ([Id]),
    CONSTRAINT [SoftwareDataBase_Software_Id_fk] FOREIGN KEY ([IdSoftware]) REFERENCES [dbo].[Software] ([Id])
);

