using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp2
{
    public partial class FrmConsultarServico : Form
    {
        public FrmConsultarServico()
        {
            InitializeComponent();

            dgvServicos.AutoGenerateColumns = false;

            colNome.DataPropertyName = "Nome";
            colDescricao.DataPropertyName = "Descricao";
            colValor.DataPropertyName = "Valor";

            dgvServicos.DataSource = FrmCadastroServico.ListaServicos;
        }

        private void btnEditarServico_Click(object sender, EventArgs e)
        {
            if (dgvServicos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um serviço para editar!");
                return;
            }

            Servico servicoSelecionado =
                dgvServicos.CurrentRow.DataBoundItem as Servico;

            if (servicoSelecionado == null)
            {
                MessageBox.Show("Não foi possível selecionar o serviço!");
                return;
            }

            FrmCadastroServico editar =
                new FrmCadastroServico(servicoSelecionado);

            editar.ShowDialog();

            dgvServicos.DataSource = null;
            dgvServicos.DataSource = FrmCadastroServico.ListaServicos;

        }

        private void btnExcluirServico_Click(object sender, EventArgs e)
        {
            if (dgvServicos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um serviço para excluir!");
                return;
            }

            Servico servicoSelecionado =
                dgvServicos.CurrentRow.DataBoundItem as Servico;

            if (servicoSelecionado == null)
            {
                MessageBox.Show("Não foi possível selecionar o serviço!");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este serviço?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                FrmCadastroServico.ListaServicos.Remove(servicoSelecionado);

                dgvServicos.DataSource = null;
                dgvServicos.DataSource = FrmCadastroServico.ListaServicos;

                MessageBox.Show("Serviço excluído com sucesso!");


            }
        }

        private void txtPesquisarServico_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisarServico.Text.ToLower();

            var servicosFiltrados = FrmCadastroServico.ListaServicos
                .Where(s => s.Nome.ToLower().Contains(pesquisa))
                .ToList();

            dgvServicos.DataSource = null;
            dgvServicos.DataSource = servicosFiltrados;
        }
    }
}