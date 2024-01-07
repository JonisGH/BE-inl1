CREATE PROCEDURE [dbo].[delete_Post]
	@Id int
AS
begin
	delete
	from dbo.[Data]
	where id = @Id
end

