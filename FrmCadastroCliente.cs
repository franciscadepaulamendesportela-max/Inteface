using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WinFormsApp2
{
    public partial class FrmCadastroCliente : Form
    {
        private Cliente clienteEmEdicao;

        public static List<Cliente> ListaClientes = new List<Cliente>();

        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        public FrmCadastroCliente(Cliente cliente)
        {
            InitializeComponent();

            clienteEmEdicao = cliente;

            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;
            txtEndereco.Text = cliente.Endereco;
        }

        
        private void lblTelefoneCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
        }

        private void bntSalvarCliente_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha o nome e o telefone!");
                return;
            }

            if (clienteEmEdicao == null)
            {
                // Cadastrar um novo cliente
                Cliente novoCliente = new Cliente();

                novoCliente.Nome = txtNome.Text;
                novoCliente.Telefone = txtTelefone.Text;
                novoCliente.Email = txtEmail.Text;
                novoCliente.Endereco = txtEndereco.Text;

                ListaClientes.Add(novoCliente);

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            else
            {
                // Atualizar um cliente existente
                clienteEmEdicao.Nome = txtNome.Text;
                clienteEmEdicao.Telefone = txtTelefone.Text;
                clienteEmEdicao.Email = txtEmail.Text;
                clienteEmEdicao.Endereco = txtEndereco.Text;

                MessageBox.Show("Cliente atualizado com sucesso!");
            }

            this.Close();
        
        }
    }
}




