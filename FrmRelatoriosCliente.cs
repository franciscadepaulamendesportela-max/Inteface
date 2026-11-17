using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FrmRelatoriosCliente : Form
    {
        public FrmRelatoriosCliente()
        {
            InitializeComponent();

            CarregarRelatorioClientes();
        }

        private void CarregarRelatorioClientes()
        {
            lblTotalClientes.Text =
                FrmCadastroCliente.ListaClientes.Count.ToString();

            dgvRelatorioClientes.AutoGenerateColumns = false;

            colNome.DataPropertyName = "Nome";
            colTelefone.DataPropertyName = "Telefone";
            colEmail.DataPropertyName = "Email";
            colEndereco.DataPropertyName = "Endereco";

            dgvRelatorioClientes.DataSource = null;
            dgvRelatorioClientes.DataSource =
                FrmCadastroCliente.ListaClientes;
        }
    }
}
