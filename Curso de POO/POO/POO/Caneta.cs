using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Caneta
    {
        private String modelo;
        private String ponta;

        public Caneta(String modelo, String ponta)
        {
            this.modelo = modelo;
            this.ponta = ponta;
        }

        public String getModelo()
        {
            return this.modelo;
        }

        public void setModelo(String modelo)
        {
            this.modelo=modelo;
        }

        public String getPonta()
        {
            return this.ponta;
        }

        public void setPonta(String ponta)
        {
            this.ponta = ponta;
        }




    }
}
