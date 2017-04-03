
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/25/2016 20:10:34
-- Generated from EDMX file: C:\Users\Home\Desktop\DateBase\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CourseWork];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ObjectFile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Objects] DROP CONSTRAINT [FK_ObjectFile];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comments] DROP CONSTRAINT [FK_ObjectComment];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectCategory_Object]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectCategory] DROP CONSTRAINT [FK_ObjectCategory_Object];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectCategory_Category]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectCategory] DROP CONSTRAINT [FK_ObjectCategory_Category];
GO
IF OBJECT_ID(N'[dbo].[FK_UserComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comments] DROP CONSTRAINT [FK_UserComment];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectUser_Object]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectUser] DROP CONSTRAINT [FK_ObjectUser_Object];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectUser_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectUser] DROP CONSTRAINT [FK_ObjectUser_User];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectCollection_Object]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectCollection] DROP CONSTRAINT [FK_ObjectCollection_Object];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectCollection_Collection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObjectCollection] DROP CONSTRAINT [FK_ObjectCollection_Collection];
GO
IF OBJECT_ID(N'[dbo].[FK_CollectionComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comments] DROP CONSTRAINT [FK_CollectionComment];
GO
IF OBJECT_ID(N'[dbo].[FK_ObjectMark]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Marks] DROP CONSTRAINT [FK_ObjectMark];
GO
IF OBJECT_ID(N'[dbo].[FK_CollectionMark]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Marks] DROP CONSTRAINT [FK_CollectionMark];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCollection_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCollection] DROP CONSTRAINT [FK_UserCollection_User];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCollection_Collection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCollection] DROP CONSTRAINT [FK_UserCollection_Collection];
GO
IF OBJECT_ID(N'[dbo].[FK_UserMark]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Marks] DROP CONSTRAINT [FK_UserMark];
GO
IF OBJECT_ID(N'[dbo].[FK_CollectionCategory_Collection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CollectionCategory] DROP CONSTRAINT [FK_CollectionCategory_Collection];
GO
IF OBJECT_ID(N'[dbo].[FK_CollectionCategory_Category]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CollectionCategory] DROP CONSTRAINT [FK_CollectionCategory_Category];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Objects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Objects];
GO
IF OBJECT_ID(N'[dbo].[Files]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Files];
GO
IF OBJECT_ID(N'[dbo].[Comments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comments];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Collections]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Collections];
GO
IF OBJECT_ID(N'[dbo].[Marks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Marks];
GO
IF OBJECT_ID(N'[dbo].[ObjectCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObjectCategory];
GO
IF OBJECT_ID(N'[dbo].[ObjectUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObjectUser];
GO
IF OBJECT_ID(N'[dbo].[ObjectCollection]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObjectCollection];
GO
IF OBJECT_ID(N'[dbo].[UserCollection]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserCollection];
GO
IF OBJECT_ID(N'[dbo].[CollectionCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CollectionCategory];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Objects'
CREATE TABLE [dbo].[Objects] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [AvarageMark] float  NULL,
    [CreatingDate] datetime  NOT NULL,
    [File_Id] int  NOT NULL
);
GO

-- Creating table 'Files'
CREATE TABLE [dbo].[Files] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Comments'
CREATE TABLE [dbo].[Comments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Object_Id] int  NULL,
    [User_Id] int  NOT NULL,
    [Collection_Id] int  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Collections'
CREATE TABLE [dbo].[Collections] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [AverageMark] float  NULL,
    [CreatingDate] datetime  NOT NULL
);
GO

-- Creating table 'Marks'
CREATE TABLE [dbo].[Marks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Value] int  NOT NULL,
    [Object_Id] int  NULL,
    [Collection_Id] int  NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'ObjectCategory'
CREATE TABLE [dbo].[ObjectCategory] (
    [Objects_Id] int  NOT NULL,
    [Categories_Id] int  NOT NULL
);
GO

-- Creating table 'ObjectUser'
CREATE TABLE [dbo].[ObjectUser] (
    [Objects_Id] int  NOT NULL,
    [Users_Id] int  NOT NULL
);
GO

-- Creating table 'ObjectCollection'
CREATE TABLE [dbo].[ObjectCollection] (
    [Objects_Id] int  NOT NULL,
    [Collections_Id] int  NOT NULL
);
GO

-- Creating table 'UserCollection'
CREATE TABLE [dbo].[UserCollection] (
    [Users_Id] int  NOT NULL,
    [Collections_Id] int  NOT NULL
);
GO

-- Creating table 'CollectionCategory'
CREATE TABLE [dbo].[CollectionCategory] (
    [Collections_Id] int  NOT NULL,
    [Categories_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Objects'
ALTER TABLE [dbo].[Objects]
ADD CONSTRAINT [PK_Objects]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Files'
ALTER TABLE [dbo].[Files]
ADD CONSTRAINT [PK_Files]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [PK_Comments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Collections'
ALTER TABLE [dbo].[Collections]
ADD CONSTRAINT [PK_Collections]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [PK_Marks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Objects_Id], [Categories_Id] in table 'ObjectCategory'
ALTER TABLE [dbo].[ObjectCategory]
ADD CONSTRAINT [PK_ObjectCategory]
    PRIMARY KEY CLUSTERED ([Objects_Id], [Categories_Id] ASC);
GO

-- Creating primary key on [Objects_Id], [Users_Id] in table 'ObjectUser'
ALTER TABLE [dbo].[ObjectUser]
ADD CONSTRAINT [PK_ObjectUser]
    PRIMARY KEY CLUSTERED ([Objects_Id], [Users_Id] ASC);
GO

-- Creating primary key on [Objects_Id], [Collections_Id] in table 'ObjectCollection'
ALTER TABLE [dbo].[ObjectCollection]
ADD CONSTRAINT [PK_ObjectCollection]
    PRIMARY KEY CLUSTERED ([Objects_Id], [Collections_Id] ASC);
GO

-- Creating primary key on [Users_Id], [Collections_Id] in table 'UserCollection'
ALTER TABLE [dbo].[UserCollection]
ADD CONSTRAINT [PK_UserCollection]
    PRIMARY KEY CLUSTERED ([Users_Id], [Collections_Id] ASC);
GO

-- Creating primary key on [Collections_Id], [Categories_Id] in table 'CollectionCategory'
ALTER TABLE [dbo].[CollectionCategory]
ADD CONSTRAINT [PK_CollectionCategory]
    PRIMARY KEY CLUSTERED ([Collections_Id], [Categories_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [File_Id] in table 'Objects'
ALTER TABLE [dbo].[Objects]
ADD CONSTRAINT [FK_ObjectFile]
    FOREIGN KEY ([File_Id])
    REFERENCES [dbo].[Files]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectFile'
CREATE INDEX [IX_FK_ObjectFile]
ON [dbo].[Objects]
    ([File_Id]);
GO

-- Creating foreign key on [Object_Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_ObjectComment]
    FOREIGN KEY ([Object_Id])
    REFERENCES [dbo].[Objects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectComment'
CREATE INDEX [IX_FK_ObjectComment]
ON [dbo].[Comments]
    ([Object_Id]);
GO

-- Creating foreign key on [Objects_Id] in table 'ObjectCategory'
ALTER TABLE [dbo].[ObjectCategory]
ADD CONSTRAINT [FK_ObjectCategory_Object]
    FOREIGN KEY ([Objects_Id])
    REFERENCES [dbo].[Objects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Categories_Id] in table 'ObjectCategory'
ALTER TABLE [dbo].[ObjectCategory]
ADD CONSTRAINT [FK_ObjectCategory_Category]
    FOREIGN KEY ([Categories_Id])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectCategory_Category'
CREATE INDEX [IX_FK_ObjectCategory_Category]
ON [dbo].[ObjectCategory]
    ([Categories_Id]);
GO

-- Creating foreign key on [User_Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_UserComment]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserComment'
CREATE INDEX [IX_FK_UserComment]
ON [dbo].[Comments]
    ([User_Id]);
GO

-- Creating foreign key on [Objects_Id] in table 'ObjectUser'
ALTER TABLE [dbo].[ObjectUser]
ADD CONSTRAINT [FK_ObjectUser_Object]
    FOREIGN KEY ([Objects_Id])
    REFERENCES [dbo].[Objects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Users_Id] in table 'ObjectUser'
ALTER TABLE [dbo].[ObjectUser]
ADD CONSTRAINT [FK_ObjectUser_User]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectUser_User'
CREATE INDEX [IX_FK_ObjectUser_User]
ON [dbo].[ObjectUser]
    ([Users_Id]);
GO

-- Creating foreign key on [Objects_Id] in table 'ObjectCollection'
ALTER TABLE [dbo].[ObjectCollection]
ADD CONSTRAINT [FK_ObjectCollection_Object]
    FOREIGN KEY ([Objects_Id])
    REFERENCES [dbo].[Objects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Collections_Id] in table 'ObjectCollection'
ALTER TABLE [dbo].[ObjectCollection]
ADD CONSTRAINT [FK_ObjectCollection_Collection]
    FOREIGN KEY ([Collections_Id])
    REFERENCES [dbo].[Collections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectCollection_Collection'
CREATE INDEX [IX_FK_ObjectCollection_Collection]
ON [dbo].[ObjectCollection]
    ([Collections_Id]);
GO

-- Creating foreign key on [Collection_Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_CollectionComment]
    FOREIGN KEY ([Collection_Id])
    REFERENCES [dbo].[Collections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollectionComment'
CREATE INDEX [IX_FK_CollectionComment]
ON [dbo].[Comments]
    ([Collection_Id]);
GO

-- Creating foreign key on [Object_Id] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [FK_ObjectMark]
    FOREIGN KEY ([Object_Id])
    REFERENCES [dbo].[Objects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjectMark'
CREATE INDEX [IX_FK_ObjectMark]
ON [dbo].[Marks]
    ([Object_Id]);
GO

-- Creating foreign key on [Collection_Id] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [FK_CollectionMark]
    FOREIGN KEY ([Collection_Id])
    REFERENCES [dbo].[Collections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollectionMark'
CREATE INDEX [IX_FK_CollectionMark]
ON [dbo].[Marks]
    ([Collection_Id]);
GO

-- Creating foreign key on [Users_Id] in table 'UserCollection'
ALTER TABLE [dbo].[UserCollection]
ADD CONSTRAINT [FK_UserCollection_User]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Collections_Id] in table 'UserCollection'
ALTER TABLE [dbo].[UserCollection]
ADD CONSTRAINT [FK_UserCollection_Collection]
    FOREIGN KEY ([Collections_Id])
    REFERENCES [dbo].[Collections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCollection_Collection'
CREATE INDEX [IX_FK_UserCollection_Collection]
ON [dbo].[UserCollection]
    ([Collections_Id]);
GO

-- Creating foreign key on [User_Id] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [FK_UserMark]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserMark'
CREATE INDEX [IX_FK_UserMark]
ON [dbo].[Marks]
    ([User_Id]);
GO

-- Creating foreign key on [Collections_Id] in table 'CollectionCategory'
ALTER TABLE [dbo].[CollectionCategory]
ADD CONSTRAINT [FK_CollectionCategory_Collection]
    FOREIGN KEY ([Collections_Id])
    REFERENCES [dbo].[Collections]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Categories_Id] in table 'CollectionCategory'
ALTER TABLE [dbo].[CollectionCategory]
ADD CONSTRAINT [FK_CollectionCategory_Category]
    FOREIGN KEY ([Categories_Id])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollectionCategory_Category'
CREATE INDEX [IX_FK_CollectionCategory_Category]
ON [dbo].[CollectionCategory]
    ([Categories_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------