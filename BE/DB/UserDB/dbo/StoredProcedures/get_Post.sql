CREATE PROCEDURE [dbo].[get_Post]
	@Id int
AS
begin
	select id, email, msg, [datetime], [status]
	from dbo.[Data]
	where id = @Id
end

