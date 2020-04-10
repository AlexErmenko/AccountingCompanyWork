CREATE TABLE [dbo].[OperatingSystem] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NOT NULL,
    [Capacity] NVARCHAR (10)  NOT NULL,
    CONSTRAINT [OC_pk] PRIMARY KEY NONCLUSTERED ([Id] ASC)
);

