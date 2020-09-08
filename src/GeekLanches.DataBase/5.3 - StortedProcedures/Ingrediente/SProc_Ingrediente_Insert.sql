CREATE PROCEDURE [dbo].SProc_Ingrediente_Insert
(
    @Id            uniqueidentifier
    ,@Nome         varchar(100) 
    ,@Valor        decimal(15,2)
    ,@Ativo        bit 
    ,@DataCadastro datetime 
)
As

INSERT INTO [dbo].[Ingredientes]
           (
           [Id]          
           ,[Nome]        
           ,[Valor]       
           ,[Ativo]       
           ,[DataCadastro]
           )
     VALUES
           (
           @Id           
           ,@Nome        
           ,@Valor       
           ,@Ativo       
           ,@DataCadastro
           )