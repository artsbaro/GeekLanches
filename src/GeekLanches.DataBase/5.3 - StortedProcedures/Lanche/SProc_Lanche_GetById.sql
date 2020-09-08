CREATE PROCEDURE [dbo].SProc_Lanche_GetById
(
	@Id uniqueidentifier
)
As

	SELECT	[Id]
			,[Nome]
			,[Ativo]
			,[DataCadastro]
			,[DataUltimaAlteracao]
	FROM	[dbo].[Lanches] (nolock)
	WHERE	[Id] = @Id