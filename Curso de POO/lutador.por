programa
{
	
	funcao inicio()
	{
		Lutador l1 = novo Lutador("Pretty Boy", "França", 31, 1.75, 68.9, 11, 3, 1)
		Lutador l2 = novo Lutador("Putscript", "Brasil", 29, 1.68, 57.8, 14, 2, 3)
		Lutador l3 = novo Lutador("Snapshadow", "EUA", 35, 1.65, 80.9, 12, 2, 1)
		Lutador l4 = novo Lutador("Dead Code", "Australia", 28, 1.93, 81.6, 12, 0, 2)

		
	}

	classe Lutador{
		
		privado cadeia nome
		privado cadeia nacionalidade
		privado inteiro idade
		privado real altura
		privado real peso
		privado cadeia categoria
		privado inteiro vitorias
		privado inteiro derrotas
		privado inteiro empates

		publico Lutador(cadeia nome, cadeia nacionalidade, inteiro idade, real altura, real peso, cadeia categoria, inteiro vitoria, inteiro derrotas, inteiro empates)
		{
			nome = nome
			nacionalidade = nacionalidade
			idade = idade
			altura = altura
			peso = peso 
			categoria = categoria
			votorias = vitorias
			derrotas = derrotas
			empates = empates
		}
		
			publico cadeia getNome()
			{
				retorne nome
			}
		
			publico vazio setNome(cadeia nome)
			{
				nome = nome
			}
		
			publico cadeia getNacionalidade()
			{
				retorne nacionalidade
			}
				
			
		
			publico vazio setNacionalidade(cadeia nacionalidade)
			{
				nacionalidade = nacionalidade
			}
				
		
			publico inteiro getIdade()
			{
				retorne idade
			}
				
		
			publico vazio setIdade(inteiro idade)
			{
				idade = idade 
			}
				
		
			publico real getAltura()
			{
				retorne altura
			}
		
			publico vazio setAltura(real altura)
			{
				altura = altura
			}			
		
			publico real getPeso()
			{
				retorne peso
			}
		
			publico vazio setPeso(real peso)
			{
				peso = peso
				setCategoria()
			}
				
			
		
			publico cadeia getCategoria()
			{
				retorne categoria
			}
				
			
		
		
			publico vazio setCategoria()
				se (peso < 52.2)
			{
				categoria = "invalido"
			}senao se (peso < = 70.3)
			{
				categoria = "leve"	
			}senao se (peso <= 83.9)
			{
				categoria = "medio"
			}senao se (peso <= 120.2)
			{
				categoria = "pesado"
			}senao
			{
				categoria = "invalido"
			}
					
		
			publico inteiro getVitorias()
			{
				retorne vitorias
			}
		
			publico vazio setVitorias(inteiro vitorias)
			{
				vitorias = vitorias
			}
		
		
			publico inteiro getDerrotas()
			{
				retorne derrotas
			}
				
		
			publico vazio setDerrotas(inteiro derrotas)
			{
				derrotas = derrotas
			}
		
			publico inteiro getEmpates()
			{
				retorne empates
			}
		
			publico vazio setEmpates(inteiro empates)
			{
				empates = empates
			}

			publico vazio apresentar()
			{
				
				escreva("Lutador: ", getNome())
				escreva("Origem: ", getNacionalidade())
				escreva("Idade: ", getIdade(), "anos")
				escreva("Altura: ", getAltura(), "m de altura")
				escreva("Pesando: ", getPeso(), "Kg")
				escreva("Ganhou:", getVitorias())
				escreva("Perdeu: ". getDerrotas())
				escreva("Empatou: ", getEmpates())
			}
			
		
	
			publico vazio status()
			{
				escreva(getNome())
				escreva("é um peso", getCategoria())
				escreva(getVitorias(), "vitórias")
				escreva(getDerrotas(), "derrotas")
				escreva(getEmpates(), "empates")
			}
		
			publico vazio ganharLuta()
			{
				setVitorias(getVitorias() + 1)
			}
				
			publico vazio perderLuta()
			{
				setDerrotas(getDerrotas() + 1)
			}
		
			publico vazio empatarLuta()
			{
				setEmpates(getEmpates() + 1)
			}
		
	
	}

	classe Luta{
		privado Lutador desafiando
		privado Lutador desafiante
		privado inteiro rodadas
		privado logico aprovado

		publico Lutador getDesafiando()
		{
			retorne desafiando
		}
		
		publico vazio setDesafiando(Lutador desafiando)
		{
			desafiando = desafiando
		}
		publico Lutador getDesafiante()
		{
			retorne desafiante
		}
		
		publico vazio setVitorias(Lutador desafiando)
		{
			desafiando = desafiando
		}
		publico inteiro getRodadas()
		{
			retorne rodadas
		}
		
		publico vazio setVitorias(inteiro rodadas)
		{
			rodadas = rodadas
		}
		publico logico getAprovado()
		{
			retorne vitorias
		}
		
		publico vazio setVitorias(logico aprovado)
		{
			aprovado = aprovado
		}

		publico vazio marcarLuta(Lutado l1, Lutador l2)
		{
			se (l1.getCategoria() = l2.getCategoria()) e (l1 <> l2)
			{
				aprovada = verdadeiro
				desafiado = l1
				desafiante = l2
			}senao
			{
				aprovada = falso
				desafiado = nulo
				desafiante = nulo
			}
				
		}

		publico vazio lutar()
		{
			se (aprovada)
			{
				desafiando.apresentar()
				desafiante.apresentar()
				vencedor = aleatorio(02)

				escolha(vencedor)
				{
					caso 0:
					Escreva("Empate")
					desafiando.empatarLuta()
					desafiante.empatarLuta()
					pare

					caso 1:
					Escreva("Desafiado ganhou: ", desafiando.getNome())
					desafiando.ganharLuta()
					desafiante.perderLuta()
					pare

					caso 2:
					Escreva("desafiante ganhou: ", desafiante.getNome())
					desafiante.ganharLuta()
					desafiando.perderLuta()

					caso contrario:
					escreva("Opção inválida")
				}
				
			}senao
			{
				Escreva("Luta nao pode acontecer")
			}
		}
		
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 5058; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */