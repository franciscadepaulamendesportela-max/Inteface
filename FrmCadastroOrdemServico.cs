using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FrmCadastroOrdemServico : Form
    {
        public static List<OrdemServico> ListaOrdens =
        new List<OrdemServico>();

        private OrdemServico ordemEmEdicao;

        public FrmCadastroOrdemServico()
        {
            InitializeComponent();

            foreach (Cliente cliente in FrmCadastroCliente.ListaClientes)
            {
                cmbCliente.Items.Add(cliente.Nome);
            }

            foreach (Servico servico in FrmCadastroServico.ListaServicos)
            {
                cmbServico.Items.Add(servico.Nome);
            }

            cmbStatus.Items.Add("Pendente");
            cmbStatus.Items.Add("Em andamento");
            cmbStatus.Items.Add("Concluída");

            cmbStatus.SelectedIndex = 0;
        }

        public FrmCadastroOrdemServico(OrdemServico ordem)
        {
            InitializeComponent();

            ordemEmEdicao = ordem;

            foreach (Cliente cliente in FrmCadastroCliente.ListaClientes)
            {
                cmbCliente.Items.Add(cliente.Nome);
            }

            foreach (Servico servico in FrmCadastroServico.ListaServicos)
            {
                cmbServico.Items.Add(servico.Nome);
            }

            cmbStatus.Items.Add("Pendente");
            cmbStatus.Items.Add("Em andamento");
            cmbStatus.Items.Add("Concluída");

            cmbCliente.Text = ordem.NomeCliente;
            cmbServico.Text = ordem.NomeServico;
            txtValor.Text = ordem.Valor.ToString();
            dateTimePicker1.Value = ordem.DataAbertura;
            cmbStatus.Text = ordem.Status;
        }

        private void btnSalvarOrdem_Click(object sender, EventArgs e)
        {

            if (cmbCliente.SelectedIndex == -1 ||
       cmbServico.SelectedIndex == -1 ||
       txtValor.Text == "" ||
       cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            decimal valor;

            if (!decimal.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Digite um valor válido!");
                return;
            }

            if (ordemEmEdicao == null)
            {
                OrdemServico novaOrdem = new OrdemServico();

                novaOrdem.Numero = ListaOrdens.Count + 1;
                novaOrdem.NomeCliente = cmbCliente.Text;
                novaOrdem.NomeServico = cmbServico.Text;
                novaOrdem.Valor = valor;
                novaOrdem.DataAbertura = dateTimePicker1.Value;
                novaOrdem.Status = cmbStatus.Text;

                ListaOrdens.Add(novaOrdem);

                MessageBox.Show("Ordem cadastrada com sucesso!");
            }
            else
            {
                ordemEmEdicao.NomeCliente = cmbCliente.Text;
                ordemEmEdicao.NomeServico = cmbServico.Text;
                ordemEmEdicao.Valor = valor;
                ordemEmEdicao.DataAbertura = dateTimePicker1.Value;
                ordemEmEdicao.Status = cmbStatus.Text;

                MessageBox.Show("Ordem atualizada com sucesso!");
            }

            this.Close();

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
