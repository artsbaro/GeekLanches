CREATE PROCEDURE [dbo].SProc_Ingrediente_GetById
(
	@Id uniqueidentifier
)
As

	SELECT	[Id]
			,[Nome]
			,[Valor]
			,[Ativo]
			,[DataCadastro]
			,[DataCadastro]
	FROM	[dbo].[Ingredientes] (nolock)
	WHERE	[Id] = @Id