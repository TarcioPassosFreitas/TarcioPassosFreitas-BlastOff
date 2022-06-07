create database Tarefas;
USE Tarefas;

CREATE TABLE Empresa(
	matricula INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50),
    cpf CHAR(11),
    cargo VARCHAR(20),
    nProjetos INT
); 

INSERT INTO Empresa(nome, cpf, cargo, nProjetos) VALUES ('ALEXANDRE', '00000000000', 'GP', 2), 
('NATANAEL', '11111111111', 'DESENVOLVEDOR', 4), ('ROCHELLE', '22222222222', 'TESTER', 3), ('JANE', '33333333333', 'DESENVOLVEDOR', 5);

SELECT * FROM Empresa WHERE nProjetos = (SELECT MAX(nProjetos) FROM Empresa);

SELECT * FROM Empresa WHERE nProjetos = (SELECT MIN(nProjetos) FROM Empresa);

SELECT AVG(nProjetos) FROM Empresa WHERE cargo != 'GP';

SELECT nome FROM Empresa WHERE nProjetos >= 4;

SELECT distinct cargo FROM Empresa;

SELECT nome, cpf, nProjetos FROM Empresa WHERE cargo = 'DESENVOLVEDOR';