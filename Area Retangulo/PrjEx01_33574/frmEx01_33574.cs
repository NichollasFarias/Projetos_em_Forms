using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEx01_33574
{
    public partial class frmEx01_33574 : Form
    {
        public frmEx01_33574()
        {
            InitializeComponent();
        }

        private void btmCalc_Click(object sender, EventArgs e)
        {
            double val1, val2, R;
            try
            {
                val1 = double.Parse(txtbase.Text);
                val2 = double.Parse(txtaltura.Text);
            }
            catch
            {
                MessageBox.Show("ERROR 404");
                Limpar();
                return;
            }
            R = val1 * val2;
            txtres.Text = R.ToString();
        }

        private void Limpar()
        {
            txtaltura.Text = "";
            txtbase.Text = "";
            txtres.Text = "";
            txtbase.Focus();
        }

        private void btmLimp_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btmSai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Calculadora de Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==DialogResult.Yes)
            {
                if (MessageBox.Show("Você realmente quer sair? ;-;", "Calculadora de Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==DialogResult.Yes)
                {
                    MessageBox.Show("Obrigado por usar esse programa.");
                    Close();
                }
            }
            else
            {
                txtbase.Focus();
            }
        }
    }
}
