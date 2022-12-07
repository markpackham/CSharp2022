﻿CREATE TABLE [dbo].Store
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(250) NOT NULL, 
    [Street] VARCHAR(250) NULL, 
    [City] VARCHAR(50) NULL, 
    [State] NCHAR(2) NULL, 
    [Zip] INT NULL
)
