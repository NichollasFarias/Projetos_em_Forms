using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEx04_33574
{
    public partial class frmEx04_33574 : Form
    {
        public frmEx04_33574()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtAll.Text = "";
            txtBase.Text = "";
            txtRes.Text = "";
            txtBase.Focus();
        }

        private void btmCal_Click(object sender, EventArgs e)
        {
            double val1, val2, R;
            try
            {
                val1 = double.Parse(txtAll.Text);
                val2 = double.Parse(txtBase.Text);
            }
            catch
            {
                MessageBox.Show("ERROR 404");
                Limpar();
                return;
            }
            R = val1 * val2 / 2;
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
                txtBase.Focus();
            }
        }
    }
}
