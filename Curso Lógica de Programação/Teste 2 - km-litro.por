programa
{
	
	funcao inicio()
	{
		real kmInicial, kmFinal
		real quantidade_litros
		real km_litro

		escreva("Qual sua quilometragem inicial? \n")
		leia(kmInicial)
		escreva("Qual sua quilometragem final? \n")
		leia(kmFinal)
		escreva("Quantos litros de gasolina foi colocado? \n")
		leia(quantidade_litros)

		km_litro = ((valor_percorrido(kmInicial, kmFinal)) / quantidade_litros)
		escreva("Consumiu ", km_litro, " Km por litro de gasolina")

		
	}

	funcao real valor_percorrido(real kmInicial, real kmFinal)
	{
		real valor_percorrido_km = kmFinal - kmInicial

		retorne valor_percorrido_km
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 575; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */