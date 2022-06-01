USE [balta]
GO

CREATE OR ALTER VIEW vwCareers AS
    SELECT 
        [Career].[Id],
        [Career].[Title],
        [Career].[Url],
        --(SELECT COUNT([CareerId]) FROM [CareerItem] WHERE [CareerId] = [Id]) AS [Courses] não recomendado
        COUNT([Id]) AS [Courses]
    FROM
        [Career]
        INNER JOIN [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id]
    GROUP BY
        [Career].[Id],
        [Career].[Title],
        [Career].[Url]