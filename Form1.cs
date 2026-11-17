using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNomeSistema_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Painel Principal";
            lblSubtitulo.Text = "Bem-vindo ao Sistema de Ordem de Serviços!";
        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }

        private void pnlSubClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pnlSubClientes.Visible = !pnlSubClientes.Visible;
        }

        private void btnOrdens_Click(object sender, EventArgs e)
        {
            pnlSubOrdens.Visible = !pnlSubOrdens.Visible;
        }

        private void bntServicos_Click(object sender, EventArgs e)
        {
            pnlSubServicos.Visible = !pnlSubServicos.Visible;
        }

        private void btnEditarServico_Click(object sender, EventArgs e)
        {
            FrmConsultarServico consulta = new FrmConsultarServico();
            consulta.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlSubRelatorios.Visible = !pnlSubRelatorios.Visible;
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cadastro = new FrmCadastroCliente();
            cadastro.ShowDialog();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente consulta = new FrmConsultarCliente();
            consulta.ShowDialog();
        }

        private void btnCadastrarServico_Click(object sender, EventArgs e)
        {
            FrmCadastroServico cadastro = new FrmCadastroServico();
            cadastro.ShowDialog();
        }

        private void btnConsultarServico_Click(object sender, EventArgs e)
        {
            FrmConsultarServico consulta = new FrmConsultarServico();
            consulta.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente consulta = new FrmConsultarCliente();
            consulta.ShowDialog();
        }

        private void btnNovaOrdem_Click(object sender, EventArgs e)
        {
            FrmCadastroOrdemServico cadastro = new FrmCadastroOrdemServico();
            cadastro.ShowDialog();
        }

        private void btnConsultarOrdem_Click(object sender, EventArgs e)
        {

            FrmConsultarOrdemServico consulta = new FrmConsultarOrdemServico();
            consulta.ShowDialog();
        }

        private void btnEditarOS_Click(object sender, EventArgs e)
        {
            FrmConsultarOrdemServico consulta = new FrmConsultarOrdemServico();
            consulta.ShowDialog();
        }

        private void btnRelatorioOS_Click(object sender, EventArgs e)
        {
            FrmRelatorios relatorio = new FrmRelatorios();

            relatorio.ShowDialog();
        }

        private void tnRelatorioClientes_Click(object sender, EventArgs e)
        {
            FrmRelatoriosCliente relatorio = new FrmRelatoriosCliente();
            relatorio.ShowDialog();
        }
    }
}
