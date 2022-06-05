-- view é uma estrutura que não armazena dados 
-- create view nomeview as (select * from nomeTabela);
-- drop view nomeview;
-- alter view nomeview as ("Novo select");

create database aula13;

use aula13;
create table Estoque(
	cod_item int not null primary key,
    qtd_disponivel int
);

create table ItensSolicitacao(
	id_solicitacao int auto_increment primary key,
    cod_item int not null,
    nome varchar(20),
    qtd int
);

insert into ItensSolicitacao(cod_item, nome, qtd)
values (100, 'Resistor 100k', 5), (110, 'Resistor 1k', 2), ('120', 'Capacitor 100n', 2), (130, 'Transistor TBJ', 1);

insert into Estoque(cod_item, qtd_disponivel)
values (100, 1500), (110, 500), (120, 300), (130, 600);

select * from ItensSolicitacao;

-- crie uma view que retorne os dados:
-- item			quantidade no estoque
-- resistor 100k 	1500
-- resitor 1k		500
-- capacitor 100n 	300
-- transistor TBJ	600

drop view compra;
create view compra as (
	select I.nome as item, E.qtd_disponivel as 'Quantidade no estoque' from ItensSolicitacao as I join Estoque as E
    using(cod_item)
);
-- se os dois atributos de tabelas diferentes tiver o mesmo nome, pode usar o using

create view compra as (
	select I.nome as item, E.qtd_disponivel as 'Quantidade no estoque' from ItensSolicitacao as I join Estoque as E
    using(cod_item)
);

select * from compra;


-- trigger ou gatilho é associado a uma tabela
-- é disparado quando um determinado evento ocorre na tabela
-- eventos de insert, update, delete (comandos DML)
-- para cada comando, pode haver apenas um trigger
 -- podem existir vários triggers em um banco de dados
 
 -- Principais usos:
 -- executar verificação de valores; ou
 -- fazer cálculos sobre os valores informados em um evento

-- o trigger é ativado quando uma declaração insert, update ou delete ocorre na tabela associada;
-- O disparo do "gatilho" pode ser configurado para ocorrer antes ou depois do evento (comandos insert, update ou delete)

-- BEFORE: dispara o trigger antes dos dados chegarem à tabela
-- AFTER: dispara o trigger após a atualização dos dados em uma tabela

set sql_safe_updates = 0;

create table Conta(
	numero int, 
    total decimal(10, 2) 
);

-- crie um trigger chamado ins_soma que execute o bloco de comandos dele antes que o evento de inserção ocorrer na tabela Conta
create trigger ins_soma before insert on Conta
for each row
	-- new pega o evento de inserção, se colocasse old, pegava o que estava armazenado na tabela
	set @soma = @soma + new.total;

drop trigger ins_soma;

select * from Conta;

set @soma = 0;
insert into Conta values(137,14.98), (141,1937.50), (97,100.00);

select @soma;

delete from Conta where numero >= 0; -- da erro por tentar excluir múltiplos registros, por padrão o mysql não deixa
-- da pra deletar usano uma gambiarra, desabilitando a chave primária: set sql_safe_updates = 0;

-- trigger de múltiplos set, delimiter é necessário

delimiter $$
create trigger upd_check before update on Conta
for each row
begin
	if new.total < 0 then 
		set new.total = 0;
	elseif new.total > 100 then
		set new.total = 100;
	end if;
end; $$
delimiter ;

select * from Conta;

update Conta set total = 200 where numero = 137;

-- OLD: operador para ser utilizado no interior da trigger para recuperar o valor anterior à um update, delete;
-- NEW: operador para ser utilizado no interior da trigger para recuperar dados atuais a partir de comandos insert, update

create table Nomes(
	id int auto_increment primary key,
    nome varchar(30)
);

insert into Nomes(nome) values ('Flávio');
select * from Nomes;

delimiter //
create trigger atualiza after update on Nomes
for each row
begin
	set @var_old = old.nome;
    set @var_new = new.nome;
end; //
delimiter ;


select * from Nomes;
select @var_old;
select @var_new;
update Nomes set nome = 'Antônio' where id = 1;



    


