using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FrmRelatorios : Form
    {
        public FrmRelatorios()
        {
            InitializeComponent();

            CarregarRelatorios();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmAndamento_Click(object sender, EventArgs e)
        {

        }

        private void lblConcluidas_Click(object sender, EventArgs e)
        {

        }

        private void CarregarRelatorios()
        {
            int totalOS = 0;
            int pendentes = 0;
            int emAndamento = 0;
            int concluidas = 0;

            decimal valorTotal = 0;

            foreach (OrdemServico ordem in FrmCadastroOrdemServico.ListaOrdens)
            {
                totalOS++;

                valorTotal += ordem.Valor;

                if (ordem.Status == "Pendente")
                {
                    pendentes++;
                }
                else if (ordem.Status == "Em andamento")
                {
                    emAndamento++;
                }
                else if (ordem.Status == "Concluída")
                {
                    concluidas++;
                }
            }
                lblTotalOS.Text = totalOS.ToString();

                lblPendentes.Text = pendentes.ToString();

                lblEmAndamento.Text = emAndamento.ToString();

                lblConcluidas.Text = concluidas.ToString();

                lblValorTotal.Text = "R$ " + valorTotal.ToString("N2");

            dgvRelatorios.AutoGenerateColumns = true;

            dgvRelatorios.DataSource = null;

            dgvRelatorios.DataSource = FrmCadastroOrdemServico.ListaOrdens;
        }
    }
}
