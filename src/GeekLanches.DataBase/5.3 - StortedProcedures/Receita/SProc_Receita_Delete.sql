CREATE PROCEDURE [dbo].SProc_Receita_Delete
(
	@Id int
)
AS

	Update	tblReceitas SET
			Ativo = 0,
			Excluido = 1
	Where	Id = @Id