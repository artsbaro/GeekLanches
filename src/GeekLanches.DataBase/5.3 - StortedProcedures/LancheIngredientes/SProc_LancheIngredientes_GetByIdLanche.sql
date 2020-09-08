CREATE PROCEDURE [dbo].SProc_LancheIngredientes_GetByIdLanche
(
	@IdLanche uniqueidentifier
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
WHERE		[IdLanche] = @IdLanche
