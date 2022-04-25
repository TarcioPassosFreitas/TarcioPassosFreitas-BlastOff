using System;
using System.Globalization;

namespace CursoMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //var valor = 10.25;
            //decimal valor = 10.25m; //decimal mais recomendado
            decimal valor = 10536.25m;
            System.Console.WriteLine(valor);
            System.Console.WriteLine(valor.ToString(
                "G", //especificador numérico, vai entender como um número
                     //"C", //formata com o padrão de moeda
                     //"E04", //quando o valor é muito grande, ele anexa o valor +001, por exemplo
                     //"F", //acaba trazendo uma precisão maior
                     //"N", //formata também, só o número aparece
                     //"P", //formata para porcentagem
                CultureInfo.CreateSpecificCulture("pt-BR")
            ));

            //Arredondar valores
            System.Console.WriteLine(Math.Round(valor)); //desconsidera tudo depois do ponto, arredondando o valor
            System.Console.WriteLine(Math.Ceiling(valor)); //ceiling é telhado, ou seja arredonda pra cima
            System.Console.WriteLine(Math.Floor(valor)); //Floor é chão, então arredonda pra baixo
        }
    }
}
