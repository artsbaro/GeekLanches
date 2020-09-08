CREATE PROCEDURE [dbo].SProc_Categoria_Insert
(
    @Codigo            uniqueidentifier 
	,@Titulo              varchar(128)
    ,@Descricao           varchar(512)
    ,@Ativo				bit
    ,@DataCadastro		datetime
)
As

INSERT INTO [dbo].[tblCategorias]
           (
           [Codigo]
           ,[Titulo]
		   ,[Descricao]         
           ,[Ativo]
           ,[DataCadastro])
     VALUES
           (
           @Codigo
           ,@Titulo
           ,@Descricao
			,@Ativo			
			,@DataCadastro)

            
