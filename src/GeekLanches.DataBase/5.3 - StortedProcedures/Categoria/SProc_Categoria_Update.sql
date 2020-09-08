CREATE PROCEDURE [dbo].SProc_Categoria_Update
(
   @Id smallint ,
	@Titulo varchar(128),
	@Descricao varchar(512),
	@Codigo uniqueidentifier ,
	@Ativo bit ,
	@DataUltimaAlteracao datetime
)
As

UPDATE tblCategorias SET
   	Titulo = @Titulo,
	Descricao = @Descricao,
	Codigo = @Codigo,
	Ativo = @Ativo,
	DataUltimaAlteracao = @DataUltimaAlteracao
 WHERE [Id] = @Id