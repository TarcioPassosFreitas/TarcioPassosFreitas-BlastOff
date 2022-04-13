programa
{
	
	funcao inicio()
	{
		m = novo Mamifero()
		r = novo Reptil()
		p = novo Peixe()
		a = novo Ave()
		
		m.setPeso(85.3)
		m.setIdade(2)
		m.setMembros(4)
		//entre outros exemplos

	}

	classe abstrata Animal
	{
		protegido real peso
		protegido inteiro idade
		protegido inteiro membro
		publico metodo abstrato locomover() 
		publico metodo abstrato alimentar()
		publico metodo abstrato emitirSom()
	}
	
	classe Mamifero estende Animal
	{
		privado cadeia corPelo
	
		@sobrepor
		publico metodo locomover()
		{
			Escreva("Correndo")
		}
	
	
		@sobrepor
		publico metodo alimentar()
		{
			Escreva("Mamando")
		}
			
	
		@sobrepor metodo emitirSom()
		{
			Escreva("Som de Mamifero")
		}
			
	}
	
	classe Reptil estende Animal
	{
		privado corEscama: Caractere()
		@sobrepor
		publico metodo locomover()
			Escreva("Rastejando")
		FimMetodo
	
		@sobrepor
		publico metodo alimentar()
			Escreva("comendo vegetais")
		FimMetodo
	
		@sobrepor
		publico metodo emitirSom()
			Escreva("som de reptil")
	}
	
	classe Peixe estende Animal
	{
		
		privado cadeia corEscama
	
		@sobrepor
		publico metodo locomover()
		{
			Escreva("nadando")
		}
	
		@sobrepor
		publico metodo emitirSom()
		{
			Escreva("peixe nao faz som")
		}
	
		@sobrepor
		publico soltarBolha()
		{
			Escreva("soltando bolha")
		}
	}
	
	classe Ave estende Animal
	{
		
	}
		privado cadeia corPena
	
		@sobrepor
		publico metodo locomover()
		{
			Escreva("voando")
		}
	
		@sobrepor
		publico metodo alimentar()
		{
			Escreva("Comendo frutas")
		}

		@sobrepor
		publico metodo emitirSom()
		{
			Escreva("Som de ave")
		}
	
		@sobrepor
		publico metodo fazerNinho()
		{
			Escreva("Construiu o ninho")
		}
	
	classe Canguru estende Mamifero
	{
		publico metodo usarBolsa()
		{
			Escreva("usando bolsa")
		}
	
		@sobrepor 
		publico metodo locomover()
		{
			Escreva("saltando")
		}
	}
		
			
	
	classe Cachorro estende Mamifero
	{
		publico metodo enterrarOsso()
		{
			Escreva("Enterrando osso")
		}
	
		publico metodo abanarRabo()
		{
			Escreva("abanando o rabo")
		}
	}
		
	
	classe Cobra estende Reptil
	{
		publico metodo abstrato locomover(){}
	}
	
	classe Tartaruga estende Reptil
	{
		@sobrepor
		publico metodo locomover()
		{
			Escreva("andando beeeem deveagar")
		}
	}
		
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 196; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */