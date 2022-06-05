use Aula;
drop table Aluno;
create table Aluno(
	id int not null auto_increment primary key,
    nome varchar(60) not null,
    nota1 int,
    nota2 int,
    faltas int
);
drop function situacao;
delimiter $$
create function situacao (nota_1 int, nota_2 int, faltas_aluno int) returns varchar(15)
begin
	declare media float;
    declare resposta varchar(15);
    
    set media = (nota_1 + nota_2)/2;
    if media >= 60 and faltas_aluno <= 10 then
		set resposta = 'Aprovado';
	elseif media < 30 or faltas_aluno > 10 then
		set resposta = 'Reprovado';
	elseif media > 30 and media < 60 and faltas_aluno <= 10 then
		set resposta = 'NP3';
	end if;
    return resposta;
end $$
delimiter ;

select situacao(100,60,2);
select situacao(60,35,2);

insert into Aluno(nome, nota1, nota2, faltas)
values ('Flávio', 35, 60,2), ('Rita', 100,100,20), ('João', 96,60,2);

select nome, situacao(nota1, nota2, faltas) from Aluno;

delimiter $$
create procedure avalia(nome_aluno varchar(60), nota1_aluno int, nota2_aluno int, faltas_aluno int)
begin
	declare resultado varchar(15);
    set resultado = (select situacao(nota1_aluno, nota2_aluno, faltas_aluno));
    
    if resultado = 'Aprovado' then 
		insert into Aluno(nome, nota1, nota2, faltas) values (nome_aluno, nota1_aluno, nota2_aluno, faltas_aluno);
	end if;
end $$
delimiter ;

select * from Aluno;
delete from Aluno where id = 3;

call avalia('Flávio', 35, 60,2);
call avalia('Rita', 100,100,20);
call avalia('João', 96,60,2);