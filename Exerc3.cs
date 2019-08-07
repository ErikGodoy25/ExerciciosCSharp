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
    public partial class Exerc3 : Form
    {
        public Exerc3()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txtSalario.Text);
            double reajuste = Convert.ToDouble(txtPorcentagem.Text);

            double sum = (salario * reajuste) / 100;

            double Totalsalario = salario + sum;

            MessageBox.Show(string.Format(" Total a receber é : {0:0,0.00}", Totalsalario));

            txtSalario.Text = String.Empty;
            txtPorcentagem.Text = string.Empty;

        }
    }
}
