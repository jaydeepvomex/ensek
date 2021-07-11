CREATE TABLE [dbo].[MeterReadings]
(
    [MeterReadingId] INT NOT NULL IDENTITY, 
	[AccountId] INT NOT NULL , 
    [MeterReadingDateTime] DATETIME NOT NULL, 
    [MeterReadValue] INT NOT NULL, 
    CONSTRAINT [PK_MeterReadings] PRIMARY KEY ([MeterReadingId])
)
