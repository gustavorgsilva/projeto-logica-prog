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
    public partial class FrmPartidasFutebol : Form
    {
        //declarando variáveis
        int[] golTime1 = new int[6];
        int[] golTime2 = new int[6];
        string[] times1 = new string[6] { "Grêmio", "Palmeiras,", "Santos", "Corinthians", "PontePreta", "Flamengo" };
        string[] times2 = new string[6] { "Juventude", "Internacional", "Botafogo", "Cruzeiro", "Vasco", "Atlético Mineiro" };
        Label[] resultados = new Label[6];
        int index;

        public FrmPartidasFutebol()
        {
            InitializeComponent();
        }
        public void PegarLabel()
        {
            resultados[0] = lblResult1;
            resultados[1] = lblResult2;
            resultados[2] = lblResult3;
            resultados[3] = lblResult4;
            resultados[4] = lblResult5;
            resultados[5] = lblResult6;
        }
        public void PegarGols()
        {
            golTime1[0] = int.Parse(txtTimeAVal1.Text);
            golTime1[1] = int.Parse(txtTimeAVal2.Text);
            golTime1[2] = int.Parse(txtTimeAVal3.Text);
            golTime1[3] = int.Parse(txtTimeAVal4.Text);
            golTime1[4] = int.Parse(txtTimeAVal5.Text);
            golTime1[5] = int.Parse(txtTimeAVal6.Text);
            golTime2[0] = int.Parse(txtTimeBVal1.Text);
            golTime2[1] = int.Parse(txtTimeBVal2.Text);
            golTime2[2] = int.Parse(txtTimeBVal3.Text);
            golTime2[3] = int.Parse(txtTimeBVal4.Text);
            golTime2[4] = int.Parse(txtTimeBVal5.Text);
            golTime1[5] = int.Parse(txtTimeBVal6.Text);
        }
        public void LabelsVisibilidadeTrue()
        {
            lblResult1.Visible = true;
            lblResult2.Visible = true;
            lblResult3.Visible = true;
            lblResult4.Visible = true;
            lblResult5.Visible = true;
            lblResult6.Visible = true;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            FrmPartidasFutebol futebol = new FrmPartidasFutebol();
            this.Hide();
            menu.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //definindo tratamento de exceção do algoritmo
            try
            {

                //criando condições encadeadas que são executadas quando todos os valores dos campos de textBox são preenchidos
                if (txtTimeAVal1.Text != "" && txtTimeAVal2.Text != "" && txtTimeAVal3.Text != "" && txtTimeAVal4.Text != "" && txtTimeAVal5.Text != "" && txtTimeAVal6.Text != ""
         && txtTimeBVal1.Text != "" && txtTimeBVal2.Text != "" && txtTimeBVal3.Text != "" && txtTimeBVal4.Text != "" && txtTimeBVal5.Text != "" && txtTimeBVal6.Text != "")
                {

                    //chamando duas funções que permitiram o array resultados receber as labels, o golTime1 e o golTime2 receberem os valores dos textBoxes para execução do código
                    PegarLabel();
                    PegarGols();
                    //definindo o loop de indexes que permitirá a busca dos valores dos arrays e efetuar as condições para exibição de dados nas respetivas labels
                    for (index = 0; index < times1.Length; index++)
                    {
                        if (golTime1[index] != golTime2[index])
                        {
                            if (golTime1[index] > golTime2[index])
                            {
                                resultados[index].Text = times1[index].ToString();
                            }
                            else
                            {
                                resultados[index].Text = times2[index].ToString();
                            }
                        }
                        else
                        {
                            resultados[index].Text = "Empate";
                        }
                    }
                    LabelsVisibilidadeTrue();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos para poder calcular os resultados dos jogos!", "Não foi possível calcular os resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro foi encontado durante a execução do programa: " + ex, "Erro desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
