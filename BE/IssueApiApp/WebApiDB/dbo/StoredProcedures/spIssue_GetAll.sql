CREATE PROCEDURE [dbo].[spIssue_GetAll]
AS
begin
	select Id, Header, Comment, Status, Email, Datetime
	from dbo.UserIssues;
end