
using POO;
using System;

namespace Program
{
    class Program
    {
        static void Main(String[] args)
        {
            Caneta c = new Caneta("Hidrográfica", "redonda");
            Console.WriteLine(c.getModelo());
            c.setModelo("Esferográfica");
            Console.WriteLine(c.getModelo());
            Console.WriteLine(c.getPonta());
            c.setPonta("tinteiro");
            Console.WriteLine(c.getPonta());
        }
    }
}