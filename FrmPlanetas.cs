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
    public partial class FrmPlanetas : Form
    {
        public FrmPlanetas()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmPlanetas planetas = new FrmPlanetas();
            FrmMenu menu = new FrmMenu();
            this.Hide();
            menu.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Definir as Entradas

            double peso, gravidade = 1, total;
            string planeta = "na Terra";

            peso = double.Parse(txb_Peso.Text);

            if (rb_Mercurio.Checked)
            {
                gravidade = 0.37;
                planeta = "em Mercúrio";
            }

            else if (rb_Venus.Checked)
            {
                gravidade = 0.88;
                planeta = "em Vênus";
            }

            else if (rb_Marte.Checked)
            {
                gravidade = 0.38;
                planeta = "em Marte";
            }
            else if (rb_Jupiter.Checked)
            {
                gravidade = 2.64;
                planeta = "em Júpiter";
            }
            else if (rb_Saturno.Checked)
            {
                gravidade = 1.15;
                planeta = "em Saturno";
            }
            else if (rb_Urano.Checked)
            {
                gravidade = 1.17;
                planeta = "em Urano";
            }
            else
            {
                //Caixa de mensagem onde informa erro caso a pessoa escolha apenas o peso sem informar o planeta.
                MessageBox.Show("Por favor selecione um planeta. ", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Application.Restart();
            }


            total = peso * gravidade;

            //Caixa de mensagem onde informa o planeta escolhido e o peso convertido.
            MessageBox.Show("Seu Peso " + planeta + " seria de: " + total + "kg.", "Peso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }  
}
