CREATE PROCEDURE [dbo].SProc_Categoria_GetByFilter
(
    @Titulo varchar(100),
    @Descricao varchar(100)
)
As


	SELECT	[Id]
			,[Codigo]
			,[Titulo]
			,[Descricao]
			,[Ativo]
			,[DataCadastro]
	FROM	[dbo].[tblCategorias] (nolock)
	WHERE	[Excluido] = 0
	AND		[Ativo] = 1
	AND (@Titulo IS NULL OR Titulo like '%'+ @Titulo + '%' )
	AND (@Descricao IS NULL OR Descricao like '%'+ @Descricao + '%' )