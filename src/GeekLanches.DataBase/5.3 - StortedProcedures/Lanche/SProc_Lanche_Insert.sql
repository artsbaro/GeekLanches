CREATE PROCEDURE [dbo].SProc_Lanche_Insert
(
    @Id            uniqueidentifier
    ,@Nome         varchar(100) 
    ,@Ativo        bit 
    ,@DataCadastro datetime 
)
As

INSERT INTO [dbo].[Lanches]
           (
           [Id]          
           ,[Nome]             
           ,[Ativo]       
           ,[DataCadastro]
           )
     VALUES
           (
           @Id           
           ,@Nome            
           ,@Ativo       
           ,@DataCadastro
           )