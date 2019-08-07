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
    public partial class Exerc01 : Form
    {
        public Exerc01()
        {
            InitializeComponent();
        }

        private void Exerc01_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            var valor = Convert.ToInt32(txtNumero.Text);

            if (valor % 2==0)
            {
                MessageBox.Show($"{valor} o valor informado é divisível por ele mesmo");
            }
            else
            {
                MessageBox.Show($"{valor} O valor não é divisível por ele mesmo");
            }
        }
    }
}
