CREATE TABLE [dbo].[Lanches] (
    [Id] uniqueidentifier,
    [Nome] varchar(100) NOT NULL DEFAULT '',
	[Ativo] bit NOT NULL,
	[DataCadastro] datetime NOT NULL,
    [DataUltimaAlteracao] DATETIME NULL, 
    CONSTRAINT [PK_Lanche] PRIMARY KEY ([Id])
);
GO
