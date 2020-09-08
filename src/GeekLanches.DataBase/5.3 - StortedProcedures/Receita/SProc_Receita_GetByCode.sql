CREATE PROCEDURE [dbo].[SProc_Receita_GetByCode]  
(  
 @Codigo uniqueidentifier  
)  
As  
  
 SELECT 
        R.[Id] 
        ,R.Codigo
        ,R.[Titulo] 
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
 Where  R.Codigo = @Codigo
 AND    R.Ativo = 1
 AND    R.Excluido = 0
 
