using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_formativa_senai
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maiorEMenorValorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            FrmMininoEMaximo minimoEMaximo = new FrmMininoEMaximo();
            this.Hide();
            minimoEMaximo.Show();
        }

        private void partidasDeFutebolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPartidasFutebol futebol = new FrmPartidasFutebol();
            FrmMenu frmMenu = new FrmMenu();
            this.Hide();
            futebol.Show();
        }

        private void calculadoraDePesoInterplanetáriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanetas planetas = new FrmPlanetas();
            FrmMenu menu = new FrmMenu();
            this.Hide();
            planetas.Show();
        }
    }
}
