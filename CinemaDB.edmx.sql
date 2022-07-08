
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/08/2022 04:24:28
-- Generated from EDMX file: C:\Users\tomas\source\repos\GereCinema\CinemaDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CinemaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_ClienteVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionarioVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_FuncionarioVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemVenda_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemVenda] DROP CONSTRAINT [FK_ItemVenda_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemVenda_Venda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemVenda] DROP CONSTRAINT [FK_ItemVenda_Venda];
GO
IF OBJECT_ID(N'[dbo].[FK_SalaSessao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sessoes] DROP CONSTRAINT [FK_SalaSessao];
GO
IF OBJECT_ID(N'[dbo].[FK_FilmeSessao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sessoes] DROP CONSTRAINT [FK_FilmeSessao];
GO
IF OBJECT_ID(N'[dbo].[FK_SessaoLugar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Lugares] DROP CONSTRAINT [FK_SessaoLugar];
GO
IF OBJECT_ID(N'[dbo].[FK_SessaoBilhete]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bilhetes] DROP CONSTRAINT [FK_SessaoBilhete];
GO
IF OBJECT_ID(N'[dbo].[FK_BilheteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bilhetes] DROP CONSTRAINT [FK_BilheteVenda];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Funcionarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Funcionarios];
GO
IF OBJECT_ID(N'[dbo].[Vendas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vendas];
GO
IF OBJECT_ID(N'[dbo].[Items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items];
GO
IF OBJECT_ID(N'[dbo].[Salas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Salas];
GO
IF OBJECT_ID(N'[dbo].[Filmes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Filmes];
GO
IF OBJECT_ID(N'[dbo].[Sessoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sessoes];
GO
IF OBJECT_ID(N'[dbo].[Lugares]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lugares];
GO
IF OBJECT_ID(N'[dbo].[Bilhetes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bilhetes];
GO
IF OBJECT_ID(N'[dbo].[ItemVenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemVenda];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] nvarchar(max)  NOT NULL,
    [Idade] int  NOT NULL
);
GO

-- Creating table 'Funcionarios'
CREATE TABLE [dbo].[Funcionarios] (
    [IdFuncionario] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CodFuncionario] nvarchar(max)  NOT NULL,
    [Salario] float  NOT NULL
);
GO

-- Creating table 'Vendas'
CREATE TABLE [dbo].[Vendas] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [FuncionarioIdFuncionario] int  NOT NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [IdItem] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Preco] float  NOT NULL
);
GO

-- Creating table 'Salas'
CREATE TABLE [dbo].[Salas] (
    [IdSala] int IDENTITY(1,1) NOT NULL,
    [NrSala] int  NOT NULL,
    [Comprimento] int  NOT NULL,
    [Largura] int  NOT NULL
);
GO

-- Creating table 'Filmes'
CREATE TABLE [dbo].[Filmes] (
    [IdFilme] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [LimIdade] int  NOT NULL,
    [Duracao] int  NOT NULL,
    [Preco] float  NOT NULL
);
GO

-- Creating table 'Sessoes'
CREATE TABLE [dbo].[Sessoes] (
    [IdSessao] int IDENTITY(1,1) NOT NULL,
    [DataInicio] datetime  NOT NULL,
    [SalaIdSala] int  NOT NULL,
    [FilmeIdFilme] int  NOT NULL
);
GO

-- Creating table 'Lugares'
CREATE TABLE [dbo].[Lugares] (
    [IdLugar] int IDENTITY(1,1) NOT NULL,
    [X] int  NOT NULL,
    [Y] int  NOT NULL,
    [SessaoIdSessao] int  NOT NULL,
    [Ocupado] bit  NOT NULL
);
GO

-- Creating table 'Bilhetes'
CREATE TABLE [dbo].[Bilhetes] (
    [IdBilhete] int IDENTITY(1,1) NOT NULL,
    [X] int  NOT NULL,
    [Y] int  NOT NULL,
    [SessaoIdSessao] int  NOT NULL,
    [VendaIdVenda] int  NOT NULL
);
GO

-- Creating table 'ItemVenda'
CREATE TABLE [dbo].[ItemVenda] (
    [Items_IdItem] int  NOT NULL,
    [Vendas_IdVenda] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCliente] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdFuncionario] in table 'Funcionarios'
ALTER TABLE [dbo].[Funcionarios]
ADD CONSTRAINT [PK_Funcionarios]
    PRIMARY KEY CLUSTERED ([IdFuncionario] ASC);
GO

-- Creating primary key on [IdVenda] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [PK_Vendas]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdItem] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([IdItem] ASC);
GO

-- Creating primary key on [IdSala] in table 'Salas'
ALTER TABLE [dbo].[Salas]
ADD CONSTRAINT [PK_Salas]
    PRIMARY KEY CLUSTERED ([IdSala] ASC);
GO

-- Creating primary key on [IdFilme] in table 'Filmes'
ALTER TABLE [dbo].[Filmes]
ADD CONSTRAINT [PK_Filmes]
    PRIMARY KEY CLUSTERED ([IdFilme] ASC);
GO

-- Creating primary key on [IdSessao] in table 'Sessoes'
ALTER TABLE [dbo].[Sessoes]
ADD CONSTRAINT [PK_Sessoes]
    PRIMARY KEY CLUSTERED ([IdSessao] ASC);
GO

-- Creating primary key on [IdLugar] in table 'Lugares'
ALTER TABLE [dbo].[Lugares]
ADD CONSTRAINT [PK_Lugares]
    PRIMARY KEY CLUSTERED ([IdLugar] ASC);
GO

-- Creating primary key on [IdBilhete] in table 'Bilhetes'
ALTER TABLE [dbo].[Bilhetes]
ADD CONSTRAINT [PK_Bilhetes]
    PRIMARY KEY CLUSTERED ([IdBilhete] ASC);
GO

-- Creating primary key on [Items_IdItem], [Vendas_IdVenda] in table 'ItemVenda'
ALTER TABLE [dbo].[ItemVenda]
ADD CONSTRAINT [PK_ItemVenda]
    PRIMARY KEY CLUSTERED ([Items_IdItem], [Vendas_IdVenda] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteIdCliente] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[Vendas]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [FuncionarioIdFuncionario] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_FuncionarioVenda]
    FOREIGN KEY ([FuncionarioIdFuncionario])
    REFERENCES [dbo].[Funcionarios]
        ([IdFuncionario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionarioVenda'
CREATE INDEX [IX_FK_FuncionarioVenda]
ON [dbo].[Vendas]
    ([FuncionarioIdFuncionario]);
GO

-- Creating foreign key on [Items_IdItem] in table 'ItemVenda'
ALTER TABLE [dbo].[ItemVenda]
ADD CONSTRAINT [FK_ItemVenda_Item]
    FOREIGN KEY ([Items_IdItem])
    REFERENCES [dbo].[Items]
        ([IdItem])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Vendas_IdVenda] in table 'ItemVenda'
ALTER TABLE [dbo].[ItemVenda]
ADD CONSTRAINT [FK_ItemVenda_Venda]
    FOREIGN KEY ([Vendas_IdVenda])
    REFERENCES [dbo].[Vendas]
        ([IdVenda])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemVenda_Venda'
CREATE INDEX [IX_FK_ItemVenda_Venda]
ON [dbo].[ItemVenda]
    ([Vendas_IdVenda]);
GO

-- Creating foreign key on [SalaIdSala] in table 'Sessoes'
ALTER TABLE [dbo].[Sessoes]
ADD CONSTRAINT [FK_SalaSessao]
    FOREIGN KEY ([SalaIdSala])
    REFERENCES [dbo].[Salas]
        ([IdSala])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalaSessao'
CREATE INDEX [IX_FK_SalaSessao]
ON [dbo].[Sessoes]
    ([SalaIdSala]);
GO

-- Creating foreign key on [FilmeIdFilme] in table 'Sessoes'
ALTER TABLE [dbo].[Sessoes]
ADD CONSTRAINT [FK_FilmeSessao]
    FOREIGN KEY ([FilmeIdFilme])
    REFERENCES [dbo].[Filmes]
        ([IdFilme])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilmeSessao'
CREATE INDEX [IX_FK_FilmeSessao]
ON [dbo].[Sessoes]
    ([FilmeIdFilme]);
GO

-- Creating foreign key on [SessaoIdSessao] in table 'Lugares'
ALTER TABLE [dbo].[Lugares]
ADD CONSTRAINT [FK_SessaoLugar]
    FOREIGN KEY ([SessaoIdSessao])
    REFERENCES [dbo].[Sessoes]
        ([IdSessao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SessaoLugar'
CREATE INDEX [IX_FK_SessaoLugar]
ON [dbo].[Lugares]
    ([SessaoIdSessao]);
GO

-- Creating foreign key on [SessaoIdSessao] in table 'Bilhetes'
ALTER TABLE [dbo].[Bilhetes]
ADD CONSTRAINT [FK_SessaoBilhete]
    FOREIGN KEY ([SessaoIdSessao])
    REFERENCES [dbo].[Sessoes]
        ([IdSessao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SessaoBilhete'
CREATE INDEX [IX_FK_SessaoBilhete]
ON [dbo].[Bilhetes]
    ([SessaoIdSessao]);
GO

-- Creating foreign key on [VendaIdVenda] in table 'Bilhetes'
ALTER TABLE [dbo].[Bilhetes]
ADD CONSTRAINT [FK_BilheteVenda]
    FOREIGN KEY ([VendaIdVenda])
    REFERENCES [dbo].[Vendas]
        ([IdVenda])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BilheteVenda'
CREATE INDEX [IX_FK_BilheteVenda]
ON [dbo].[Bilhetes]
    ([VendaIdVenda]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------