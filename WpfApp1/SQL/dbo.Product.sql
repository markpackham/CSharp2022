CREATE TABLE [dbo].[Product] (
    [Id]    BIGINT        IDENTITY (1, 1) NOT NULL,
    [Maker] VARCHAR (100) NOT NULL,
    [Brand] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

