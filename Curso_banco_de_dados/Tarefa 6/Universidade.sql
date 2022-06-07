CREATE DATABASE Universidade;

USE Universidade;

create table Alunos (
	MAT int,
	nome varchar (45),
	endereco varchar (45),
	cidade varchar (45),
	constraint primary key (MAT)
);

create table Disciplinas (
	COD_DISC varchar(10),
	nome_disc varchar (45) not null,
	carga_hor int,
	primary key (COD_DISC)
);

create table Professores (
	COD_PROF int,
	nome varchar (45) not null,
	endereco varchar (45),
	cidade varchar (45),
	primary key (COD_PROF)
);

create table Turma(
	COD_DISC varchar(10),
	COD_TURMA int,
	COD_PROF int,
	disci varchar (5),
	ano int,
	horario varchar (45),
	primary key (COD_TURMA,COD_DISC,COD_PROF,ano),
	constraint FK_Disc foreign key (COD_DISC) references Disciplinas (COD_DISC),
	constraint FK_Prof foreign key (COD_PROF) references Professores (COD_PROF)
);

create table Historico (
	MAT int,
	COD_DISC varchar(10),
	COD_TURMA int,
	COD_PROF int,
	ano int,
	frequencia int,
	nota int,
	primary key (MAT,COD_DISC,COD_TURMA,COD_PROF,ano),
	constraint FK_histalun foreign key (MAT) references Alunos (MAT),
	constraint FK_histfisc foreign key (COD_DISC,COD_TURMA,COD_PROF,ano) references Turma (COD_Disc,COD_TURMA,COD_PROF,ano)
);

SELECT * FROM Alunos;

INSERT INTO Alunos(MAT, nome, endereco, cidade) VALUES (2015010101, 'JOSE DE ALENCAR', 'RUA DAS ALMAS', 'NATAL'),
(2015010102, 'JOÃO JOSÉ', 'AVENIDA RUY CARNEIRO', 'JOÃO PESSOA'),
(2015010103, 'MARIA JOAQUINA', 'RUA CARROSSEL', 'RECIFE'),
(2015010104, 'MARIA DAS DORES', 'RUA DAS LADEIRAS', 'FORTALEZA'),
(2015010105, 'JOSUÉ CLAUDINO DOS SANTOS', 'CENTRO', 'NATAL'),
(2015010106, 'JOSUÉLISSON CLAUDINO DOS SANTOS', 'CENTRO', 'NATAL');

insert into Disciplinas values('BD', 'BANCO DE DADOS', '100'),
('POO', 'PROGRAMAÇÃO COM ACESSO A BANCO DE DADOS', '100'),
('WEB', 'AUTORIA WEB', '50'),
('ENG', 'ENGENHARIA DE SOFTWARE', '80');

INSERT INTO Professores(COD_PROF, nome, endereco, cidade) VALUES(212131, 'NICKERSON FERREIRA', 'RUA MANAÍRA', 'JOÃO PESSOA'),
(122135, 'ADORILSON BEZERRA', 'AVENIDA SALGADO FILHO', 'NATAL'),
(192011, 'DIEGO OLIVEIRA', 'AVENIDA ROBERTO FREIRE', 'NATAL');

insert into Turma values('BD', '1', '212131', 'BD', '2015', '11H-12H'),
('BD', '2', '212131', 'BD', '2015', '13H-14H'),
('POO', '1', '192011', 'POO', '2015', '08H-09H'),
('WEB', '1', 192011, 'WEB', '2015', '07H-08H'),
('ENG', '1', 122135, 'ENG', '2015', '10H-11H');


insert into Historico values('2015010101', 'BD', '1', '212131', '2015', '100', '10'),
('2015010102', 'BD', '2', '212131', '2015', '100', '4'),
('2015010103','POO', '1', '192011', '2015', '100', '10'),
('2015010104','WEB', '1', 192011, '2015', '100', '3'),
('2015010105', 'ENG', '1', 122135, '2015', '100', '10'),
('2015010106', 'BD', '1', '212131', '2015', '100', '2');

select MAT from Historico where Historico.COD_DISC = 'BD' and Historico.ano = '2015' and Historico.nota < 5;

select MAT, AVG(Historico.nota) as Media from Historico where Historico.COD_DISC = 'POO' and Historico.ano = '2015';

select COUNT(MAT) as Quantidade from Alunos where cidade != 'NATAL';



