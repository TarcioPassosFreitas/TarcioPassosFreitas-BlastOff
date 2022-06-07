CREATE DATABASE loja;

USE loja;

CREATE TABLE compra(
    id int not null auto_increment primary key,
    preco float,
    pagamento float
);

INSERT INTO compra (preco, pagamento) VALUES (9.5, 10.25), (18.99, 25), (3.99, 5), (8.85, 8.89), (19.49, 20);

create view compras as(
	select count(*) as quantidade from compra where compra.preco >= 10 
);

select * from compras;

-- =============Questão 2================================

CREATE DATABASE estoque;

USE estoque;

CREATE TABLE produtos (
    id INT PRIMARY KEY,
    descricao VARCHAR(50) UNIQUE,
    estoque INT NOT NULL
);

INSERT INTO produtos VALUES ('1', 'Lasanha', '10');
INSERT INTO produtos VALUES ('2', 'Morango', '5');
INSERT INTO produtos VALUES ('3', 'Farinha', '15');

CREATE TABLE itens_venda (
    id_venda INT PRIMARY KEY,
    id_produto INT,
    quantidade INT
);

delimiter $$
create trigger decrement_estoque after insert on itens_venda
for each row
begin
	update produtos
    set estoque = estoque - new.quantidade
    where id = new.id_produto;
end $$
delimiter ;

insert into itens_venda values(1, 2, 4);

select * from produtos;

drop trigger increment_estoque;

delimiter $$
create trigger increment_estoque after delete on itens_venda
for each row
begin
	update produtos
    set estoque = estoque + old.quantidade
    where id = old.id_produto;
end $$
delimiter ;

select * from itens_venda;
delete from itens_venda where id_venda = 1;

select * from produtos;