programa
{
	
	funcao inicio()
	{
		
	}

	publico interface IControlador
	{
		publico abstrato vazio ligar(){}
		publico abstrato vazio desligar(){}
		publico abstrato vazio abrirMenu(){}
		publico abstrato vazio fecharMenu(){}
		publico abstrato vazio maisVolume(){}
		publico abstrato vazio menosVolume(){}
		publico abstrato vazio ligarMudo(){}
		publico abstrato vazio desligarMudo(){}
		publico abstrato vazio play(){}
		publico abstrato vazio pause(){}
	}

	classe ControleRemoto{
		privado real volume
		privado logico ligado
		privado logico tocando

		publico ControleRemoto implementa Controlador()
		{
			volume = 50
			ligado = falso
			tocando = falso
		}

		publico  real  getVolume()
		{
			retorne este.volume
		}

		publico vazio  setVolume(real volume)
		{
			este.volume = volume
		}

		publico  logico  getLigado()
		{
			retorne este.ligado
		}

		publico vazio  setLigado(inteiro ligado)
		{
			este.ligado = ligado
		}

		publico  logico  getTocando()
		{
			retorne este.tocando
		}

		publico vazio  setTocando(inteiro tocando)
		{
			este.tocando = tocando
		}

		publico vazio ligar()
		{
			setLigado(verdadeiro)
		}
		publico vazio desligar()
		{
			seLigado(falso)
		}
		publico vazio abrirMenu()
		{
			escreva(getLigado())
			escreva(getVolume())
			para (inteiro i = 0; i <= getVolume(); i += 10)
			{
				escreva("|")
			}

			escreva(getTocando())
			
		}
		publico vazio fecharMenu()
		{
			escreva("Fechando menu")
		}
		publico vazio maisVolume()
		{
			se ( getLigado())
			{
				setVolume(getVolume() + 1)
				
			}
		}
		publico vazio menosVolume()
		{
			se (getLigado())
			{
				setVolume(get(volume - 1)
			}
		}
		publico vazio ligarMudo()
		{
			se (getLigado() e getVolume() > 0)
			{
				setVolume(0)
			}
		}
		publico vazio desligarMudo()
		{
			se (getLigado() e getVolume = 0)
			{
				setVolume(50)
			}
		}
		publico vazio play()
		{
			se (getLigado() e nao getTocando())
			{
				setTocando(verdadeiro)
			}
		}
		publico vazio pause()
		{
			se (getLigado() e getTocando())
			{
				setTocando(falso)
			}
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 2062; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */