CREATE TABLE [dbo].[LancheIngredientes] (
    [Id] uniqueidentifier,
    [IdLanche] uniqueidentifier NOT NULL,
    [IdIngrediente] uniqueidentifier NOT NULL,
    [QtdeIngredientes] tinyint NOT NULL,
	[Ativo] bit NOT NULL,
	[DataCadastro] datetime NOT NULL,
    [DataUltimaAlteracao] DATETIME NULL, 
    CONSTRAINT [PK_LancheIngredientes] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_LancheIngredientes_Lanche] FOREIGN KEY ([IdLanche]) REFERENCES [dbo].[Lanches]([Id]),
    CONSTRAINT [FK_LancheIngredientes_Ingrediente] FOREIGN KEY ([IdIngrediente]) REFERENCES [dbo].[Ingredientes]([Id])
);
GO

CREATE NONCLUSTERED INDEX [IX_LancheIngredientes_IdLanche] ON [dbo].[LancheIngredientes]
(
	[IdLanche] ASC
)
INCLUDE([Id],[IdIngrediente],[QtdeIngredientes],[Ativo],[DataCadastro],[DataUltimaAlteracao]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

