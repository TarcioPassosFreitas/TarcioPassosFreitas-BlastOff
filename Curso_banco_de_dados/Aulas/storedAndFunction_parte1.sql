-- stored procedure, são módulos (blocos de comandos SQL) armazenados de modo persistente e executados pelo SGBD no servidor de banco de dados
-- úteis quando tem-se várias aplicações escritas em diferentes linguagens, ou rodam em plataformas diferentes, porém executam a mesma função(procedimento)
-- em um mesmo banco de dados
-- centralização: falicita a manutenção e melhora a modularidade do software
drop database Aula;
create database Aula;

use Aula;

create table Produto(
	id int not null auto_increment primary key,
    nome varchar(45)
);

-- delimitar a operação
delimiter $$
drop procedure if exists cadProd $$ -- exlclui o procedimento se existir
create procedure cadProd(in nome_tabela varchar(45)) -- o in é opcional
-- in parâmetro de entrada
-- out parâmetro de saída
-- inout faz os dois trabalhos ao mesmo tempo
-- prodecure não tem return, usamos o select "retornar o valor que deseja" 
begin
	insert into Produto(nome) values(nome_tabela);
    select * from Produto;
end $$
-- tem que colocar o espaço em delimiter para colocar o ; depois     
delimiter ;

-- chamando o procedimento
call cadProd('Piano');
call cadProd('Flauta');
call cadProd('Guitarra');

-- deveria ser uma função ao invés de uma procedure
delimiter $$
create procedure soma(in num1 int, in num2 int)
begin
	select num1 + num2 as soma;
end $$

delimiter ;

call soma(10, 10)

delimiter $$
create procedure testeif(in num1 int, in num2 int)
begin
	declare soma int;
    declare resultado varchar(15);
    set soma = num1 + num2;
    
    if soma > 0 then
		set resultado = 'Positivo';
	elseif soma < 0 then
		set resultado = 'Negativo';
	else
		set resultado = 'Neutro';
	end if;
    select concat('A soma entre ', num1, ' e ', num2, ' é: ', resultado) RESULTADO;
end $$
delimiter ;

call testeif(2,2);

delimiter $$
create procedure fatorial(num int)
begin
	declare resposta int;
    declare aux int;
    set aux = num;
    set resposta = 1;
    
    while num > 0 do
		set resposta = resposta * num;
        set num = num - 1;
	end while;
    select concat('A fatorial de ', aux, ' é: ', resposta) as RESPOSTA;
end $$
delimiter ;

call fatorial(5);

-- function precisa ter obrigatoriamente um retorno. trata os parâmetros que estão sendo enviados para uma tabela
-- se der erro na criação da function, colocar: SET GLOBAL log_bin_trust_function_creators = 1;
SET GLOBAL log_bin_trust_function_creators = 1;
delimiter $$
-- o in não pode ser usado, da erro de sintaxe. decimal tb não da pra colocar a não ser 2
create function mult(num1 float, num2 float) returns float
begin
	return num1 * num2;
end $$
delimiter ;
drop function mult;
select mult(3.2, 2);

