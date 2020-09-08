CREATE PROCEDURE [dbo].SProc_Receita_Like
(
    @Id int
)
As


UPDATE tblReceitas   SET 
       Likes =  (Likes + 1)
 WHERE Id = @Id
