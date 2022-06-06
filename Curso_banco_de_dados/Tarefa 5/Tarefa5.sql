DROP DATABASE IF EXISTS Tarefa5;

CREATE DATABASE Tarefa5;

USE Tarefa5;

CREATE TABLE cliente(
	id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(30) NOT NULL, 
    cpf CHAR(11) NOT NULL,
    endereco VARCHAR(50) NOT NULL
);

INSERT INTO cliente(nome, cpf, endereco) VALUES('FLÁVIO', '00000000000', 'RUA A'), ('PÂMELA', '11111111111', 'RUA B');

SELECT * FROM cliente;

ALTER TABLE cliente
	ADD ano_de_nascimento DATE;

SELECT * FROM cliente;

UPDATE cliente
SET ano_de_nascimento = '1990-01-20'
WHERE id = 1;

SELECT * FROM cliente;

UPDATE cliente
SET ano_de_nascimento = '1985-05-25'
WHERE id = 2;

SELECT * FROM cliente;

DELETE FROM cliente WHERE id = 1;

SELECT * FROM cliente;

DROP TABLE cliente;

SELECT * FROM cliente;
    

