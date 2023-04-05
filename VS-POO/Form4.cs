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
    public partial class frmvote : Form
    {
        double cj, cm, ct, g;
        int mv, v;
       
        public frmvote()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblmj_Click(object sender, EventArgs e)
        {

        }

        private void frmvote_Load(object sender, EventArgs e)
        {

        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txtvoto.Clear();
            txtwinner.Clear();
            txtporcent.Clear();
            txttotal.Clear();

            txtvoto.Focus();
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu pg = new frmmenu();
            pg.Show();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            

            v = Convert.ToInt32(txtvoto.Text);
            mv = 0;
            cj = 0;
            cm = 0;
            ct = 0;
            do
            {
                if (v == 1)
                {
                    cj++;
                    txtvoto.Clear();
                }
                else if (v == 2)
                {
                    cm++;
                    txtvoto.Clear();
                }
                else if (v == 3)
                {
                    ct++;
                    txtvoto.Clear();
                }
                else
                {
                    txtvoto.Clear();
                    txtvoto.Text = "Inválido!";
                }
                mv++;


            } while (v == 0);
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (cj > cm && cj > ct)
            {
                g = (cj * 100) / mv;
                txtwinner.Text = "José da Silva!";
                txtporcent.Text = "" + g + "%";
                txttotal.Text = mv.ToString();
            }
            else if (cm > cj && cm > ct)
            {
                g = (cm * 100) / mv;
                txtwinner.Text = "Maria Juruma!";
                txtporcent.Text = "" + g + "%";
                txttotal.Text = mv.ToString();
            }
            else if (ct > cj && ct > cm)
            {
                g = (ct * 100) / mv;
                txtwinner.Text = "João Tapioca!";
                txtporcent.Text = "" + g + "%";
                txttotal.Text = mv.ToString();
            }
            else
                txtwinner.Text = "Embate!";
        }
    }
}
