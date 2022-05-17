using Astronomia.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomia.Entities
{
    internal class CorpoCeleste
    {
        private double Massa;
        private double Tamanho;
        private Tipos Tipo;
        private string Nome;

        public CorpoCeleste()
        {

        }
        public CorpoCeleste(double massa, double tamanho, Tipos tipo, string nome)
        {
            this.Massa = massa;
            this.Tamanho = tamanho;
            this.Tipo = tipo;
            this.Nome = nome;
        }
        public double GetMassa()
        {
            return Massa;
        }

        public double GetTamanho()
        {
            return Tamanho;
        }

        public Tipos GetTipo()
        {
            return Tipo;
        }

        public string GetNome()
        {
            return Nome;
        }

        public double ValorMassaNebulosa(double massa)
        {
            return massa * 1.989000000000000000000000000000000;
            
        }

        public double ValorTamanhoNebulosa(double tamanho)
        {
            return tamanho * 9460536068.016;
        }
    }
}
