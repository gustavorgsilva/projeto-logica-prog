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
    public partial class FrmMininoEMaximo : Form
    {

        double n1, n2, n3, menor, maior;

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMininoEMaximo minEMaximo = new FrmMininoEMaximo();
            FrmMenu menu = new FrmMenu();
            this.Hide();
            menu.Show();
        }

        public FrmMininoEMaximo()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            n3 = int.Parse(txtNum3.Text);

            maior = 0;
            menor = 0;

            if(n1 > n2 || n3 > n2)
            {
              if(n1 > n3)
                {
                    maior = n1;
                } else
                {
                    maior = n3;
                }
            } else
            {
                maior = n2;
            }

            if (n1 < n2 || n3 < n2)
            {
                if (n1 < n3)
                {
                    menor = n1;
                } else
                {
                    menor = n3;
                }
            } else
            {
                menor = n2;
            }

            lbMaior.Text = maior.ToString();

            lbMenor.Text = menor.ToString();

            lbMenor.Visible = true;
            lbMaior.Visible = true;

        }
    }
}
