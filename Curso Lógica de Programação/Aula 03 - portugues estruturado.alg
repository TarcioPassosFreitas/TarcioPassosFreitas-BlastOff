algoritmo "Media"
// Fun��o :  Media das notas e resultado aprovado ou reprovado
// Autor :
// Data : 08/04/2022
// Se��o de Declara��es 
var
      res : caracter
      n1, n2, n3, n4 : real
      media : real
inicio
// Se��o de Comandos
   Escreva ("Digite as quatro notas")
   leia (n1,n2,n3,n4)
   media <- ((n1 + n2 + n3 + n4) / 4 )
   se (media >= 7) entao
      res <- "Aprovado"
   senao
      resp <- "Reprovado"
   fimse
   escreva ("Resultado: ", res)
fimalgoritmo
