if not exists (select 1 from dbo.UserIssues)
begin
	insert into dbo.UserIssues (Header, Comment, Email, Datetime)
		values ('Your issue here','Your comment here', 
		'your@email.here', '2020-05-10 00:00:00');
end