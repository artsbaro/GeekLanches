CREATE PROCEDURE [dbo].Sproc_Categoria_Delete
(
	@Id smallint
)
As
	Update	[dbo].[tblCategorias] SET
				Ativo	 = 0,
				Excluido = 1
	WHERE	[Id] = @Id