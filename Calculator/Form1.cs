using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value, num1, num2;
        int selection = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsRakamlar(object sender, EventArgs e)
        {
            if (rTxtDisplay.Text == "0")
            {
                rTxtDisplay.Text = "";
            }
            rTxtDisplay.Text = rTxtDisplay.Text + ((Button)sender).Text;
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(rTxtDisplay.Text);
            selection = 1;
            rTxtDisplay.Text = "0";
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(rTxtDisplay.Text);
            selection = 2;
            rTxtDisplay.Text = "0";
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(rTxtDisplay.Text);
            selection = 3;
            rTxtDisplay.Text = "0";
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(rTxtDisplay.Text);
            selection = 4;
            rTxtDisplay.Text = "0";
        }
        private void btnEsittir_Click_2(object sender, EventArgs e)
        {
            num2 = double.Parse(rTxtDisplay.Text);

            if (selection == 1) // toplama
            {
                value = num1 + num2;
            }
            rTxtDisplay.Text = value.ToString();

            if (selection == 2) // fark
            {
                value = num1 - num2;
            }
            rTxtDisplay.Text = value.ToString();

            if (selection == 3) // multi
            {
                value = num1 * num2;
            }
            rTxtDisplay.Text = value.ToString();

            if (selection == 4) // bolum
            {
                value = num1 / num2;
            }
            rTxtDisplay.Text = value.ToString();
        }

        private void btnArtiVeEksi_Click(object sender, EventArgs e)
        {
            if (rTxtDisplay.Text != "0")
            {
                if (rTxtDisplay.Text.StartsWith("-"))
                {
                    rTxtDisplay.Text = rTxtDisplay.Text.Substring(1);
                }
                else if (double.Parse(rTxtDisplay.Text) > 0)
                {
                    rTxtDisplay.Text = "-" + rTxtDisplay.Text;
                }
            }
        }

        private void btnNokta_Click(object sender, EventArgs e)
        {
            if (rTxtDisplay.Text.IndexOf(",") < 0)
            {
                rTxtDisplay.Text += ",";
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            rTxtDisplay.Text = "0";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            rTxtDisplay.Text = rTxtDisplay.Text.Substring(0, rTxtDisplay.Text.Length - 1);
            if (rTxtDisplay.Text.Length == 0)
            {
                rTxtDisplay.Text = "0";
            }
        }
    }
}
