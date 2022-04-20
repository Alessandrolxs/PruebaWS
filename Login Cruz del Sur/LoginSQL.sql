
CREATE PROCEDURE spLogin 'guille123', 'gege'
@usuario varchar(50),
@pass varchar(50)
AS
BEGIN
	

	SELECT top 1 COUNT(*) FROM usuarios 
	WHERE usuarios.usuario = @usuario and usuarios.pass = @pass
END
GO
