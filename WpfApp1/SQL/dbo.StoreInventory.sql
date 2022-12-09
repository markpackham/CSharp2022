CREATE TABLE [dbo].[StoreInventory] (
    [Id]        BIGINT IDENTITY (1, 1) NOT NULL,
    [StoreId]   BIGINT NOT NULL,
    [ProductId] BIGINT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [StoreFK] FOREIGN KEY ([StoreId]) REFERENCES [dbo].[Store] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [ProductFK] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id]) ON DELETE CASCADE
);

