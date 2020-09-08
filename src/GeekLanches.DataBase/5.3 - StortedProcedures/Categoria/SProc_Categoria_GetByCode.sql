CREATE PROCEDURE [dbo].SProc_Categoria_GetByCode
(
	@Codigo uniqueidentifier
)
As

	SELECT	[Id]
			,[Titulo]
			,[Descricao]
			,[Codigo]
			,[Ativo]
			,[DataCadastro]
	FROM	[dbo].[tblCategorias] (nolock)
	WHERE	[Codigo] = @Codigo
	AND		[Excluido] = 0
	AND		[Ativo] = 1