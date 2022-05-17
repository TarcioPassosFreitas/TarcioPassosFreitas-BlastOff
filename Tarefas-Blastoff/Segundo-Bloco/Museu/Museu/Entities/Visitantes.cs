using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu.Entities
{
    internal class Visitantes
    {
        private string Nome;
        private string Cpf;
        private DateTime DataNascimento;
        private byte CodTema;

        public static byte VINTAGE = 1;
        public static byte NUMISMATICA = 2;
        public static byte HISTORIA_DA_MUSICA = 3;
        public static byte PINTURAS = 4;
        public static byte ESCULTURA = 5;

        private int Vintage_itens = 135;
        private int Numismatica_itens = 300;
        private int Historia_da_Musica_itens = 67;
        private int Pintura_itens = 72;
        private int Esculturas_itens = 46;

        public Visitantes(string nome, string cpf, DateTime dataNascimento, byte codTema)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataNascimento = dataNascimento;
            this.CodTema = codTema;
        }

        public void QuantosItensExpostos()
        {
            int total = Vintage_itens + Numismatica_itens + Historia_da_Musica_itens + Pintura_itens + Esculturas_itens;
            Console.WriteLine($"Ao todo, no Museu, temos {total} unidades.");
        }


    }
}
