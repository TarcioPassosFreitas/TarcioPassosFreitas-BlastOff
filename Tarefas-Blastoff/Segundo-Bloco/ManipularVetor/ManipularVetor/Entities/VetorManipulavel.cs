using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipularVetor.Entities
{
    internal class VetorManipulavel
    {
        private float[] vetor = new float[5];
        private Random random = new Random();

        public VetorManipulavel()
        {
        }

        public float[] GetVetor()
        {
            return vetor;
        }

        public void GerarVetorAleatorio()
        {
            for(int i = 0; i < 5; i++)
            {
                vetor[i] = (float)random.NextDouble() * 100;
            }
        }

        public void PrintValoresVetor()
        {
            for(var i = 0; i < 5; i++)
            {
                Console.WriteLine($"{vetor[i]:F2}");
            }
        }

        public void TruncarValores()
        {
            for( var i = 0; i < 5; i++)
            {
                Console.WriteLine(Math.Truncate(vetor[i]));
            }
        }

        public void MultipliqueVetor(int valor)
        {
            for(var i = 0; i < 5; i++)
            {
                vetor[i] = vetor[i] * valor;
            }
        }
    }
}
