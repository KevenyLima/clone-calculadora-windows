using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string equacao;
        string valor;
        string valor2 = "29";
        public Form1()
        {
        
            InitializeComponent();
        }
        private void cmd_igual_Click(object sender, EventArgs e)
        {
            string sinais = "-+/*";
            int indici = 0;
            string formula=label1.Text;
            foreach (char c in formula)
            {
                foreach (char s in sinais)
                {
                    if (c == s)
                    {
                        valor = formula.Substring(0, indici);
                        equacao = Convert.ToString(s);
                        valor2 = formula.Substring(indici + 1);
                    }
                }
                indici++;
            }
            resultado();
        }
        private void resultado()
        {
            listBox1.Items.Add(label1.Text);
            calculo novo = new calculo();
            label1.Text = Convert.ToString(novo.Calculadora(int.Parse(valor), int.Parse(valor2), equacao));
        }

        private void cmd_0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void cmd_1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void cmd_4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void cmd_5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void cmd_6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void cmd_7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void cmd_8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void cmd_9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void cmd_divisao_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "/";
        }

        private void cmd_multiplicar_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "*";
        }

        private void cmd_soma_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";
        }

        private void cmd_subtrair_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "-";
        }

        private void cmd_0_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control. Keys.D0) { }
        }
    }
}
