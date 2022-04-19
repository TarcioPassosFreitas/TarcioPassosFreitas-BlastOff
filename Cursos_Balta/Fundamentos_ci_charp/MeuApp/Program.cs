//Importações
using System;
using MeuApp.teste;

//namespace
namespace MeuApp
{
    //classe principal do programa
    class Program
    {
        //Função principal do programa
        static void Main(string[] args)
        {
            //int idade; correto inicia com zero
            //int idade = 25; correto inicia com 25
            //var idade = 25; correto inicia com 25
            //var idade; //errado

            //const int IDADE_MINIMA; //correto inicia com zero
            //const int IDADE_MINIMA = 25; //correto inicia com 25
            //const var IDADE_MINIMA = 25; //errado
            //const IDADE_MINIMA; // errado

            //nomes reservados tb chamados de keywords

            //int internal = 25 Palavra internal é reservada

            //==========Comentários em c#:===========
            //Ctrl + k + c => comenta
            //Ctrl + k + u => descomenta
            /*comentário de bloco */

            //============Tipos primitivos=============
            //byte (8-bit) 0 até 255
            //sbyte (8-bit) -128 até 127 signed e usigned
            //valores com sinal como "-" por exemplo, são chamads de signed

            //short/ushort
            //int/uint
            //long/ulong

            // int idade = 25;
            // uint idade = -25;
            // short idade = 25;
            // ushort idade = -25;
            // long idade = 25;
            // ulong idade = -25;

            //float (notação F)
            //double
            //decimal (notação M)

            // var salario = 2.500;
            // double salarioSemestral = 22.00;
            // float salario = 2.500f;
            // decimal salarioAnual = 25.00m;

            //bool usuariojacadastrado = false;
            //bool pagamentojarecebido = true;
            //var usuarioexpirado = false;

            //char primeiraletra = 'C';
            // var segundaletra = 'D';

            //string primeiraletra = "C";
            //string texto = "meu texto";
            // var documento = "12345.99";

            //var idade = 25;
            //idade = "André"; em cima já foi definido
            //vantagem: 
            // IEnumerable<MeuTipoComplexo> aluno = new IEnumerable<MeuTipoComplexo>();
            // var aluno = new IEnumerable<MeuTipoComplexo>();

            //Object idade = 25 //será do tipo Object
            //Object nome = "André"; //será do tipo Object
            //object quantidade;
            //quantidade = 1;
            //quantidade = 2.5;
            //quantidade = "Teste";
            //Não aconselhado usar

            //Nulable tips
            //void = vazio
            //NUll = tipo com possibilidade de ser nulo
            //marcação é feita através de uma interrogração na frente do tipo
            //isso vai marcar como nulable

            //int? idade = null;
            // int? idade = 0;
            // Console.WriteLine(idade);
            // idade = null;
            // System.Console.WriteLine(idade);
            // idade = 25;
            // System.Console.WriteLine(idade);












            var texto = "Testando";
            Console.WriteLine(texto);
            Console.WriteLine("Hello world!");
        }
    }
}
