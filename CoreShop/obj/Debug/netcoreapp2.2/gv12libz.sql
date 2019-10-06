IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Items] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    [DiscountPrice] int NOT NULL,
    [Price] int NOT NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191003023113_InitialMigration', N'2.2.4-servicing-10062');

GO

