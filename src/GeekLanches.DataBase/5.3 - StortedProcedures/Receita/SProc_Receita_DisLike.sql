CREATE PROCEDURE [dbo].SProc_Receita_DisLike
(
    @Id int
)
As

UPDATE tblReceitas   SET 
       DisLikes =  (DisLikes + 1)
 WHERE Id = @Id
