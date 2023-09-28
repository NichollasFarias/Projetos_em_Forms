using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEx03_33574
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmCal_Click(object sender, EventArgs e)
        {
            double val1, R;
            try
            {
                val1 = double.Parse(txtDia.Text);
            }
            catch
            {
                MessageBox.Show("ERROR 404");
                Limpar();
                return;
            }
            R = val1 * val1 / 2;
            txtRes.Text = R.ToString();
        }

        private void Limpar()
        {
            txtDia.Text = "";
            txtRes.Text = "";
            txtDia.Focus();
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
                txtDia.Focus();
            }
        }



    }
}
