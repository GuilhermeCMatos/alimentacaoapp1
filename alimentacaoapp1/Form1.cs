using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace alimentacaoapp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_calcular_Click(object sender, EventArgs e)
        {
            int inicio = int.Parse(total_renda.Text);
            
            int n1 = int.Parse(g_energia.Text);
            int n2 = int.Parse(g_agua.Text);
            int n3 = int.Parse(g_internet.Text);
            int n4 = int.Parse(g_alimentacao.Text);
            int n5 = int.Parse(g_outros.Text);

            int resultado = n1 + n2 + n3 + n4 + n5;
            int total = inicio - resultado;

            g_total.Text = resultado.ToString();
            saldo_f.Text = total.ToString(); 
        }

        private void b_novo_Click(object sender, EventArgs e)
        {
            total_renda.Text = null;

            g_energia.Text = null;
            g_agua.Text = null;
            g_internet.Text = null;
            g_alimentacao.Text = null;
            g_outros.Text = null;

            g_total.Text = null;
            saldo_f.Text = null;
        }

        private void b_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
