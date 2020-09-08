CREATE PROCEDURE [dbo].[SProc_Receita_GetByFilter]
(
    @Titulo varchar(100),
    @Descricao varchar(100),
    @ModoPreparo varchar(100),
    @Ingredientes varchar(100),
    @TituloCategoria varchar(100)
)
As

 SELECT 
        R.[Id] 
        ,R.[Titulo] 
        ,R.Codigo
        ,R.[Descricao] 
        ,R.[ModoPreparo]
        ,R.[Ingredientes]
        ,R.[CaminhoImagem]
        ,R.[NomeArquivo]
        ,R.[CategoriaId]
        ,C.Codigo as  CategoriaCodigo
        ,C.[Titulo] as CategoriaTitulo
	    ,R.[Ativo] 
        ,R.Likes
        ,R.DisLikes
	    ,R.[DataCadastro] 
        ,R.[DataUltimaAlteracao] 
 FROM   dbo.tblReceitas R (nolock) 
 Join   dbo.tblCategorias C (nolock) On C.Id = R.CategoriaId
 WHERE  R.Ativo = 1
 AND    R.Excluido = 0
AND (@Titulo IS NULL OR R.Titulo like '%'+ @Titulo + '%' )
AND (@Descricao IS NULL OR R.Descricao like '%'+ @Descricao + '%' )
AND (@ModoPreparo IS NULL OR R.ModoPreparo like '%'+ @ModoPreparo + '%' )
AND (@Ingredientes IS NULL OR R.Ingredientes like '%'+ @Ingredientes + '%' )
AND (@TituloCategoria IS NULL OR C.[Titulo] like '%'+ @TituloCategoria + '%' )