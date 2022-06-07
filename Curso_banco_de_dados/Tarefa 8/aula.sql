drop database aula;

CREATE DATABASE aula;

USE aula;

CREATE TABLE Aluno (
    id int not null auto_increment primary key,
    nome varchar(50),
    idade int,
    email varchar(100)
);

CREATE TABLE compra (
    id int not null auto_increment primary key,
    nome varchar(50),
    preco FLOAT,
    pagamento FLOAT
);

drop procedure novoAluno;
create view maior as(
	select max(Aluno.id) from Aluno
);
delimiter $$
create procedure novoAluno(in entrada_nome varchar(50), in entrada_idade int, in entrada_email varchar(100))
begin
	declare aux int;
    set aux = (select * from maior);
    
    insert into Aluno(nome, idade, email)
	values(entrada_nome, entrada_idade, entrada_email);
    
    SET SQL_SAFE_UPDATES = 0;
    update Aluno
    set idade = 20
    where Aluno.id = aux;
    
    delete from Aluno 
    where Aluno.id % 2 = 0;
    
end $$
delimiter ;



call novoAluno('Tarcio', 23, 'tarcio@gmail.com');

select * from Aluno;

SET GLOBAL log_bin_trust_function_creators = 1;
delimiter $$
create function pagamentoCompra(pagamento float, preco float) returns varchar(45)
begin
	declare troco float;
    declare resposta varchar(45);
    
    set troco = (pagamento - preco);
    
    if troco < 0.05 then
		set resposta = 'Sem Troco';
	elseif troco <= 1 then
		set resposta = 'Balinhas de café';
	else
		set resposta = 'Em dinheiro';
	end if;
    
    return concat(resposta, ' : ', troco);
end $$
delimiter ;

insert into compra(nome, preco, pagamento) values('notebook', 2499.95, 2500.00), ('bicicleta', 1200.00, 1200.00);

select pagamentoCompra(compra.pagamento, compra.preco) from compra

