using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortear
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sorteio sorteios = new Sorteio();
            this.Hide();
            sorteios.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sorteados sorteados = new Sorteados();
            this.Hide();
            sorteados.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
