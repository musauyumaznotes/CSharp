
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/31/2022 08:57:36
-- Generated from EDMX file: C:\Users\musau\Desktop\Murat Yücedağ\C# DevExpress İş Takip Projesi\is_takip_proje\is_takip_proje\Entity\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DbIsTakip];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Personeller_Departmanlar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personeller] DROP CONSTRAINT [FK_Personeller_Departmanlar];
GO
IF OBJECT_ID(N'[dbo].[FK_Firmalar_Ilceler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Firmalar] DROP CONSTRAINT [FK_Firmalar_Ilceler];
GO
IF OBJECT_ID(N'[dbo].[FK_Firmalar_Sehirler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Firmalar] DROP CONSTRAINT [FK_Firmalar_Sehirler];
GO
IF OBJECT_ID(N'[dbo].[FK_Firmalar_Sektorler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Firmalar] DROP CONSTRAINT [FK_Firmalar_Sektorler];
GO
IF OBJECT_ID(N'[dbo].[FK_GorevDetaylar_Personeller]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Gorevler] DROP CONSTRAINT [FK_GorevDetaylar_Personeller];
GO
IF OBJECT_ID(N'[dbo].[FK_GorevDetaylar_Personeller1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Gorevler] DROP CONSTRAINT [FK_GorevDetaylar_Personeller1];
GO
IF OBJECT_ID(N'[dbo].[FK_Ilceler_Sehirler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ilceler] DROP CONSTRAINT [FK_Ilceler_Sehirler];
GO
IF OBJECT_ID(N'[dbo].[FK_Cagrilar_Firmalar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cagrilar] DROP CONSTRAINT [FK_Cagrilar_Firmalar];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Adminler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Adminler];
GO
IF OBJECT_ID(N'[dbo].[Departmanlar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departmanlar];
GO
IF OBJECT_ID(N'[dbo].[Firmalar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Firmalar];
GO
IF OBJECT_ID(N'[dbo].[Gorevler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gorevler];
GO
IF OBJECT_ID(N'[dbo].[Ilceler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ilceler];
GO
IF OBJECT_ID(N'[dbo].[Personeller]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personeller];
GO
IF OBJECT_ID(N'[dbo].[Sehirler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sehirler];
GO
IF OBJECT_ID(N'[dbo].[Sektorler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sektorler];
GO
IF OBJECT_ID(N'[dbo].[Cagrilar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cagrilar];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Adminler'
CREATE TABLE [dbo].[Adminler] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Kullanici] nvarchar(15)  NULL,
    [Sifre] nvarchar(15)  NULL
);
GO

-- Creating table 'Departmanlar'
CREATE TABLE [dbo].[Departmanlar] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ad] nvarchar(30)  NULL
);
GO

-- Creating table 'Firmalar'
CREATE TABLE [dbo].[Firmalar] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SehirId] int  NULL,
    [IlceId] int  NULL,
    [SektorId] int  NULL,
    [FirmaAdi] nvarchar(50)  NULL,
    [Yetkili] nvarchar(50)  NULL,
    [Telefon] nvarchar(20)  NULL,
    [Mail] nvarchar(50)  NULL,
    [Adres] nvarchar(200)  NULL
);
GO

-- Creating table 'Gorevler'
CREATE TABLE [dbo].[Gorevler] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GorevAlanId] int  NULL,
    [GorevVerenId] int  NULL,
    [Aciklama] varchar(max)  NULL,
    [Tarih] datetime  NULL,
    [Durum] bit  NULL
);
GO

-- Creating table 'Ilceler'
CREATE TABLE [dbo].[Ilceler] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SehirId] int  NULL,
    [IlceAdi] nvarchar(50)  NULL
);
GO

-- Creating table 'Personeller'
CREATE TABLE [dbo].[Personeller] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DepartmanId] int  NULL,
    [Ad] nvarchar(30)  NULL,
    [Soyad] nvarchar(30)  NULL,
    [Mail] nvarchar(50)  NULL,
    [Telefon] nvarchar(20)  NULL,
    [Gorsel] nvarchar(100)  NULL,
    [Durum] bit  NULL
);
GO

-- Creating table 'Sehirler'
CREATE TABLE [dbo].[Sehirler] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SehirAdi] nvarchar(50)  NULL
);
GO

-- Creating table 'Sektorler'
CREATE TABLE [dbo].[Sektorler] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SektorAdi] nvarchar(50)  NULL
);
GO

-- Creating table 'Cagrilar'
CREATE TABLE [dbo].[Cagrilar] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirmaId] int  NULL,
    [Konu] nvarchar(50)  NULL,
    [Aciklama] varchar(max)  NULL,
    [Tarih] datetime  NULL,
    [Durum] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Adminler'
ALTER TABLE [dbo].[Adminler]
ADD CONSTRAINT [PK_Adminler]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Departmanlar'
ALTER TABLE [dbo].[Departmanlar]
ADD CONSTRAINT [PK_Departmanlar]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Firmalar'
ALTER TABLE [dbo].[Firmalar]
ADD CONSTRAINT [PK_Firmalar]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Gorevler'
ALTER TABLE [dbo].[Gorevler]
ADD CONSTRAINT [PK_Gorevler]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ilceler'
ALTER TABLE [dbo].[Ilceler]
ADD CONSTRAINT [PK_Ilceler]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Personeller'
ALTER TABLE [dbo].[Personeller]
ADD CONSTRAINT [PK_Personeller]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sehirler'
ALTER TABLE [dbo].[Sehirler]
ADD CONSTRAINT [PK_Sehirler]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sektorler'
ALTER TABLE [dbo].[Sektorler]
ADD CONSTRAINT [PK_Sektorler]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cagrilar'
ALTER TABLE [dbo].[Cagrilar]
ADD CONSTRAINT [PK_Cagrilar]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DepartmanId] in table 'Personeller'
ALTER TABLE [dbo].[Personeller]
ADD CONSTRAINT [FK_Personeller_Departmanlar]
    FOREIGN KEY ([DepartmanId])
    REFERENCES [dbo].[Departmanlar]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Personeller_Departmanlar'
CREATE INDEX [IX_FK_Personeller_Departmanlar]
ON [dbo].[Personeller]
    ([DepartmanId]);
GO

-- Creating foreign key on [IlceId] in table 'Firmalar'
ALTER TABLE [dbo].[Firmalar]
ADD CONSTRAINT [FK_Firmalar_Ilceler]
    FOREIGN KEY ([IlceId])
    REFERENCES [dbo].[Ilceler]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Firmalar_Ilceler'
CREATE INDEX [IX_FK_Firmalar_Ilceler]
ON [dbo].[Firmalar]
    ([IlceId]);
GO

-- Creating foreign key on [SehirId] in table 'Firmalar'
ALTER TABLE [dbo].[Firmalar]
ADD CONSTRAINT [FK_Firmalar_Sehirler]
    FOREIGN KEY ([SehirId])
    REFERENCES [dbo].[Sehirler]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Firmalar_Sehirler'
CREATE INDEX [IX_FK_Firmalar_Sehirler]
ON [dbo].[Firmalar]
    ([SehirId]);
GO

-- Creating foreign key on [SektorId] in table 'Firmalar'
ALTER TABLE [dbo].[Firmalar]
ADD CONSTRAINT [FK_Firmalar_Sektorler]
    FOREIGN KEY ([SektorId])
    REFERENCES [dbo].[Sektorler]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Firmalar_Sektorler'
CREATE INDEX [IX_FK_Firmalar_Sektorler]
ON [dbo].[Firmalar]
    ([SektorId]);
GO

-- Creating foreign key on [GorevAlanId] in table 'Gorevler'
ALTER TABLE [dbo].[Gorevler]
ADD CONSTRAINT [FK_GorevDetaylar_Personeller]
    FOREIGN KEY ([GorevAlanId])
    REFERENCES [dbo].[Personeller]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GorevDetaylar_Personeller'
CREATE INDEX [IX_FK_GorevDetaylar_Personeller]
ON [dbo].[Gorevler]
    ([GorevAlanId]);
GO

-- Creating foreign key on [GorevVerenId] in table 'Gorevler'
ALTER TABLE [dbo].[Gorevler]
ADD CONSTRAINT [FK_GorevDetaylar_Personeller1]
    FOREIGN KEY ([GorevVerenId])
    REFERENCES [dbo].[Personeller]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GorevDetaylar_Personeller1'
CREATE INDEX [IX_FK_GorevDetaylar_Personeller1]
ON [dbo].[Gorevler]
    ([GorevVerenId]);
GO

-- Creating foreign key on [SehirId] in table 'Ilceler'
ALTER TABLE [dbo].[Ilceler]
ADD CONSTRAINT [FK_Ilceler_Sehirler]
    FOREIGN KEY ([SehirId])
    REFERENCES [dbo].[Sehirler]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ilceler_Sehirler'
CREATE INDEX [IX_FK_Ilceler_Sehirler]
ON [dbo].[Ilceler]
    ([SehirId]);
GO

-- Creating foreign key on [FirmaId] in table 'Cagrilar'
ALTER TABLE [dbo].[Cagrilar]
ADD CONSTRAINT [FK_Cagrilar_Firmalar]
    FOREIGN KEY ([FirmaId])
    REFERENCES [dbo].[Firmalar]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Cagrilar_Firmalar'
CREATE INDEX [IX_FK_Cagrilar_Firmalar]
ON [dbo].[Cagrilar]
    ([FirmaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------