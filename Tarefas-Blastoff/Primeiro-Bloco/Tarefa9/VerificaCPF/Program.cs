using System;
using System.Text.RegularExpressions;

namespace VerificaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            validaFormato();

        }

        static void validaFormato()
        {
            string cpf;
            cpf = Console.ReadLine();
            string regra = @"^([0-9]{3}.[0-9]{3}.[0-9]{3}-[0-9]{2})$"; //|^[0-9]{11}
            Regex regex = new Regex(regra);

            if (!regex.IsMatch(cpf))
            {
                validaFormato();
            }
            else
            {
                ValidarCPF(cpf);
            }

        }

        static void ValidarCPF(string cpf)
        {
            int digito;
            int divisor_aux = 0;
            int valor_aux = 0;
            int soma_aux = 0;
            char convert_aux;
            string cpf_aux = cpf;

            cpf_aux = cpf_aux.Replace("-", "");

            cpf_aux = cpf_aux.Replace(".", "");

            if (cpf_aux.Length != 11)
            {
                System.Console.WriteLine("tamanho do cpf:" + cpf_aux.Length);
                System.Console.WriteLine("CPF é inválido");
            }

            for (int i = 0; i < 9; i++) //aprovado
            {
                //System.Console.WriteLine(cpf_aux[i]);
                convert_aux = cpf_aux[i];
                valor_aux = (int)char.GetNumericValue(convert_aux);
                //System.Console.WriteLine(valor_aux + 30);
                valor_aux = valor_aux * (i + 1);
                //System.Console.WriteLine(valor_aux);
                soma_aux += valor_aux;
                //System.Console.WriteLine(soma_aux);
            }

            divisor_aux = (soma_aux % 11);
            //System.Console.WriteLine(divisor_aux);
            if (divisor_aux == 10) //aprovado
            {
                digito = 0;
            }
            else
            {
                digito = divisor_aux;
            }

            convert_aux = cpf_aux[9];
            valor_aux = (int)char.GetNumericValue(convert_aux);
            if (!(valor_aux == digito))
            {
                System.Console.WriteLine("CPF é inválido");
            }
            soma_aux = 0;
            for (int i = 0; i < 10; i++) //aprovado
            {

                //System.Console.WriteLine(cpf_aux[i]);
                convert_aux = cpf_aux[i];
                valor_aux = (int)char.GetNumericValue(convert_aux);
                //System.Console.WriteLine(valor_aux + 30);
                valor_aux = valor_aux * i;
                //System.Console.WriteLine(valor_aux);
                soma_aux += valor_aux;

            }
            //System.Console.WriteLine(soma_aux);

            divisor_aux = (soma_aux % 11);
            //System.Console.WriteLine(divisor_aux);
            if (divisor_aux == 10) //aprovado
            {
                digito = 0;
            }
            else
            {
                digito = divisor_aux;
            }

            convert_aux = cpf_aux[10];
            valor_aux = (int)char.GetNumericValue(convert_aux);
            //System.Console.WriteLine(valor_aux);
            if (!(valor_aux == digito))
            {
                System.Console.WriteLine("CPF é inválido");

            }
            else
            {
                System.Console.WriteLine("CPF Válido!");
            }


        }
    }
}
