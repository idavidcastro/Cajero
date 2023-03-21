using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajeroivancastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel10k.Visible = false;
            panel20k.Visible = false;
            panel50k.Visible = false;
            panel100k.Visible = false;
            lblmonto.Text = "";
            txtmonto.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblmonto.Text = 20000.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblmonto.Text = 100000.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblmonto.Text = 300000.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            lblmonto.Text = 1000000.ToString();
            //txtmonto.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblmonto.Text = 50000.ToString();
            txtmonto.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblmonto.Text = 200000.ToString();
            txtmonto.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblmonto.Text = 600000.ToString();
            txtmonto.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtmonto.Text = "";
            txtmonto.Visible = true;
            lblmonto.Text = "";
        }

        private void txtmonto_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtmonto_KeyUp(object sender, KeyEventArgs e)
        {
            lblmonto.Text = txtmonto.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int retiro;
            int aux = 0;
            int[] billetes;
            int[] cantidadBilletes;

            billetes = new int[5];
            cantidadBilletes = new int[5];


            billetes[1] = 10000;
            billetes[2] = 20000;
            billetes[3] = 50000;
            billetes[4] = 100000;

            if(lblmonto.Text=="")
            {
                retiro = 0;
                MessageBox.Show("¡Debe seleccionar un valor a retirar!");
            }
            else
            {
                retiro = int.Parse(lblmonto.Text);
            }


            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    if (aux <= retiro)
                    {
                        if ((retiro - aux) >= billetes[j])
                        {
                            cantidadBilletes[j] = cantidadBilletes[j] + 1;
                            aux = aux + billetes[j];
                        }
                        else
                        {
                            j = 4;
                        }

                        if (aux != retiro && i == 4)
                        {
                            i = 0;
                        }
                    }
                }
            }

            

            cant10.Text = cantidadBilletes[1].ToString();
            cant20.Text = cantidadBilletes[2].ToString();
            cant50.Text = cantidadBilletes[3].ToString();
            cant100.Text = cantidadBilletes[4].ToString();

            if (cant10.Text != "0")
            {
                panel10k.Visible = true;
            }
            if (cant20.Text != "0")
            {
                panel20k.Visible = true;
            }
            if (cant50.Text != "0")
            {
                panel50k.Visible = true;
            }
            if (cant100.Text != "0")
            {
                panel100k.Visible = true;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel10k.Visible = false;
            panel20k.Visible = false;
            panel50k.Visible = false;
            panel100k.Visible = false;
            lblmonto.Text = "";
            txtmonto.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
