using System;
using ClosedXML.Excel;

namespace LendoPlanilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abrir arquivo
            var wb = new XLWorkbook(@"Teste1.xlsx");
            var planilha = wb.Worksheets.First(w => w.Name == "Planilha1");
            var totalLinhas = planilha.Rows().Count() - 1;
            var auxiliar = totalLinhas;

            Console.WriteLine(totalLinhas);
            
            for (int i = 2; i <= (auxiliar + 1); i++)
            {
                if (planilha.Cell($"A{i}").Value.Equals(""))
                {
                    Console.WriteLine("lalala");
                    totalLinhas--;
                }
            }
            

                
            Console.WriteLine(totalLinhas);

            var rand = new Random();
            var valor = rand.Next(2, totalLinhas);
            Console.WriteLine(valor);
            var sorteado = planilha.Cell($"A{valor}").Value.ToString();
            Console.WriteLine(sorteado);

            bool vazio;
            for(int i = valor; i < (totalLinhas + 2); i++)
            {
                planilha.Cell($"A{i}").Value = planilha.Cell($"A{i + 1}").Value;
            }
            wb.Save();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sample Sheet");
                worksheet.Cell("A1").Value = "Hello World!";
                worksheet.Cell("A2").FormulaA1 = "=MID(A1, 7, 5)";
                workbook.SaveAs("HelloWorld.xlsx");
            }








        }
    }
}
