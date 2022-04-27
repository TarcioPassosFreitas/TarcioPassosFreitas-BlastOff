using System;
using System.Text.RegularExpressions;

namespace ValidaTelefone
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string regra1 = @"^([0-9]{4}-[0-9]{4}?)$";
            string regra2 = @"^([0-9]{4}-[0-9]{3}?)$";
            string regra3 = @"^([0-9]{8})$";
            string regra4 = @"^([0-9]{7})$";
            Regex regex1 = new Regex(regra1);
            Regex regex2 = new Regex(regra2);
            Regex regex3 = new Regex(regra3);
            Regex regex4 = new Regex(regra4);
            System.Console.WriteLine("Valida e corrige número de telefone");

            Validador(regex1, regex2, regex3, regex4);

        }

        static void Validador(Regex regex1, Regex regex2, Regex regex3, Regex regex4)
        {
            string telefone = "";
            System.Console.WriteLine("Digite o número do telefone no formato 0000-0000 ou 00000000");
            telefone = Console.ReadLine();
            if (!(regex1.IsMatch(telefone))) //para o formato 0000-0000
            {
                if (!(regex2.IsMatch(telefone)))
                {
                    if (!(regex3.IsMatch(telefone)))
                    {
                        if (!(regex4.IsMatch(telefone)))
                        {
                            Validador(regex1, regex2, regex3, regex4);
                        }
                        else
                        {
                            RegraDeNegocio2(telefone, regex4);
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Está no formato correto");

                    }

                }
                else
                {
                    RegraDeNegocio(telefone, regex2);
                }

            }
            else
            {
                System.Console.WriteLine("Está no formato correto");
            }
        }

        static void RegraDeNegocio(string telefone, Regex regex)
        {
            System.Console.WriteLine($"Telefone: {regex.Match(telefone).Groups[1]}");
            if ((telefone.Length - 1) == 7)
            {
                System.Console.WriteLine("Telefone possui 7 dígitos. Vou acrescentar o dígito três na frente.");
                telefone += "3";
                string telefoneReplace = Regex.Replace(telefone, "-", "");
                System.Console.WriteLine($"Telefone corrigido sem formatação: {telefoneReplace}");
                System.Console.WriteLine($"Telefone corrigido com formatação: {telefone}");

            }
        }
        static void RegraDeNegocio2(string telefone, Regex regex)
        {
            System.Console.WriteLine($"Telefone: {regex.Match(telefone).Groups[1]}");
            if (telefone.Length == 7)
            {
                System.Console.WriteLine("Telefone possui 7 dígitos. Vou acrescentar o dígito três na frente.");
                telefone += "3";
                string telefoneReplace = Regex.Replace(telefone, "-", "");
                System.Console.WriteLine($"Telefone corrigido sem formatação: {telefoneReplace}");
                System.Console.WriteLine($"Telefone corrigido com formatação: {telefone}");

            }
        }
    }
}
