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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double val1, val2, R;
            try
            {
                val1 = double.Parse(txtVal01.Text);
                val2 = double.Parse(txtVal02.Text);
            }
            catch
            {
                MessageBox.Show("ERROR 404");
                Limpar();
                return;
            }
            R = val1 / val2;
            txtResultado.Text = R.ToString();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtVal01_TextChanged(object sender, EventArgs e)
        {

        }

        private void Soma_Click(object sender, EventArgs e)
        {
            double val1, val2, R;
            try
            {
                val1 = double.Parse(txtVal01.Text);
                val2 = double.Parse(txtVal02.Text);
            }
            catch 
            {
                MessageBox.Show("ERROR 404");
                Limpar();
                return;
            }
            R = val1 + val2;
            txtResultado.Text = R.ToString();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtVal01.Text = "";
            txtVal02.Text = "";
            txtResultado.Text = "";
            txtVal01.Focus();
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            double val1, val2, R;
            try
            {
                val1 = double.Parse(txtVal01.Text);
                val2 = double.Parse(txtVal02.Text);
            }
            catch
            {
                MessageBox.Show("ERROR 404");
                Limpar();
                return;
            }
            R = val1 - val2;
            txtResultado.Text = R.ToString();
        }

        private void btnmultiplicação_Click(object sender, EventArgs e)
        {
            double val1, val2, R;
            try
            {
                val1 = double.Parse(txtVal01.Text);
                val2 = double.Parse(txtVal02.Text);
            }
            catch
            {
                MessageBox.Show("ERROR 404");
                Limpar();
                return;
            }
            R = val1 * val2;
            txtResultado.Text = R.ToString();
        }
    }
}
