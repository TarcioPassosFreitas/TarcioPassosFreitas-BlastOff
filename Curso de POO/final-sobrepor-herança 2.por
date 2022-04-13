programa
{
	
	funcao inicio()
	{
		p1 = novo Pessoa() //falso
		v1 = novo Visitante() //verdadeiro
		a1 = novo Aluno() //verdadeiro
		b1 = novo Bolsista() //verdadeiro
	}

	classe abstrata Pessoa
	{
		privado cadeia nome
		privado inteiro idade
		privado cadeia sexo
	
		publico metodo final fazerAniv()
		{
			(...)
		}

	}

	classe Visitante estende Pessoa
	{
		(...)
	}

	classe Aluno estende Pessoa
	{
		privado inteiro matricula
		privado cadeia curso

		publico metodo pagarMensalidade()
		{
			(...)
		}
		
	}

	classe Bolsista estende Aluno
	{
		privado real bolsa
		publico metodo renovarBolsa()
		{
			(...)
		}
	}
		
	
	@sobrepor
	publico metodo pagarMensalidade()
	{
		(...)
	}

	
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 172; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */