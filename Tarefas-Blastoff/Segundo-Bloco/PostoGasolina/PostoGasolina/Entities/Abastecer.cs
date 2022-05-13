using PostoGasolina.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Entities
{
    internal class Abastecer
    {
        private TypePump tipoCombustivel;
        private double valorEmReais;
        private double quantosLitros;
        private 

        public Abastecer(TypePump tipoCombustivel, double valorEmReais)
        {
            this.tipoCombustivel = tipoCombustivel;
            this.valorEmReais = valorEmReais;
        }

        public Abastecer(TypePump tipoCombustivel, double quantosLitros)
        {
            this.tipoCombustivel = tipoCombustivel;
            this.quantosLitros = quantosLitros;
        }
    }
}
