CREATE PROCEDURE [dbo].[SProc_Receita_GetById]  
(  
 @Id int  
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
 JOIN   dbo.tblCategorias C (nolock) On C.Id = R.CategoriaId
 Where  R.Id = @Id  
 AND    R.Ativo = 1
 AND    R.Excluido = 0
 