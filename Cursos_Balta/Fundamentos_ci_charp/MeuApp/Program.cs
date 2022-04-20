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

            //Alias: é um apelido que todo tipo no .NET
            //tem
            //por exemplo:
            //system,string tem o alas String
            // int idade = 25 Alias
            // Int32 idade =25 Tipo

            //Valores padrões
            //tentar acessar um objeto que tem valor nulo
            // int = > 0;
            // float => 0;
            // decimal => 0;
            // bool => false;
            // char => '\0';
            // string => "";

            //conversão de dados
            //conversão implícita
            //float valor = 25.8F;
            //int outro = 25;
            //valor = outro; conversão implícita

            //conversão explicita
            //int inteuro = 100;
            //uint inteiroSemSinal = (uint)inteiro; conversão explícita

            //Parse, sempre espera uma cadeia de caracters
            //int inteiro = int.Parse("100");

            //convert é uma classe. um objeto que converte uma string em outro tipo
            //permite converter vários tipos para um inteiropor exemplo
            //não é extensão como o parse e sim uma classe
            //int inteiro = Convert.ToInt32("100");

            //conversões
            int inteiro = 100;
            float real = 25.8f;

            //real = inteiro
            //real = inteiro;
            //inteiro = (int) real;
            //string valorReal = real.ToString();
            //inteiro = int.Parse(valorReal);
            //inteiro = Convert.ToInt32(real);  
            inteiro = Convert.ToInt32(real);


            System.Console.WriteLine(inteiro);
            System.Console.WriteLine(Convert.ToBoolean(1)); //qualquer número diferente de 0 é true
            System.Console.WriteLine(Convert.ToBoolean(0)); //é 0 é false
            System.Console.WriteLine(Convert.ToBoolean(255)); //qualquer número diferente de 0 é true

            //=================operadores===============================

            int soma = 25 + 22; //47
            int subtracao = 25 - 22; //3
            int multiplicacao = 25 * 22; //550 
            int divisao = 22 / 5; //4 - foi arredondado

            //int x = 2 + 2 * 2; // 6
            //int y = 2 + (2 * 2);  6
            //int z = (2 + 2) * 2;  8

            // int x = 0;
            // x += 5;
            // x -= 1;
            // x *= 10;
            // x /= 2;

            //int x = 25;
            // x == 0; false
            // x != 0; true
            // x > 0; true
            // x < 0; false
            // x <= 0; false
            // x >= 0; true

            // int x = 2;
            // x = 2 + 2;
            // x = 2 - 2;
            // x = 2 * 2;
            // x = 2 / 2;

            // double x = 2;
            // x = (2 + 2) * 2;

            // x = 75 - 23.8;

            // System.Console.WriteLine(x);

            // int x = 2;
            // x += 3;
            // x -= 3;
            // x *= 3;
            // x /= 3;
            // x++;
            // x--;
            // System.Console.WriteLine(x);

            // System.Console.WriteLine(x == 25);
            // System.Console.WriteLine(x != 25);
            // System.Console.WriteLine(x > 25);
            // System.Console.WriteLine(x < 25);
            // System.Console.WriteLine(x >= 25);
            // System.Console.WriteLine(x <= 25);

            //int x = 12;
            //bool entre = (x > 25) && (x < 40); false
            //bool ou = (x > 25) || (x < 40); true
            //bool negacao = !(x < 25); false

            /*
            if(25 == 32)
            {
                console.WriteLine("É igual");
            }
            console.WriteLine("Finalizou o programa");

            if(25 != 32)
            {
                console.WriteLine("É igual");
            }
            console.WriteLine("Finalizou o programa");

            if(25 != 32)
            {
                console.WriteLine("É diferente");
            }else
            {
                console.WriteLine("É igual");
            }
            console.WriteLine("Finalizou o programa");



            int idade = 18;
            int maioridade = 21;
            int idadeMaxima = 65;

            if(idade >= maioridade && idade < idadeMaxima)
            {
                console.WriteLine("É diferente");
            }else
            {
                console.WriteLine("É igual");
            }
            console.WriteLine("Finalizou o programa");



            if(idade >= maioridade || idade < idadeMaxima)
            {
                console.WriteLine("É diferente");
            }else
            {
                console.WriteLine("É igual");
            }
            console.WriteLine("Finalizou o programa");



            if(idade >= maioridade != idade < idadeMaxima)
            {
                console.WriteLine("É diferente");
            }else
            {
                console.WriteLine("É igual");
            }
            console.WriteLine("Finalizou o programa");



             if(idade >= maioridade)
            {
                console.WriteLine("É diferente");
            }else if(idade >=25)
            {
                console.WriteLine("É igual");
            }else if(idade >= 32)
            {
                console.WriteLine("É igual");
            }else if(idade >= 38)
            {
                console.WriteLine("É igual");
            }else
            {
                console.WriteLine("É igual");
            }
            console.WriteLine("Finalizou o programa");
            */

            // string valor = "andre";
            // switch (valor)
            // {
            //     case "joao": System.Console.WriteLine("Não é o cara"); break;
            //     case "marcelo": System.Console.WriteLine("Não é o cara"); break;
            //     case "andre": System.Console.WriteLine("É este!"); break;
            //     default: System.Console.WriteLine("Não encontrei"); break;

            // }

            // bool? valor2 = null;
            // switch (valor2)
            // {
            //     case true: System.Console.WriteLine("Verdadeiro"); break;
            //     case false: System.Console.WriteLine("Falso"); break;
            //     default: System.Console.WriteLine("Nulo"); break;
            // }

            // for(var i = 0; i <= 5; i++)
            //     System.Console.WriteLine(i);

            // for(var i = 1; i <= 5; i++)
            //     System.Console.WriteLine(i);

            // for(var i = 0; i < 5; i++){
            //     System.Console.WriteLine(i);
            // }

            // for(var i = 5; i >= 0; i--){
            //     System.Console.WriteLine(i);
            // }

            // var valor3 = 0;

            // while(valor3 <= 5){
            //     System.Console.WriteLine(valor3);
            //     valor3++;
            // }

            // while(true){
            //     System.Console.WriteLine(valor3);
            //     valor3++;
            // }


            // var valor = 0;
            // do
            // {
            //     System.Console.WriteLine("Teste");
            //     valor++;
            // } while (valor < 5);


            // var texto = "Testando";
            // Console.WriteLine(texto);
            // Console.WriteLine("Hello world!");

            var nome = RetornaNome("André", "Baltieri", 48);

            System.Console.WriteLine(nome);

            //============Heap e Stack==================
            //A memória é dividida em duas partes, Heap e Stack
            //Heap armazena os dados
            //Stack armazena as referências para os dados

            //values types

            int x = 25;
            int y = x; //y é uma cópia de x
            System.Console.WriteLine(x); //25
            System.Console.WriteLine(y); //25

            x = 32; //somente x foi alterado
            System.Console.WriteLine(x); //32
            System.Console.WriteLine(y); //25


            //Outro exemplo

            var arr = new string[2];
            arr[0] = "Item 1";
            var arr2 = arr; //não cria uma cópia

            System.Console.WriteLine(arr[0]);
            System.Console.WriteLine(arr2[0]);

            //altera as duas listas
            arr[0] = "Item Alterado";
            System.Console.WriteLine(arr[0]);
            System.Console.WriteLine(arr2[0]);

            //=============Structs==============
            // Product mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);

            // mouse.Id = 55;

            // System.Console.WriteLine(mouse.Id);
            // System.Console.WriteLine(mouse.Name);
            // System.Console.WriteLine(mouse.Price);

            //================Enumeradores==============
            Product mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);

            mouse.Id = 55;

            System.Console.WriteLine(mouse.Id);
            System.Console.WriteLine(mouse.Name);
            System.Console.WriteLine(mouse.Price);
            System.Console.WriteLine(mouse.Type);
            System.Console.WriteLine((int)mouse.Type);

        }

        enum EProductType
        {
            Product = 1,
            Service = 2
        }

        struct Product
        {

            public Product(int id, string name, double price, EProductType type)
            {
                Id = id;
                Name = name;
                Price = price;
                Type = type;

            }
            public int Id;
            public string Name;
            public double Price;

            public EProductType Type;

            public double PriceInDolar(double dolar)
            {
                return Price * dolar;
            }
        }

        static void MeuMetodo(String parametro)
        {
            System.Console.WriteLine(parametro);
        }

        static string RetornaNome(
            string nome,
            string sobrenome,
            int idade = 34,
            bool teste = false,
            double novo = 33.42)
        {
            return nome + " " + sobrenome + " tem " + idade.ToString();
        }


    }


}
