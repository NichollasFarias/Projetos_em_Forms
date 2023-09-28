using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEx02_33574
{
    public partial class frmex02_33574 : Form
    {
        public frmex02_33574()
        {
            InitializeComponent();
        } 

        private void Limpar()
        {
            txtAres.Text = "";
            txtRes.Text = "";
            txtAres.Focus();
        }
        private void btmCal_Click(object sender, EventArgs e)
        {
            double val1, R;
            try
            {
                val1 = double.Parse(txtAres.Text);
            }
            catch
            {
                MessageBox.Show("ERROR 404");
                Limpar();
                return;
            }
            R = val1 * val1;
            txtRes.Text = R.ToString();
        }

        private void btmLimp_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btmSai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Calculadora de Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("Você realmente quer sair? ;-;", "Calculadora de Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MessageBox.Show("Obrigado por usar esse programa.");
                    Close();
                }
            }
            else
            {
                txtAres.Focus();
            }
        }

    }
}
