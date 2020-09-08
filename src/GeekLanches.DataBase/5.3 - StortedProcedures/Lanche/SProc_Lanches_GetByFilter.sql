CREATE PROCEDURE [dbo].SProc_Lanches_GetByFilter
(
    @Nome varchar(100)
)
As

SELECT	[Id]
		,[Nome]
		,[Ativo]
		,[DataCadastro]
		,[DataUltimaAlteracao]
FROM	[dbo].[Lanches] (nolock)
WHERE	(@Nome IS NULL OR Nome like '%'+ @Nome + '%' )