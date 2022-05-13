using ClosedXML.Excel;
using System.Media;
namespace Sortear
   
{
    public partial class Sorteio : Form
    {
        private SoundPlayer Player = new SoundPlayer();
        
        public Sorteio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Player.SoundLocation = @"somShenlong.wav";
                this.Player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não foi encontrado esse áudio");
                
            }

            Sorteio sorteio = new Sorteio();
            sorteio.BackgroundImage.Save(@"ceuEscuro.jpg");
            pictureBox1.Load(@"DesejoRealizado.gif");
            SortearMoletom();
        }

        public void SortearMoletom()
        {
            var wb = new XLWorkbook(@"Lista_de_funcionarios.xlsx");
            var planilha = wb.Worksheets.First(w => w.Name == "Planilha1");
            var totalLinhas = planilha.Rows().Count() - 1;

            VerificarTabela(totalLinhas, planilha, wb);
        }

        public void VerificarTabela(int totalLinhas,IXLWorksheet planilha, XLWorkbook wb)
        {
            var auxiliar = totalLinhas;
            for (int i = 2; i <= (auxiliar + 1); i++)
            {
                if (planilha.Cell($"A{i}").Value.Equals(""))
                {
                    totalLinhas--;
                }
            }
            QuemFoiSorteado(totalLinhas, planilha, wb);
        }

        public void QuemFoiSorteado(int totalLinhas, IXLWorksheet planilha, XLWorkbook wb)
        {
            var rand = new Random();
            var valor = 2;
            if (totalLinhas < 2)
            {
                Application.Exit();
            }
            else
            {
                valor = rand.Next(2, totalLinhas);
            }
            
            var sorteado = planilha.Cell($"A{valor}").Value.ToString();
            textBox1.Text = sorteado;

            
            AtualizarTabela(valor, totalLinhas, planilha, wb, sorteado);
        }

        public void AtualizarTabela(int valor, int totalLinhas, IXLWorksheet planilha, XLWorkbook wb, string sorteado)
        {
            for (int i = valor; i < (totalLinhas + 2); i++)
            {
                planilha.Cell($"A{i}").Value = planilha.Cell($"A{i + 1}").Value;
            }
            wb.Save();

           
            Sorteados sorteados = new Sorteados();
            sorteados.ListaSorteados(sorteado);
            
        }

        

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Sorteio_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Player.Stop();
            Menu menu = new Menu();
            this.Hide(); //esconder o form anterior
            menu.Show(this);
        }
    }
}