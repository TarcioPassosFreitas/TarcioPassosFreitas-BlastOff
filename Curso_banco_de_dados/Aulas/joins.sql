create database Empresa;
Use Empresa;

create table Departamento(
	idDepartamento int auto_increment primary key,
    nome varchar(45) NOT NULL,
    qtd_projeto int
);

Create table Empregado(
	idEmpregado INT NOT NULL primary key,
    nome varchar(30) NOT NULL,
    endereco varchar(45) NOT NULL,
    fkDepartamento int
);

create table Dependentes(
	idDependente int not null auto_increment,
    primary key(idDependente),
    nome varchar(45) not null,
    endereco varchar(45) not null,
    fkEmpregado int,
    Constraint fk_Empregado
		foreign key(fkEmpregado) references Empregado(idEmpregado)
        on update cascade
        on delete cascade
);

create table projeto(
	idProjeto int not null auto_increment primary key,
    nome varchar(45) not null,
    setor varchar(45) not null
);

create table Empregado_has_Projeto(
	fkEmpregado int,
    fkProjeto int,
    data_conclusao date,
    primary key(fkEmpregado, fkProjeto),
    constraint fk_Empregado_has_projeto foreign key(fkEmpregado) references Empregado(idEmpregado),
    constraint fk_Projeto foreign key(fkProjeto) references Projeto(idProjeto)
);

insert into Empregado(idEmpregado, nome, endereco) values ('1', 'Filipe', 'Rua1'), ('2', 'Flávio', 'Rua2'), ('3', 'Fernando', 'Rua3');
select distinct nome, idEmpregado, idEmpregado+4 from Empregado;


insert into Dependentes(nome, endereco, fkEmpregado) values('Vanessa', 'Rua10', 2), ('Vania', 'Rua3', 3), ('João', 'Rua50', 2), ('Maria', 'Rua50', 2);
select * from Dependentes group by idDependente having (idDependente >= 1);

select * from Dependentes where nome like 'Va%'; 
select * from Dependentes where idDependente between 2 and 3;

-- =====média=====
select avg (idDependente) from Dependentes;
select count(idDependente) from Dependentes;

select sum(idDependente) from Dependentes;

select max(idDependente) from Dependentes;

select min(idDependente) from Dependentes;

select nome from Dependentes where idDependente in (select max(idDependente) from Dependentes);

-- =====================================JOINS===================================================

select E.nome as 'Empregado', D.nome as 'Dependente' from Empregado as E inner join Dependentes as D
on D.fkEmpregado = E.idEmpregado;
 -- Inserir valores de projeto
 
insert into Projeto(nome, setor) values('Guitarra', 3), ('Bateria', 50), ('Amplificador Valvulado', 30);

insert into Empregado_has_Projeto() values (3,2,'2021-12-25'), ('2', '1', '2022-04-10'), ('2', '3', '2022-04-10'); 

select * from Empregado_has_Projeto;

select E.nome, P.nome, EP.data_conclusao from Empregado as E 
join Empregado_has_Projeto as EP 
on E.idEmpregado = EP.fkEmpregado 
join Projeto as P 
on P.idProjeto = EP.fkProjeto
