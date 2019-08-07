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
    public partial class Exerc5 : Form
    {
        public Exerc5()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            string nome = txtNomeFunc.Text;

            double salarioB = Convert.ToDouble(txtSalarioB.Text);
            double vendaM = Convert.ToDouble(txtVendas.Text);

            double calcVenda = salarioB + (vendaM * 0.10);

            MessageBox.Show("Funcionário: " + txtNomeFunc.Text + "\n"
                            + "Salario base: " + txtSalarioB.Text + "\n"
                            + "Venda Total do Mês: " + txtVendas.Text + "\n"
                            + "Total Salário mais bonificação: " + calcVenda + "\n");

            txtNomeFunc.Text = string.Empty;
            txtSalarioB.Text = string.Empty;
            txtVendas.Text = string.Empty;

        }
    }
}
