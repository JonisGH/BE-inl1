CREATE PROCEDURE [dbo].[getAll_Post]
AS
begin
	select id, email, msg, [datetime], [status]
	from dbo.[Data];
end

