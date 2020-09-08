CREATE PROCEDURE [dbo].[SProc_LancheIngredientes_Update]
(
    @Id                     uniqueidentifier
    ,@IdLanche              uniqueidentifier
    ,@IdIngrediente         uniqueidentifier
    ,@QtdeIngredientes      tinyint
	,@Ativo                 bit 
    ,@DataUltimaAlteracao   DATETIME 
)
As

UPDATE      LancheIngredientes SET
            [IdLanche]              = @IdLanche
            ,[IdIngrediente]         = @IdIngrediente
            ,[QtdeIngredientes]      = @QtdeIngredientes
	        ,[Ativo]                 = @Ativo
            ,[DataUltimaAlteracao]   = @DataUltimaAlteracao
 WHERE      [Id]                        = @Id
