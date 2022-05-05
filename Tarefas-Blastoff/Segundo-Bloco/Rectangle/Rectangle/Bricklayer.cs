using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Bricklayer
    {
        private int NumberOfFloors; //quantidade de pisos
        private int NumberBaseBoardLenght; //quantidade de rodapés
        private int NumberBaseBoardWidth; //quantidade de rodapés

        private double FooterSize; //tamanho do rodapé desejado
        private int quantidaderodapepiso;

        private ModelRetangle AreaPiso;
        private ModelRetangle AreaTotal;


        public Bricklayer(ModelRetangle areaPiso, ModelRetangle areaTotal, double footerSize)
        {
            this.FooterSize = footerSize;
            this.AreaPiso = areaPiso;
            this.AreaTotal = areaTotal;
        }
        public void MethodNumberOfFloors()
        {
            NumberOfFloors = (int)Math.Ceiling((AreaTotal.CalculateArea() / AreaPiso.CalculateArea()));
            Console.WriteLine($"A quantidade de pisos é {NumberOfFloors} unidades.");
        }

        public void MethodNumberBaseBoard()
        {
               quantidaderodapepiso = (int)Math.Floor(AreaPiso.GetWidth() / FooterSize);

               NumberBaseBoardLenght = (int)(2 *(Math.Ceiling((AreaTotal.GetLenght() / AreaPiso.GetLenght()))));
               NumberBaseBoardWidth = (int)(2 * (Math.Ceiling((AreaTotal.GetWidth() / AreaPiso.GetWidth()))));

               NumberBaseBoardLenght = (NumberBaseBoardLenght / quantidaderodapepiso);
               NumberBaseBoardWidth = (NumberBaseBoardWidth / quantidaderodapepiso);

               Console.WriteLine($"A quantidade de pisos necessárias para o rodapé são {NumberBaseBoardLenght + NumberBaseBoardWidth} unidades. " +
                   $"A quantidade de rodapés é de {(quantidaderodapepiso * NumberBaseBoardLenght) + (quantidaderodapepiso * NumberBaseBoardWidth)} unidades.");
        }






    }
}
