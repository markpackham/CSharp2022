CREATE TABLE [dbo].[Store] (
    [Id]     BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]   VARCHAR (250) NOT NULL,
    [Street] VARCHAR (250) NULL,
    [City]   VARCHAR (50)  NULL,
    [State]  NCHAR (2)     NULL,
    [Zip]    INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

