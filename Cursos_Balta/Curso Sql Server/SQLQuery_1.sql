--CREATE DATABASE [Curso]
/*USE [Curso]

CREATE TABLE [Aluno](
    [Id] INT,
    [Nome] NVARCHAR(80),
    [Nascimento] DATETIME,
    [Active] BIT
)
GO*/ --toda vez que coloca um go ele vai fazendo e inserindo no banco

--Alterar tabela (Complicado usar se tiver uma tabela já muito populada)
--adicionando campo
ALTER TABLE [Aluno]
    ADD [Document] NVARCHAR(11)

--removendo campo (pode dar muito problema)
ALTER TABLE [Aluno]
    DROP COLUMN [Document]
--Alter tipo da coluna
ALTER TABLE [Aluno]
    ALTER COLUMN [Document] CHAR(11)

--constraints - not null -> Limite(tem que definir um limite, uma regra)
DROP TABLE [Aluno]
--sempre que for usar sem not null lembra de colocar um defaul na frente. Default não pode ser utilizado quando for alterar tabela e entre (valor padrão)
--No caso 0 significa inativo
CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Nascimento] DATETIME NULL,
    [Active] BIT DEFAULT(0),
)
GO

--Se tiver elementos nessa coluna, esse código vai falhar pq antes suportava nulo e agora não tem como converter aquela coluna para um não nulo
--sempre que for trocar para um not null usa o default na frente
ALTER TABLE [Aluno]
    ALTER COLUMN [Active] BIT NOT NULL

--Constraints - Unique -> define que vão ter valores únicos. Sempre lembra de colocar os campos únicos na criação do banco
DROP TABLE [Aluno]
CREATE TABLE [Aluno](
    [Id] INT NOT NULL UNIQUE,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Nascimento] DATETIME NULL,
    [Active] BIT DEFAULT(0),
)
GO

--Primary key -> chave primária
-- como o id geralmente é a chave primária, não precisa colocar o Unique
-- Pode ter mais de uma chave primária
DROP TABLE [Aluno]
CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Nascimento] DATETIME NULL,
    [Active] BIT DEFAULT(0),

    PRIMARY KEY([Id], [Email])
)
GO

--colocar chave primaria depois
ALTER TABLE [Aluno]
    ADD PRIMARY KEY([id])

--dropar chave primária
ALTER TABLE [Aluno]
    DROP CONSTRAINT [PK_Aluno_] --nome padrão

--colocar nome para chave primária
DROP TABLE [Aluno]
CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL,
    [Nascimento] DATETIME NULL,
    [Active] BIT DEFAULT(0),

    CONSTRAINT [PK_Aluno] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Aluno_Email] UNIQUE([Email])
)
GO

--chave estrangeira
DROP TABLE [Aluno]
CREATE TABLE [Aluno] (
    [Id] INT NOT NULL, 
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL,
    [Nascimento] DATETIME NULL,
    [Active] BIT NOT NULL DEFAULT(0),

    CONSTRAINT [PK_Aluno] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Aluno_Email] UNIQUE([Email]),
)
GO

CREATE INDEX [IX_Aluno_Email] ON [Aluno]([Email])
DROP INDEX [IX_Aluno_Email] ON [Aluno]

SELECT NEWID()

DROP TABLE [Categoria]
CREATE TABLE [Categoria] (
    [Id] INT NOT NULL IDENTITY(1, 1), 
    [Nome] NVARCHAR(80) NOT NULL,

    CONSTRAINT [PK_Categoria] PRIMARY KEY([Id])
)
GO

DROP TABLE [Curso]
CREATE TABLE [Curso] (
    [Id] INT NOT NULL IDENTITY(1, 1), 
    [Nome] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL,

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([CategoriaId])
        REFERENCES [Categoria]([Id])
)
GO



DROP TABLE [ProgressoCurso]
CREATE TABLE [ProgressoCurso] (
    [AlunoId] INT NOT NULL, 
    [CursoId] INT NOT NULL, 
    [Progresso] INT NOT NULL,
    [UltimaAtualizacao] DATETIME NOT NULL DEFAULT(GETDATE()),
    
    CONSTRAINT PK_ProgressoCurso PRIMARY KEY([AlunoId], [CursoId]),
)
GO

--iserir valores
INSERT INTO [Categoria] ([Nome]) VALUES('Backend')
INSERT INTO [Categoria] ([Nome]) VALUES('frontend')
INSERT INTO [Categoria] ([Nome]) VALUES('mobile')
INSERT INTO [Curso] ([Nome], [CategoriaId]) VALUES ('Fundamentos de c#', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Fundamentos OOP', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Angular', 2)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES('Flutter', 3)

--SELECT

Select distinct Top 100
    [id], [Nome] --melhor que * 
from 
    [Curso]
-- WHERE
--     [CategoriaId] = 1
ORDER BY --ordenar
    [Nome] --ASC ou DESC

--UPDATE

SELECT * FROM [Categoria]

-- UPDATE 
--     [Categoria] 
-- SET 
--     [Nome] = ''
-- WHERE

-- se rodar não vai ser feito nada por no final tô desfazendo as alterações é só pra verificar as linahs afetadas
BEGIN TRANSACTION --começa a transação
    UPDATE
        [Categoria]
    SET
        [Nome] = 'Backend'
    WHERE
        [Id] = 1
ROLLBACK --desfaz as alterações tb tem o COMMIT pra fazer as alterações

--DELETE
BEGIN TRANSACTION --começa a transação
    DELETE
        [Categoria]
    WHERE
        [Id] = 1
ROLLBACK --desfaz as alterações tb tem o COMMIT pra fazer as alterações

-- MIN, MAX, COUNT

SELECT TOP 100
    --MAX([Id])
    --MIN([Id])
    COUNT([Id])
    --AVG([Id]) média
    --SUM([Id]) soma dos valores. mais sentido usar nos preços
FROM
    [Curso]

--LIKE

SELECT top 100
    *
FROM
    [Curso]
WHERE
    --[Nome] = 'Fundamentos' -- não funciona
    [Nome] LIKE '%Fundamentos%' --contém '%' começa por, ' edewedjewi%' termina com, '%ehfbe%' contém

-- IN e Betwenn
--IN se o valor está presente na lista que vai passar
--BETWEEN entre
SELECT top 100
    *
FROM
    [Curso]
WHERE
    [Id] IN (1,2)
    -- [Id] BETWEEN 2 AND 3
    -- [Id] BETWEEN '2020-03-01' AND '2020-03-31' -- se fosse datetime
    -- [Id] BETWEEN '2020-03-01 00:00:00' AND '2020-03-31 23:59:00' -- se fosse datetime com hora

-- Alias mudar os nomes quando for juntar tabelas, pra não ter conflitos

SELECT top 100
    [Id] AS [Codigo],
    [Nome]
FROM
    [Curso]

SELECT top 100
    COUNT([Id]) AS [Total] -- fica mais elegante
FROM
    [Curso]

--Joins
-- INNER JOIN -> quero tudo de curso com categoria por exemplo mas tem que ter uma condição, geralmente relaciona com as chaves estrangeiras ou primárias
-- da pra acumular joins
SELECT top 100
    [Curso].Id AS [Curso_id],
    [Curso].Nome AS [Curso_nome],
    [Categoria].Id AS [Categoria_id],
    [Categoria].[Nome] AS [Categoria_nome]
FROM
    [Curso]
    INNER JOIN [Categoria] 
        ON [Curso].CategoriaId = [Categoria].Id

--LEFT JOIN -> pega todos os itens da primeira tabela
--RIGHT JOIN -> Pega todos os itens da segunda tabela
-- FULL OUTER JOIN -> pega tudo que ta em 1 e tudo que ta em outro

--UNION -> não necessariamente estão relacionadas
    SELECT top 100
        [Id], [Nome]
    FROM
        [Curso]

UNION ALL --vai evitar dado duplicado

    SELECT top 100
        [Id], [Nome]
    FROM
        [Categoria]

--GROUP BY
--quantos grupos tem em cada categoria
--usou o count usa o group by. saber quantos cursos tem uma categoria tal
SELECT top 100
        [Categoria].[Id],
        [Categoria].[Nome],
        COUNT([Curso].[CategoriaId]) AS [Cursos]
FROM
    [Categoria]
    INNER JOIN [Curso] ON [Curso].[CategoriaId] = [Categoria].[Id]
GROUP BY
    [Categoria].[Id],
    [Categoria].[Nome],
    [Curso].[CategoriaId]



--HAVING -> coontendo. agrupado por tal contendo
SELECT top 100
        [Categoria].[Id],
        [Categoria].[Nome],
        COUNT([Curso].[CategoriaId]) AS [Cursos]
FROM
    [Categoria]
    INNER JOIN [Curso] ON [Curso].[CategoriaId] = [Categoria].[Id]
GROUP BY
    [Categoria].[Id],
    [Categoria].[Nome],
    [Curso].[CategoriaId]
HAVING
    COUNT([Curso].[CategoriaId]) = 2



--VIEW -> é uma foto de um select
-- CREATE OR ALTER VIEW vwContagemCursosPorCategoria AS         -- or alter, se já existe vai sobrescrever
--     SELECT top 100
           
--             [Categoria].[Nome],
--             COUNT([Curso].[CategoriaId]) AS [Cursos],
--              [Categoria].[Id]
--     FROM
--         [Categoria]
--         INNER JOIN [Curso] ON [Curso].[CategoriaId] = [Categoria].[Id]
--     GROUP BY
--         [Categoria].[Id],
--         [Categoria].[Nome],
--         [Curso].[CategoriaId]
--     HAVING
--         COUNT([Curso].[CategoriaId]) > 1

--vantagem é que pode usar o where agora

-- SELECT * FROM vwContagemCursosPorCategoria
-- WHERE Id = 1

--storage procedures
--procedure é um script sql não deixar regra de negócio aqui
-- Create OR ALTER PROCEDURE [splitCourse] AS
--     SELECT * FROM [Curso]

-- DROP PROCEDURE [splitCourse]

-- EXEC [splitCourse] 

--variáveis

CREATE OR ALTER PROCEDURE [splitcurso]
    @Category NVARCHAR(60)
AS
    DECLARE @CategoryId INT
    SET @CategoryId = (SELECT TOP 100 [Id] FROM [Categoria] WHERE [Nome] = @Category)

    SELECT * FROM [Curso] WHERE [CategoriaId] = @CategoryId

EXEC [splitcurso] 'Data'
