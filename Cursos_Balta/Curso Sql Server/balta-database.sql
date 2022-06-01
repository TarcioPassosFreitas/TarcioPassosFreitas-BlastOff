CREATE DATABASE [balta]
GO

USE[balta]
GO

CREATE TABLE [student](
    [Id] INT IDENTITY(1,1) NOT NULL, --UNIQUEIDENTIFIER -> muito gasto
    [Name] NVARCHAR(120) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL,
    [Document] NVARCHAR(20) NOT NULL,
    [Phone] NVARCHAR(20) NOT NULL,
    [Birthddate] DATETIME NOT NULL,
    [CreateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT [PK_Student] PRIMARY KEY ([Id])
)
GO

CREATE TABLE [Author](
    [Id] INT IDENTITY(1,1) NOT NULL, --UNIQUEIDENTIFIER -> muito gasto
    [Name] NVARCHAR(80) NOT NULL,
    [Title] NVARCHAR(80) NOT NULL,
    [Image] NVARCHAR(1024) NOT NULL,
    [Bio] NVARCHAR(2000) NOT NULL,
    [Url] NVARCHAR(450) NOT NULL,
    [Email] NVARCHAR(160) NOT NULL,
    [Type] TINYINT NOT NULL,
    CONSTRAINT [PK_Author] PRIMARY KEY ([Id])
)
GO

CREATE TABLE [Career](
    [Id] INT IDENTITY(1,1) NOT NULL, --UNIQUEIDENTIFIER -> muito gasto
    [Title] NVARCHAR(160) NOT NULL,
    [Sumary] NVARCHAR(2000) NOT NULL,
    [Url] NVARCHAR(1024) NOT NULL,
    [DurationInMinutes] INT NOT NULL,
    [Active] BIT NOT NULL,
    [Featured] BIT NOT NULL,
    [Tags] NVARCHAR(160) NOT NULL,
    CONSTRAINT [PK_Career] PRIMARY KEY ([Id])
)
GO

CREATE TABLE [Category](
    [Id] INT IDENTITY(1,1) NOT NULL, --UNIQUEIDENTIFIER -> muito gasto
    [Title] NVARCHAR(160) NOT NULL,
    [Url] NVARCHAR(1024) NOT NULL,
    [Sumary] NVARCHAR(2000) NOT NULL,
    [Order] INT NOT NULL,
    [Description] TEXT NOT NULL,
    [Featured] BIT NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY ([Id])
)
GO

CREATE TABLE [Course](
    [Id] INT IDENTITY(1,1) NOT NULL, --UNIQUEIDENTIFIER -> muito gasto
    [Tag] NVARCHAR(20) NOT NULL,
    [Title] NVARCHAR(160) NOT NULL,
    [Sumary] NVARCHAR(2000) NOT NULL,
    [Url] NVARCHAR(1024) NOT NULL,
    [Level] TINYINT NOT NULL,
    [DurationInMinutes] INT NOT NULL,
    [CreateDate] DATETIME NOT NULL,
    [LastUpdateDate] DATETIME NOT NULL,
    [Active] BIT NOT NULL,
    [Free] BIT NOT NULL,
    [Featured] BIT NOT NULL,
    [AuthorId] INT NOT NULL,
    [CategoryId] INT NOT NULL,
    [Tags] NVARCHAR(160) NOT NULL,
    CONSTRAINT [PK_Course] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Couse_Author_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [Author] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Couse_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Category] ([Id]) ON DELETE NO ACTION
)
GO

CREATE TABLE [CareerItem](
    [CareerId] INT NOT NULL,
    [CourseId] INT NOT NULL,
    [Title] NVARCHAR(160) NOT NULL,
    [Description] TEXT NOT NULL,
    [Order] TINYINT NOT NULL,
    
    CONSTRAINT [PK_CareerItem] PRIMARY KEY ([CourseId], [CareerId]),
    CONSTRAINT [FK_CareerItem_Career_CareerId] FOREIGN KEY ([CareerId]) REFERENCES [Career] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_CareerItem_Course_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Course] ([Id]) ON DELETE NO ACTION
)
GO

CREATE TABLE [StudentCourse](
    [CourseId] INT IDENTITY(1,1) NOT NULL,
    [StudentId] INT NOT NULL,
    [Progress] TINYINT NOT NULL,
    [Favorite] BIT NOT NULL,
    [StartDate] DATETIME NOT NULL,
    [LastUpdateDate] DATETIME NULL Default(GETDATE()),
    
    CONSTRAINT [PK_StudentCourse] PRIMARY KEY ([CourseId], [StudentId]),
    CONSTRAINT [FK_StudentCourse_Course_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Course] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_StudentCourse_Career_CareerId] FOREIGN KEY ([StudentId]) REFERENCES [Student] ([Id]) ON DELETE NO ACTION
)
GO

--Instalação da extensão admin pack for sql server. O que vamos usar é o sql server dacpac
-- popular o banco

