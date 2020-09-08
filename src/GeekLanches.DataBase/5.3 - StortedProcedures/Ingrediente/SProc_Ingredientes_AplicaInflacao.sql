Create Procedure [dbo].SProc_Ingredientes_AplicaInflacao
( 
	@Percentual decimal,
	@DataUltimaAlteracao Datetime
)
AS

UPDATE Ingredientes SET
           [Valor]				  = [Valor]	* (1 + (@Percentual/100)) 
           ,[DataUltimaAlteracao] = @DataUltimaAlteracao
 