using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_POO
{
    public partial class frmtabu : Form
    {
        public frmtabu()
        {
            InitializeComponent();
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txttabu.Clear();

            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu tb = new frmmenu();
            tb.Show();
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            double n, c;
            int i;
            n = Convert.ToDouble(txtnum.Text);

            i = 1;
                while (i <= 10)
            {
                c = n * i;
                txttabu.Text = String.Concat(txttabu.Text," / " + c);
                i++;
            }
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            double n, c;
            int i;
            n = Convert.ToDouble(txtnum.Text);

            i = 1;
            do
            {
                c = n * i;
                txttabu.Text = String.Concat(txttabu.Text, " / " + c);
                i++;
            } while (i <=10);
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            double n, c;
            int i;
            n = Convert.ToDouble(txtnum.Text);

            for (i = 1; i <= 10; i++)
            {
                c = n * i;
                txttabu.Text = String.Concat(txttabu.Text, " / " + c);
            }
        }
    }
}
