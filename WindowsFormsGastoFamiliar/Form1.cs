using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGastoFamiliar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double renda = double.Parse((txtRenda.Text));
            double energia = double.Parse(txtEnergia.Text);
            double agua = double.Parse(txtAgua.Text);
            double tv = double.Parse(txtTV.Text);
            double alimento = double.Parse(txtAlimento.Text);
            double outros = double.Parse(txtOutros.Text);
            double gastos = energia + agua + tv + alimento + outros;
            double resultado = renda - gastos;

            lblGastos.Text = gastos.ToString();
            lblSaldo.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAgua.Clear();
            txtAlimento.Clear();
            txtOutros.Clear();
            txtRenda.Clear();
            txtEnergia.Clear();
            txtTV.Clear();
            lblGastos.Text = "0";
            lblSaldo.Text = "0";

        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
