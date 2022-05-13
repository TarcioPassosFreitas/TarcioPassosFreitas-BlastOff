using ClosedXML.Excel;
namespace Sortear
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }
    }
}