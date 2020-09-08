CREATE PROCEDURE [dbo].[SProc_Ingrediente_Update]
(
    @Id                     uniqueidentifier
    ,@Nome                  varchar(100) 
    ,@Valor                 decimal(15,2)
    ,@Ativo                 bit 
    ,@DataUltimaAlteracao   datetime 
)
As

UPDATE Ingredientes SET
           [Nome]       = @Nome   
           ,[Valor]       = @Valor
           ,[Ativo]       = @Ativo
           ,[DataUltimaAlteracao] = @DataUltimaAlteracao
 WHERE      [Id] = @Id