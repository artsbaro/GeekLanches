CREATE PROCEDURE [dbo].SProc_Receita_Update
(
    @Id int,
    @Codigo uniqueidentifier,
    @Titulo varchar(150) ,
    @Descricao varchar(256),
    @ModoPreparo varchar(MAX),
    @Ingredientes varchar(MAX),
    @CaminhoImagem varchar(256),
    @NomeArquivo varchar(100),
    @CategoriaId smallint,
	@Ativo bit ,
    @DataUltimaAlteracao DATETIME 
)
As


UPDATE tblReceitas   SET 
       [Codigo] =               @Codigo
      ,[Titulo]  =              @Titulo
      ,[Descricao] =            @Descricao
      ,[ModoPreparo] =          @ModoPreparo
      ,[Ingredientes] =         @Ingredientes
      ,[CaminhoImagem] =        @CaminhoImagem
      ,[NomeArquivo] =          @NomeArquivo
      ,[CategoriaId] =          @CategoriaId
      ,[Ativo] =				@Ativo
      ,[DataUltimaAlteracao] =	@DataUltimaAlteracao
 WHERE Id = @Id
