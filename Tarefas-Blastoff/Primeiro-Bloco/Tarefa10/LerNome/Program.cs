using System;
using System.Text.RegularExpressions;

namespace LerNome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            validarNome();


        }

        static void validarNome()
        {
            string regra = @"^[A-ZÇÉÈÊÚÙÛÍÌÎÓÒÔÕÁÀÂÃ][a-zçéèêúùûíìîóòôõáàâã]+( [A-ZÇÉÈÊÚÙÛÍÌÎÓÒÔÕÁÀÂÃ][a-zçéèêúùûíìîóòôõáàâã]+)+";
            Regex regex = new Regex(regra);
            string name;
            name = Console.ReadLine();
            if (regex.IsMatch(name))
            {
                RegraNegocio(name);
            }
            else
            {
                validarNome();
            }
        }

        static void RegraNegocio(string name)
        {

            System.Console.WriteLine($"Nome com todas as letras Maiúsculas {name.ToUpper()}");
            System.Console.WriteLine($"Nome com todas as letras Minúsculas {name.ToLower()}");
            string nome_sem_espaco = Regex.Replace(name, " ", "");
            System.Console.WriteLine($"Quantas letras ao todo (Sem considerar espaços) {nome_sem_espaco.Length}");
            string[] list = name.Split(' ');
            int tamanho = list[0].Length;
            System.Console.WriteLine($"Quantas letras têm o primeiro nome {tamanho}");
        }
    }
}