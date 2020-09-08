CREATE PROCEDURE [dbo].SProc_Receita_DeleteByCode
(
	@Codigo uniqueidentifier
)
AS

	Update	tblReceitas SET
			Ativo = 0,
			Excluido = 1
	Where	Codigo = @Codigo