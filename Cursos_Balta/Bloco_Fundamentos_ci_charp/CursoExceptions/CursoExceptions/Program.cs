using System;

namespace CursoExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try //tente
            {
                // for(var index = 0; index < 10; index++)
                // {
                // // System.IndexOutOfRangeException = tipo da exceção
                // System.Console.WriteLine(arr[index]);
                // }

                Cadastrar("sndijsnfisfjnds");

            }
            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex.InnerException);
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("Não encontrei o índice na lista");
            }
            catch (ArgumentNullException ex) //Exceção Específica
            {
                System.Console.WriteLine(ex.InnerException);
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("Falha ao cadastrar texto");
            }
            catch (MinhaException ex)
            {
                System.Console.WriteLine(ex.InnerException);
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.QuandoAconteceu);
                System.Console.WriteLine("Exceção customizada");
            }
            catch (Exception ex) //pegar. Só colocar o ex, se for usar.
            {
                //os mais utilizados no dia-a-dia éo innerException e o Message
                System.Console.WriteLine(ex.InnerException);
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("ops, algo deu errado!");
            }
            finally //Finalmente
            {
                System.Console.WriteLine("Chegou ao fim!");
                //Bem utilizado para fechar o banco de dados, independente de erro ou não
                //e fechar arquivo também, independente de erro ou não
            }


        }

        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                //throw new Exception("O texto não pode ser nulo ou vazio");
                // throw new ArgumentNullException("O texto não pode ser nulo ou vazio"); //Exceção genérica
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }

            public DateTime QuandoAconteceu { get; set; }
        }
    }
}
