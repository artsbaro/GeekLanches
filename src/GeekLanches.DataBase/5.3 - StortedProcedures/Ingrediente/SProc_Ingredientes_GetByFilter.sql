CREATE PROCEDURE [dbo].SProc_Ingredientes_GetByFilter
(
    @Nome varchar(100)
)
As

SELECT	[Id]
		,[Nome]
		,[Valor]
		,[Ativo]
		,[DataCadastro]
		,[DataCadastro]
FROM	[dbo].[Ingredientes] (nolock)
WHERE	(@Nome IS NULL OR Nome like '%'+ @Nome + '%' )