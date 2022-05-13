using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Media;

namespace Sortear
{
    
    public partial class Sorteados : Form
    {
        private SoundPlayer Player = new SoundPlayer();
        public Sorteio Sorteio = new Sorteio();
        public Sorteados()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Player.Stop();
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        public void ListaSorteados(string sorteados)
        {
            string path = @"SorteadosDoAno.txt";
            if (!File.Exists(path))
            {
                
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(sorteados);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(sorteados);
                }

                

                
                




            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

            if (!File.Exists(@"SorteadosDoAno.txt"))
            {
                this.textsorteados.Text = "Ninguém foi sorteado até agora.";
            }
            else
            {
                foreach (string line in System.IO.File.ReadLines(@"SorteadosDoAno.txt"))
                {
                    this.textsorteados.Text += line;
                    this.textsorteados.Text += Environment.NewLine;
                }
            }
                
            
        }

        private void Sorteados_Load(object sender, EventArgs e)
        {

        }
    }
}
