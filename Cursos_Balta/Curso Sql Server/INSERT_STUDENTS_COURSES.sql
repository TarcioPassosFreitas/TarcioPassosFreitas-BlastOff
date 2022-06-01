SELECT * FROM [Course]
SELECT * FROM [Student]
SELECT * FROM [StudentCourse]

USE [balta]
GO

INSERT INTO 
    [Student]
VALUES(
    NEWID(),
    'André Baltieri',
    'hello@balta.io',
    '12345678901',
    '12345678',
    NULL,
    GETDATE()
)
GO

INSERT INTO 
    [StudentCourse]
VALUES(
    '5f5a33f8-4ff3-7e10-cc6e-3fa000000000',
    'c8ac7ba6-58d0-4ca5-8273-78de8da9f88b',
    50,
    0,
    '2020-01-13 12:35:54',
    GETDATE()
)
GO