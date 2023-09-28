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
    public partial class frmEx02_33574 : Form
    {
        private void Limpar()
        {
            txtVal1.Text = "";
            txtVal2.Text = "";
            txtRes.Text = "";
            labRes.Text = "";
            txtVal1.Focus();
        }
        public frmEx02_33574()
        {
            InitializeComponent();
        }

        private void btmLimp_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btmSai_Click(object sender, EventArgs e)
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

        private void btmCal_Click(object sender, EventArgs e)
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
            R = val1 / (val2 * val2);
            txtRes.Text = R.ToString();

            if (rdMulher.Checked == true)
            {
                if (R < 19.1)
            {
                labRes.Text = "Você está abaixo do peso";
            }
            else
            {
                if (R > 19.1 && R < 25.8)
                {
                     labRes.Text = "Você está no peso normal";
                }
                else
                {
                    if (R > 25.8 && R < 27.3)
                    {
                        labRes.Text = "Você está marginalmente acima do peso";
                    }
                    else
                    {
                        if (R > 27.3 && R < 32.3)
                        {
                            labRes.Text = "Você está acima do peso";
                        }
                        else
                        {
                            labRes.Text = "Você está Obesa";
                        }
                    }
                }
            }
            }
            if (rdHomem.Checked == true)
            {
                if (R < 20.7)
                {
                    labRes.Text = "Você está abaixo do peso";
                }
                else
                {
                    if (R > 20.7 && R < 26.4)
                    {
                        labRes.Text = "Você está no peso normal";
                    }
                    else
                    {
                        if (R > 26.4 && R < 27.8)
                        {
                            labRes.Text = "Você está marginalmente acima do peso";
                        }
                        else
                        {
                            if (R > 27.8 && R < 31.1)
                            {
                                labRes.Text = "Você está acima do peso";
                            }
                            else
                            {
                                labRes.Text = "Você está Obeso";
                            }
                        }
                    }
                }
            }

        }


    }
}
