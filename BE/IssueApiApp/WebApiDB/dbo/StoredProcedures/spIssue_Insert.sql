CREATE PROCEDURE [dbo].[spIssue_Insert]
	@Header nvarchar(50),
	@Comment nvarchar(50),
	@Status bit,
	@Email nvarchar(50),
	@Datetime smalldatetime
AS
begin
	insert into dbo.[UserIssues] (Header, Comment, Status, Email, Datetime)
	values (@Header, @Comment, @Status, @Email, @Datetime);
end
