using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WinFormsApp2
{
    public partial class FrmCadastroServico : Form
    {
        private Servico servicoEmEdicao;

        public static List<Servico> ListaServicos = new List<Servico>();
        public FrmCadastroServico()
        {


            InitializeComponent();
        }
        public FrmCadastroServico(Servico servico)
        {
            InitializeComponent();

            servicoEmEdicao = servico;

            txtNomeServico.Text = servico.Nome;
            txtDescricaoServico.Text = servico.Descricao;
            txtValorServico.Text = servico.Valor.ToString();
        }


        private void txtNomeServico_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescricaoServico_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarServico_Click(object sender, EventArgs e)
        {

            if (txtNomeServico.Text == "" || txtValorServico.Text == "")
            {
                MessageBox.Show("Preencha o nome e o valor do serviço!");
                return;
            }

            decimal valor;

            if (!decimal.TryParse(txtValorServico.Text, out valor))
            {
                MessageBox.Show("Digite um valor válido!");
                return;
            }

            if (servicoEmEdicao == null)
            {
                // Cadastro de novo serviço
                Servico novoServico = new Servico();

                novoServico.Nome = txtNomeServico.Text;
                novoServico.Descricao = txtDescricaoServico.Text;
                novoServico.Valor = valor;

                ListaServicos.Add(novoServico);

                MessageBox.Show("Serviço cadastrado com sucesso!");
            }
            else
            {
                // Edição de serviço existente
                servicoEmEdicao.Nome = txtNomeServico.Text;
                servicoEmEdicao.Descricao = txtDescricaoServico.Text;
                servicoEmEdicao.Valor = valor;

                MessageBox.Show("Serviço atualizado com sucesso!");
            }

            this.Close();
        }
        private void btnLimparServico_Click(object sender, EventArgs e)
        {
            txtNomeServico.Clear();
            txtDescricaoServico.Clear();
            txtValorServico.Clear();
        }
    }
}   
