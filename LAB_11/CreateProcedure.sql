CREATE PROCEDURE GetLiteratureName
@literatureID int,
@literatureName varchar(40) output
AS
	SELECT @literatureName = LiteratureName FROM Literature
	WHERE Id = @literatureID