using System;
using System.Text;

namespace CursoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Guid -> identificador único, gera um hash

            var id = Guid.NewGuid();
            id.ToString();
            //id = new Guid(""); //se passar vazio, vai dar um erro, tem que passar uma estrutura do tipo Guid
            //id = new Guid("a8380fda-412d-4091-8099-f4276dc778f7"); //vai aceitar por causa do tipo de estrutura que recebe
            //if(id == Guid.NewGuid())
            //id = new Guid(); //vem um hash todo zerado
            System.Console.WriteLine(id.ToString().Substring(0, 8));
            System.Console.WriteLine(id);

            //Interpolação
            var price = 10.2;
            //var price = true;
            //var price = 10.2 + 9; vai dar 19.2, isso é somar 
            //var texto = "o preço do produto é " + price + "apenas na promoção"; //isso é chamar a variável preço e concatenar, transformando o valor em string
            // var texto = string.Format("O preço do produto é {0} apenas na promoção", price); //formata uma string
            // var texto = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true); //formata uma string
            // var texto = string.Format("O preço do produto é {1} apenas na promoção {0}", price, true); //Muda a posição

            // var texto = $"O preço do produto é {price} apenas na promoção";
            // var texto = $@"O preço do produto
            //  é {price} apenas na promoção"; 
            //Esse @ é quando vc quer dar quebrade linha em uma string. Entende que só tem uma linha
            //quando tiver utilizando a formatação com $ pode tirar e colocar apenas o @ se não for usar interpolação, caso use, é só
            //colocar o $ seguido do @

            //var texto = $"O preço do produto \n é {price} apenas na promoção";
            //outra forma de dar a quebra de linha é o \n

            //Comparação de String

            // var texto = "Testando";
            var texto = "Esse texto é um teste";
            System.Console.WriteLine(texto.CompareTo("Testando")); //retorna um inteiro
            // 0 confirma que é igual. 1 confirma que não é igual
            System.Console.WriteLine(texto.CompareTo("testando"));  //retorna um inteiro

            System.Console.WriteLine(texto.Contains("teste")); // verifica se cotém parte de um texto ou o texto todo
            //nesse caso retorna true
            System.Console.WriteLine(texto.Contains("Teste"));
            //retorna false pois não tem teste com letra maiúscula
            System.Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); //ignora o sense case, a diferenciação de minúscula e maiúscula
            System.Console.WriteLine(texto.Contains(null)); //comparou com objeto inválido, retorna false

            //StartsWith/ EndsWith
            //meu texto começa com _____?
            //meu texto termina com _____?
            //lembrando que pode utilizar o StringComparison.(os métodos, são vários)

            System.Console.WriteLine(texto.StartsWith("Este"));
            System.Console.WriteLine(texto.StartsWith("este"));
            System.Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); //ignora seé maiúsculo ou minúsculo
            System.Console.WriteLine(texto.StartsWith("texto"));
            //vai retorna um booleano

            System.Console.WriteLine(texto.EndsWith("texto"));
            System.Console.WriteLine(texto.EndsWith("texto"));
            System.Console.WriteLine(texto.EndsWith("xpro"));
            //vai retornar um booleano

            //Equals
            //Verifica se o texto é igual ou não
            //tem quer ser o texto completo, exatamente igual
            //retorna um booleano
            System.Console.WriteLine(texto.Equals("Esse texto é um teste")); //true
            System.Console.WriteLine(texto.Equals("esse texto é um teste")); //false
            System.Console.WriteLine(texto.Equals("esse texto é um teste", StringComparison.OrdinalIgnoreCase)); //true
            //Esse equals não serve apenas para string
            //compara qualquer tipo de objeto do mesmo tipo
            var teste = 33;
            System.Console.WriteLine(teste.Equals(33)); //true


            //Indices
            //posição que está no array
            //começa do 0
            //10 carcters, começa com 0e termina com o 9
            System.Console.WriteLine(texto.IndexOf("é")); //ta na posição 11 da nossa string
            System.Console.WriteLine(texto.LastIndexOf("s")); //procura a letra s na última letra s

            //Métodos adicionais
            //ToUpper() colocar tudo para maiúsculo
            //ToLower() colocar tudo para minúsculo
            System.Console.WriteLine(texto.ToUpper());
            System.Console.WriteLine(texto.ToLower());
            System.Console.WriteLine(texto.Insert(5, "Aqui ")); //inserir texto ou caracter em uma posição
            System.Console.WriteLine(texto.Remove(5, 5)); //vai pedir o início e fim que deseja remover
            System.Console.WriteLine(texto.Length); //quantidade de carcters

            //Manipulando Strings
            System.Console.WriteLine(texto.Replace("Este", "isto")); //trocar uma string por outra
            System.Console.WriteLine(texto.Replace("e", "X")); //troca um e por x
            System.Console.WriteLine(texto.Replace("xxxxxxxxxxxxxxxxx", "X"));
            //colocar qualquer palavra que não existe. vai passar, não vai dar erro
            var divisao = texto.Split(" "); //pegar todo o texto e separar por espaço nesse caso, só passar a separação entre as aspas
            //divisao é uma lista de string após o split do texto
            System.Console.WriteLine(divisao[0]);
            System.Console.WriteLine(divisao[1]);
            System.Console.WriteLine(divisao[2]);
            System.Console.WriteLine(divisao[3]);

            //var resultado = texto.Substring(5, 5); //passa a posição que começa o corte até a posição final
            var resultado = texto.Substring(5, texto.LastIndexOf("o")); //pega da posição 5 até a última posição de "o"
            System.Console.WriteLine(resultado);

            texto = " Esse texto é um teste ";
            System.Console.WriteLine(texto.Trim()); //retira os espaçoes do início e do final

            //StringBuilder
            // utilizar pra ler de linha a linha
            var texto2 = new StringBuilder();
            texto2.Append("Esse texto é um teste");
            texto2.Append("é um teste ");
            texto2.Append("Este texto");
            texto2.Append("Este um teste");

            System.Console.WriteLine(texto); //converte automaticamente em string
            System.Console.WriteLine(texto.ToString()); //necessário usar, pois vários métodos não transforma em string, esse é do tipo StringBuilder
            










            System.Console.WriteLine(texto);








        }
    }
}
