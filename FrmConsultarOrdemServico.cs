using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FrmConsultarOrdemServico : Form
    {
        public FrmConsultarOrdemServico()
        {
            InitializeComponent();

            dgvOrdens.AutoGenerateColumns = false;

            colNumero.DataPropertyName = "Numero";
            colCliente.DataPropertyName = "NomeCliente";
            colServico.DataPropertyName = "NomeServico";
            colValor.DataPropertyName = "Valor";
            colData.DataPropertyName = "DataAbertura";
            colStatus.DataPropertyName = "Status";

            dgvOrdens.DataSource = FrmCadastroOrdemServico.ListaOrdens;
        }

        private void btnEditarOS_Click(object sender, EventArgs e)
        {
            if (dgvOrdens.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma ordem de serviço!");
                return;
            }

            OrdemServico ordemSelecionada =
                dgvOrdens.CurrentRow.DataBoundItem as OrdemServico;

            if (ordemSelecionada == null)
            {
                MessageBox.Show("Não foi possível selecionar a ordem!");
                return;
            }

            FrmCadastroOrdemServico editar =
                new FrmCadastroOrdemServico(ordemSelecionada);

            editar.ShowDialog();

            dgvOrdens.DataSource = null;
            dgvOrdens.DataSource = FrmCadastroOrdemServico.ListaOrdens;
        }

        private void btnExcluirOS_Click(object sender, EventArgs e)
        {

            if (dgvOrdens.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma ordem de serviço!");
                return;
            }

            OrdemServico ordemSelecionada =
                dgvOrdens.CurrentRow.DataBoundItem as OrdemServico;

            if (ordemSelecionada == null)
            {
                MessageBox.Show("Não foi possível selecionar a ordem!");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir esta ordem de serviço?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                FrmCadastroOrdemServico.ListaOrdens.Remove(ordemSelecionada);

                dgvOrdens.DataSource = null;
                dgvOrdens.DataSource = FrmCadastroOrdemServico.ListaOrdens;

                MessageBox.Show("Ordem excluída com sucesso!");
            }
        }

        private void txtPesquisarOS_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisarOS.Text.ToLower();

            var ordensFiltradas = FrmCadastroOrdemServico.ListaOrdens
                .Where(o =>
                    o.Numero.ToString().Contains(pesquisa) ||
                    o.NomeCliente.ToLower().Contains(pesquisa) ||
                    o.NomeServico.ToLower().Contains(pesquisa))
                .ToList();

            dgvOrdens.DataSource = null;
            dgvOrdens.DataSource = ordensFiltradas;
        }
    }
}
