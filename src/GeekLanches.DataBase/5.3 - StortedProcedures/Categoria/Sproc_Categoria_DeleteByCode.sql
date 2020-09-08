CREATE PROCEDURE [dbo].Sproc_Categoria_DeleteByCode
(
	@Codigo uniqueidentifier
)
As
	Update	[dbo].[tblCategorias] SET
			Ativo	 = 0,
			Excluido = 1
	WHERE	[Codigo] = @Codigo