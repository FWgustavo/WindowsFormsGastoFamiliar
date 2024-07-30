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

        private void grbGastos_Enter(object sender, EventArgs e)
        {
            double energia = double.Parse(txtEnergia.Text);
            double agua = double.Parse(txtAgua.Text);
            double tv = double.Parse(txtTV.Text);
            double alimento = double.Parse(txtAlimento.Text);
            double outros = double.Parse(txtOutros.Text);

            
        }
    }
}
