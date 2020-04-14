CREATE TABLE [dbo].[Diagnostics]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [data] VARCHAR(255) NULL, 
    [message] VARCHAR(255) NULL, 
    [success] BIT NULL
)
