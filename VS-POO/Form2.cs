using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_POO
{
    public partial class frmcomb : Form
    {
        public frmcomb()
        {
            InitializeComponent();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            char comb;
            double vt, l;

            comb = Convert.ToChar(txtcomb.Text);
            l = Convert.ToDouble(txtquant.Text);


            if (comb == 'A')
            {
                if (l <= 20)
                {
                    vt = l * (4.90 * 3) / 100;
                    txtresult.Text = "R$" + vt;
                }
                else
                {
                    vt = l * (4.90 * 50) / 100;
                    txtresult.Text = "R$" + vt;

                }


            }
            else if (comb == 'G')
            {
                if (l <= 20)
                {
                    vt = l * (5.50 * 4) / 100;
                    txtresult.Text = "R$" + vt;
                }
                else
                {
                    vt = l * (5.50 * 6) / 100;
                    txtresult.Text = "R$" + vt;
                }
            }
            else
                txtresult.Text = "Código Inválido!";
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txtcomb.Clear();
            txtquant.Clear();
            txtresult.Clear();

            txtcomb.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu bg = new frmmenu();
            bg.Show();


        }
    }
}
