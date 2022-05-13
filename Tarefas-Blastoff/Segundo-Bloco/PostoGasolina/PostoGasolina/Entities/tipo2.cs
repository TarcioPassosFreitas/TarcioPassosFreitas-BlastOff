using PostoGasolina.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Entities
{
    internal class tipo2
    {
        private TypePump tipoCombustivel;
        private double quantosLitros;

        public TypePump GetTypePump()
        {
            return this.tipoCombustivel;
        }

        public double GetValorLitro()
        {
            return this.quantosLitros;
        }
    }
}
