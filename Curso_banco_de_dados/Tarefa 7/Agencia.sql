create database Agencia;

use Agencia;

create table Agente( 
	idAgente int auto_increment,
    nome varchar(45) not null,
    endereco varchar(45),
    nascimento date,
    habilidade varchar(45),
    sexo varchar(45),
    email varchar(45),
    primary key(idAgente)
);

create table Vilao(
	idvilao int auto_increment,
    nome varchar(45) not null,
    num_crimes int not null,
    primary key(idvilao)
);

create table Missao(
	idMissao int auto_increment,
    data date not null,
    nome varchar(45) not null,
    local varchar(45),
    duracao int,
    vilao_idvilao int,
    primary key(idMissao),
    constraint FK_Vilao_idvilao foreign key (vilao_idvilao) references Vilao(idvilao)
);

create table Agente_has_Missao(
	agente_idAgente int,
    missao_idMissao int,
    primary key(agente_idAgente, missao_idMissao),
    constraint FK_agente_idAgente foreign key (agente_idAgente) references Agente(idAgente),
    constraint FK_missao_idMissao foreign key (missao_idMissao) references Missao(idMissao)
);

insert into Agente(nome, endereco, nascimento, habilidade, sexo, email) values('Flávio', 'Rua a', '1985-05-25', 'hacker', 'M', 'flavio@gmail.com'),
 ('Pâmela', 'Rua b', '1980-05-25', 'infiltrada', 'F', 'pamela@gmail.com'),
 ('João', 'Rua c', '1990-05-25', 'pesquisador', 'M', 'joao@gmail.com'),
 ('Hiago', 'Rua d', '1995-05-25', 'bomba', 'M', 'hiago@gmail.com'),
 ('Roberto', 'Rua e', '1998-05-25', 'design', 'M', 'roberto@gmail.com');
 
 insert into Vilao(nome, num_crimes) values('abacate', 5),
 ('ameixa', 10),
 ('amora', 15),
 ('beterraba', 20),
 ('abacaxi', 25);
 
 insert into Missao(data, nome, local, duracao, vilao_idvilao) values('2006-05-20', 'salvar mercúrio do vilão', 'esquadrão a', 25, 1),
 ('2007-05-20', 'salvar vênus do vilão', 'esquadrão b', 30, 2),
 ('2008-05-20', 'salvar terra do vilão', 'esquadrão c', 35, 3),
 ('2009-05-20', 'salvar marte do vilão', 'esquadrão d', 40, 4),
 ('2010-05-20', 'salvar jupiter do vilão', 'esquadrão e', 45, 5);
 
 insert into Agente_has_Missao(agente_idAgente, missao_idMissao) values(1,1),
 (2,2),
 (3,3),
 (4,4),
 (5,5);
 
 select Agente.nome as nome_agente, Agente.email as email_agente, Missao.nome as nome_missao, Missao.data as data_missao
 from Agente join Agente_has_Missao on Agente.idAgente = Agente_has_Missao.agente_idAgente join Missao on
 Missao.idMissao = Agente_has_Missao.missao_idMissao;
 
 select Missao.nome as nome_missao, Missao.data as data_missao, Missao.duracao as duracao_missao, Vilao.nome from Missao 
 join Vilao on Missao.vilao_idvilao = Vilao.idvilao;
 
 select Agente.nome as nome_agente, Missao.nome as nome_missao, Vilao.nome as nome_vilao from Agente join Agente_has_Missao
 on Agente.idAgente = Agente_has_Missao.agente_idAgente join Missao
 on Missao.idMissao = Agente_has_Missao.missao_idMissao join Vilao
 on Missao.vilao_idvilao = Vilao.idvilao;
