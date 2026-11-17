using System;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp2
{
    public partial class FrmConsultarCliente : Form
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();

            dgvClientes.AutoGenerateColumns = false;

            colNome.DataPropertyName = "Nome";
            colTelefone.DataPropertyName = "Telefone";
            colEmail.DataPropertyName = "Email";
            colEndereco.DataPropertyName = "Endereco";

            colNome.Width = 180;
            colTelefone.Width = 130;
            colEmail.Width = 180;
            colEndereco.Width = 220;
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = FrmCadastroCliente.ListaClientes;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para editar!");
                return;
            }

            Cliente clienteSelecionado =
                dgvClientes.CurrentRow.DataBoundItem as Cliente;

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Não foi possível selecionar o cliente!");
                return;
            }

            FrmCadastroCliente editar =
                new FrmCadastroCliente(clienteSelecionado);

            editar.ShowDialog();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = FrmCadastroCliente.ListaClientes;

        }
        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para excluir!");
                return;
            }

            Cliente clienteSelecionado =
                dgvClientes.CurrentRow.DataBoundItem as Cliente;

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Não foi possível selecionar o cliente!");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este cliente?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                FrmCadastroCliente.ListaClientes.Remove(clienteSelecionado);

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = FrmCadastroCliente.ListaClientes;

                MessageBox.Show("Cliente excluído com sucesso!");
            }
        }

        private void txtPesquisarCliente_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisarCliente.Text.ToLower();

            var clientesFiltrados = FrmCadastroCliente.ListaClientes
                .Where(c => c.Nome.ToLower().Contains(pesquisa) ||
                            c.Telefone.Contains(pesquisa))
                .ToList();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientesFiltrados;
        }
    }
}