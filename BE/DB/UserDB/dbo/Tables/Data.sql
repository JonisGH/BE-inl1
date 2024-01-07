CREATE TABLE [dbo].[Data]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY,
    [email] NVARCHAR(50) NOT NULL , 
    [msg] NVARCHAR(50) NULL, 
    [datetime] SMALLDATETIME NOT NULL, 
    [status] BIT NOT NULL DEFAULT 0, 
)
