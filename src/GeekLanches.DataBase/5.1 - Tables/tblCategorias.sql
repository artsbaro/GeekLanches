CREATE TABLE [dbo].[tblCategorias] (
    [Id] smallint identity(1,1) NOT NULL,
	[Codigo] uniqueidentifier NOT NULL,
	[Titulo] varchar(128),
	[Descricao] varchar(512),
	[Ativo] bit NOT NULL,
	[Excluido] bit NOT NULL DEFAULT 0,
	[DataCadastro] datetime NOT NULL,
	[DataUltimaAlteracao] datetime NULL, 
    CONSTRAINT [PK_Categoria] PRIMARY KEY ([Id]),
);

GO

CREATE INDEX [NC_tblCategorias_Codigo] ON [dbo].[tblCategorias] ([Codigo])
