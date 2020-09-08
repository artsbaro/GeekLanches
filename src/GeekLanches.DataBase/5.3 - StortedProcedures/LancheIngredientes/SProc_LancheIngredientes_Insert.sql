CREATE PROCEDURE [dbo].SProc_LancheIngredientes_Insert
(
     @Id                    uniqueidentifier
    ,@IdLanche              uniqueidentifier
    ,@IdIngrediente         uniqueidentifier
    ,@QtdeIngredientes      tinyint
	,@Ativo                 bit 
	,@DataCadastro          datetime 
)
As

INSERT INTO [dbo].[LancheIngredientes]
           (
           [Id]          
           ,[IdLanche]            
           ,[IdIngrediente]      
           ,[QtdeIngredientes]   
           ,[Ativo]              
           ,[DataUltimaAlteracao]
           )
     VALUES
           (
            @Id                  
            ,@IdLanche           
            ,@IdIngrediente      
            ,@QtdeIngredientes   
	        ,@Ativo               
           ,@DataCadastro
           )