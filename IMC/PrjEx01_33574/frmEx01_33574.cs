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
        private void Limpar()
        {
            txtVal1.Text = "";
            txtVal2.Text = "";
            txtR.Text = "";
            labRes.Text = "";
            txtVal1.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val1, val2, R;
            try
            {
                val1 = double.Parse(txtVal1.Text);
                val2 = double.Parse(txtVal2.Text);
            }
            catch
            {
                MessageBox.Show("ERROR 404");
                Limpar();
                txtVal1.Focus();
                return;
            }
            R = val1/(val2*val2);
            txtR.Text = R.ToString();

            if (R < 18.5)
            {
                labRes.Text = "Você está abaixo do peso";
            }
            else
            {
                if (R > 18.5 && R < 25)
                {
                     labRes.Text = "Você está no peso normal";
                }
                else
                {
                    if (R > 25 && R < 30)
                    {
                        labRes.Text = "Você está acima do peso";
                    }
                    else
                    {
                        labRes.Text = "Você está OBESO!";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "IMC", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("Você realmente quer sair? ☺", "IMC", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MessageBox.Show("Obrigado por usar esse programa ♥.");
                    Close();
                }
            }
            else
            {
                txtVal1.Focus();
            }
        }

    }
}
