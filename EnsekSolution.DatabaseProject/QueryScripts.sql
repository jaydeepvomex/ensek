
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2344, 'Tommy', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2233, 'Barry', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (8766, 'Sally', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2345, 'Jerry', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2346, 'Ollie', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2347, 'Tara', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2348, 'Tammy', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2349, 'Simon', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2350, 'Colin', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2351, 'Gladys', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2352, 'Greg', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2353, 'Tony', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2355, 'Arthur', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (2356, 'Craig', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (6776, 'Laura', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (4534, 'JOSH', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (1234, 'Freya', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (1239, 'Noddy', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (1240, 'Archie', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (1241, 'Lara', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (1242, 'Tim',	'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (1243, 'Graham', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (1244, 'Tony', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (1245, 'Neville',	'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (1246, 'Jo', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (1247, 'Jim', 'Test')
INSERT INTO [EnsekEnergy].[dbo].[CustomerAccounts] VALUES (1248, 'Pam', 'Test')


delete from [EnsekEnergy].[dbo].[MeterReadings]

DBCC CHECKIDENT ('[EnsekEnergy].[dbo].[MeterReadings]', RESEED, 0);
GO