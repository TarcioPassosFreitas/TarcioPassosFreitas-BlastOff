algoritmo "Media"
// Função :  Media das notas e resultado aprovado ou reprovado
// Autor :
// Data : 08/04/2022
// Seção de Declarações 
var
      res : caracter
      n1, n2, n3, n4 : real
      media : real
inicio
// Seção de Comandos
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
