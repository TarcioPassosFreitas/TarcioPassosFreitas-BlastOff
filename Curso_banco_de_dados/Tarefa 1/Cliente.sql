CREATE DATABASE Tarefas;

USE Tarefas;

CREATE TABLE Cliente(
	cpf CHAR(11) PRIMARY KEY,
    nome VARCHAR(50),
    endereco VARCHAR(80),
    anos_nasc DATETIME
);

INSERT INTO Cliente VALUES(12345678910, 'Flavio', 'Rua 1', '1998-09-04'), 
(12345678911, 'Pamela', 'Rua 2', '1990-09-04'), (12345678912, 'Fernando', 'Rua 3', '1980-09-04');

UPDATE Cliente SET endereco = 'Rua 4' WHERE cpf = 12345678912;

SELECT Cliente.nome AS NOME, Cliente.cpf AS CPF FROM Cliente WHERE Cliente.cpf = 12345678910;

DELETE FROM Cliente WHERE Cliente.cpf = 12345678910;
