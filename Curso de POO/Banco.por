programa
{
	
	funcao inicio()
	{
		Banco b = novo Banco()
	}

	classe Banco{
		publico inteiro numConta
		abstrato cadeia tipo
		privado cadeia dono
		privado real saldo
		privado logico status
		
		publico Metodo Banco()
		{	
			saldo = 0
			status = falso
		}

		publico  inteiro  getNumConta()
		{
			retorne este.numConta
		}

		publico vazio  setNumConta(inteiro numConta)
		{
			este.numConta = numConta
		}

		
		publico cadeia  getTipo()
		{
			retorne este.tipo
		}

		publico vazio  setTipo(cadeia tipo)
		{
			este.tipo = tipo
		}
		

		publico cadeia  getDono()
		{
			retorne este.dono
		}

		publico vazio  setNumConta(cadeia dono)
		{
			este.dono = dono
		}

		publico real  getSaldo()
		{
			retorne este.saldo
		}

		publico vazio  setSaldo(real saldo)
		{
			este.saldo = saldo
		}

		publico logico  getSatus()
		{
			retorne este.status
		}

		publico vazio setStatus(logico status)
		{
			este.status = status
		}


		publico vazio abrirConta(cadeia dono, cadeia tipo)
		{
			setDono(dono)
			setTipo(tipo)
			se (tipo == "CC")
			{
				saldo = 50
			} senao se (tipo == "CP")
			{
				saldo = 150
			}

			setStatus(verdadeiro)

			escreva("Status da sua conta é: ", status)
		}

		publico vazio fecharConta()
		{
			se (saldo > 0)
			{
				escreva("Conta com dinheiro")
			}
			senao se(saldo < 0)
			{
				escreva("Conta com dinheiro")
			}
			senao
			{
				setsatus(falso)
				escreva("Conta sendo fechada. Status da conta: ", status)
			}
		}

		publico logico depositar(real valor)
		{
			se (status == verdadeiro)
			{
				setSaldo(getSaldo() + valor)
				retorne verdadeiro
			}senao
			{
				retorne falso
			}
		}

		publico vazio sacar(real valor)
		{
			se (status == verdadeiro)
			{
				se (saldo >= valor)
				{
					saldo -= valor
					escreva("Você sacou R$: ", valor)
				}senao
				{
					escreva("Saldo insuficiente")
				}
			}senao
			{
				escreva("Impossível sacar sem ter uma conta")
			}
		}

		publico vazio pagarMensal()
		{
			real valor
			se (tipo == "CC")
			{
				valor = 12
			} senao se (tipo == "CP")
			{
				valor = 20
			}

			se (status == verdadeiro) {
				se (saldo > valor)
				{
					saldo -= valor
					escreva("Você sacou R$: ", valor)
				} senao
				{
					escreva("Saldo insuficiente")
				}
			} senao
			{
				Escreva("Não é possível cobrar de conta que não está aberta")
			}
		}

		
		
	}

}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 62; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */