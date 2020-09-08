CREATE TABLE [dbo].[Ingredientes] (
    [Id] uniqueidentifier,
    [Nome] varchar(100) NOT NULL DEFAULT '',
    [Valor] decimal(15,2) NOT NULL,
	[Ativo] bit NOT NULL,
	[DataCadastro] datetime NOT NULL,
    [DataUltimaAlteracao] DATETIME NULL, 
    CONSTRAINT [PK_Ingrediente] PRIMARY KEY ([Id])
);
GO
