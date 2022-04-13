programa
{
	
	funcao inicio()
	{
		p1 = novo Pessoa()
		p2 = novo Aluno()
		p3 = novo Professor()
		p4 = novo Funcionario()
		
		p1.setNome = ("Pedro")
		p2.setNome = ("Maria")
	}

	classe Pessoa
	{
		privado cadeia nome
		privado inteiro idade
		privado cadeia sexo
	
		publico Metodo fazerAniv()
			(...)
	
		publico Metodo getNome()
			(...)
	
		publico Metodo setNome()
			(...)
	
		publico Metodo getIdade()
			(...)
	
		publico Metodo setIdade()
			(...)
	
		publico Metodo getSexo()
			(...)
	
		publico Metodo setSexo()
			(...)
	}

	classe Aluno estende Pessoa
	{
		privado inteiro matr
		privado cadeia curso
	
		publico Metodo getMatr()
		{
			(...)
		}
	
		publico Metodo setMatr()
		{
			(...)
		}
			
	
		publico Metodo getCurso()
		{
			(...)
		}
	
		publico Metodo setCurso()
		{
			(...)
		}
	}

	classe Professor estende Pessoa
	{
	
		privado cadeia especialidade
		privado real salario
	
		
		publico Metodo receberAum()
		{
			(...)
		}
			
	
		publico Metodo getEspecialidade()
		{
			(...)
		}
		
	
		publico Metodo setEspecialidade()
		{
			(...)
		}
		
	
		publico Metodo getSalario()
		{
			(...)
		}
		
	
		publico Metodo setSalario()
		{
			(...)
		}

	}

	classe Funcionario estende Pessoa
	{
		privado cadeia setor
		privado logico trabalhando
	
		
		publico Metodo mudarTrabalho()
		{
			(...)
		}
		
		publico Metodo getSetor()
		{
			(...)
		}
	
		publico Metodo setSetor()
		{
			(...)
		}
	
		publico Metodo getTrabalhando()
		{
			(...)
		}
	
		publico Metodo setTrabalhando()
		{
			(...)
		}
	}
	
	
	

	
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 37; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */