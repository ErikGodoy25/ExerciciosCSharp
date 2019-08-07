using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Exerc4 : Form
    {
        public Exerc4()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcViagem_Click(object sender, EventArgs e)
        {
            double aut = 12;
            double Dist, Litrs;
            double tempViagem = Convert.ToDouble(txtTempo.Text);
            double vlMedia = Convert.ToDouble(txtVelocidadeM.Text);

            Dist = vlMedia * tempViagem;

            Litrs = Dist / aut;

            MessageBox.Show("Tempo gasto: " + txtTempo.Text + "\n"
                    + "Velocidade Média: " + txtVelocidadeM.Text + "\n"
                    + "Distância Percorrida: " + Dist + "\n"
                    + "Litros Utilizados: " + Litrs + "\n"); 

            txtTempo.Text = string.Empty;
            txtVelocidadeM.Text = string.Empty;
               

        }

        private void TxtTempo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
