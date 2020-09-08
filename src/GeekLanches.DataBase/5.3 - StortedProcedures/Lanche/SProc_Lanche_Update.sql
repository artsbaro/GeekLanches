CREATE PROCEDURE [dbo].[SProc_Lanche_Update]
(
    @Id                     uniqueidentifier
    ,@Nome                  varchar(100) 
    ,@Ativo                 bit 
    ,@DataUltimaAlteracao   datetime 
)
As

UPDATE      Lanches SET
            [Nome]                  = @Nome   
           ,[Ativo]                 = @Ativo
           ,[DataUltimaAlteracao]   = @DataUltimaAlteracao
 WHERE      [Id]                    = @Id