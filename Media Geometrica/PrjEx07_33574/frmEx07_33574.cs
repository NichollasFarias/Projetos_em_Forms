using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEx07_33574
{
    public partial class frmEx07_33574 : Form
    {
        public frmEx07_33574()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            txtVal1.Text = "";
            txtVal2.Text = "";
            txtRes.Text = "";
            txtVal1.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val1,val2, R, R2;
            try
            {
                val1 = double.Parse(txtVal1.Text);
                val2 = double.Parse(txtVal2.Text);
            }
            catch
            {
                MessageBox.Show("ERROR 404");
                Limpar();
                return;
            }
            R = val1 * val2;
            R2 = Math.Sqrt(R);
            txtRes.Text = R2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
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
                Limpar();
                txtVal1.Focus();
            }
        }
    }
}
