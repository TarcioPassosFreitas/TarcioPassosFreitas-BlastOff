using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class ModelRetangle
    {
        private double Length;
        private double Width;
        public ModelRetangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public void SetLenght(double length)
        {
            Length = length;
        }

        public void SetWidth(double width)
        {
            Width = width;
        }

        public double GetLenght()
        {
            return this.Length;
        }

        public double GetWidth()
        {
            return this.Width;
        }

        public double CalculateArea()
        {
            return (this.Length * this.Width);
        }

        public double CalculatePremeter()
        {
            return ((2 * this.Length) + (2 * this.Width));
        }



        //public double Validation()
        //{
        //    double value = 0;
        //    bool ItsPossible;
        //    ItsPossible = double.TryParse(Console.ReadLine(), out area);
        //    if(!ItsPossible)
        //    {
        //       return Validation();
        //    }
        //    else
        //    {
        //        return area;
        //    }
        //}


    }
}
