CREATE PROCEDURE [dbo].SProc_Categoria_GetById
(
	@Id smallint
)
As

	SELECT	[Id]
			,[Titulo]
			,[Descricao]
			,[Codigo]
			,[Ativo]
			,[DataCadastro]
	FROM	[dbo].[tblCategorias] (nolock)
	WHERE	[Id] = @Id
	AND		[Excluido] = 0
	AND		[Ativo] = 1