using System;

namespace CursoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            //int[] meuArray = new int[5];
            System.Console.WriteLine(meuArray[0]); //valor inicia com 0
            System.Console.WriteLine(meuArray[1]);
            System.Console.WriteLine(meuArray[2]);
            System.Console.WriteLine(meuArray[3]);
            System.Console.WriteLine(meuArray[4]);
            //System.Console.WriteLine(meuArray[5]); Vai dar erro, pois essa posição não existe no array

            meuArray[0] = 12;
            System.Console.WriteLine(meuArray[0]);
            //var meuArray = new int[5]{1,2,3,4,5}; poderia inicializar assim tb, passando os valores
            //var meuArray = new int[5]{23,42,54,67,99}; Outro exemplo de inicialização
            //var meuArray = new Teste[2]{new Teste(), new Teste()}; //pode fazer um array de qualquer tipo, até de struct
            //meuArray = new Teste(); //outra forma de inicializar
            //System.Console.WriteLine(meuArray[0].Id); Se tiver métodos na struct pode acessar dessa forma

            //meuArray.clone //faz um clone do array, passa o mesmo endereço de memória. usado quando quer
            //mudar as informações do array sem alterar o array original
            //meuArray.copyTo //pede valor e índice. copiar os valores de um array para outro
            //meuArray.length //tamanho do array

            System.Console.WriteLine(meuArray.Length);
            //Passar por todos os valores do array
            for (var index = 0; index < meuArray.Length; index++)
            {
                System.Console.WriteLine(meuArray[index]);
            }

            //Percorrer array usando o foreach
            //foreach significa para cada
            foreach (var item in meuArray)
            {
                System.Console.WriteLine(item);
            }

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 2579, Nome = "André" };

            foreach (var funcionario in funcionarios)
            {
                System.Console.WriteLine(funcionario.Id);
                System.Console.WriteLine(funcionario.Nome);
            }

            //Alterando os valores
            Console.Clear();
            var primeiro = new int[4];
            var segundo = new int[4];

            segundo[0] = primeiro[0];
            //primeiro.CopyTo(segundo, 0);

            primeiro[0] = 23;

            System.Console.WriteLine(segundo[0]);
        }

        struct Teste
        {
            public int Id { get; set; }
        }

        public struct Funcionario
        {
            public int Id { get; set; }

            public string Nome { get; set; }
        }
    }
}