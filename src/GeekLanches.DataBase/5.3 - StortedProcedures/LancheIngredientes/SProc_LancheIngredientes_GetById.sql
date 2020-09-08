CREATE PROCEDURE [dbo].SProc_LancheIngredientes_GetById
(
	@Id uniqueidentifier
)
As

	SELECT	    [Id] 
				,[IdLanche] 
				,[IdIngrediente] 
				,[QtdeIngredientes] 
				,[Ativo] 
				,[DataCadastro] 
				,[DataUltimaAlteracao] 
	FROM		[dbo].[LancheIngredientes] (nolock)
	WHERE		[Id] = @Id
