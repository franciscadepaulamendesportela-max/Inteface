namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            pnlSubRelatorios = new Panel();
            btnRelatorioOS = new Button();
            tnRelatorioClientes = new Button();
            btnRelatorios = new Button();
            pnlSubServicos = new Panel();
            btnEditarServico = new Button();
            btnConsultarServico = new Button();
            btnCadastrarServico = new Button();
            bntServicos = new Button();
            pnlSubOrdens = new Panel();
            btnEditarOS = new Button();
            btnConsultarOS = new Button();
            btnNovaOS = new Button();
            btnOrdens = new Button();
            pnlSubClientes = new Panel();
            btnEditarCliente = new Button();
            btnConsultarCliente = new Button();
            btnCadastrarCliente = new Button();
            btnClientes = new Button();
            btnInicio = new Button();
            lblNomeSistema = new Label();
            lblTitulo = new Label();
            pnlConteudo = new Panel();
            lblSubtitulo = new Label();
            pnlMenu.SuspendLayout();
            pnlSubRelatorios.SuspendLayout();
            pnlSubServicos.SuspendLayout();
            pnlSubOrdens.SuspendLayout();
            pnlSubClientes.SuspendLayout();
            pnlConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(30, 41, 59);
            pnlMenu.Controls.Add(pnlSubRelatorios);
            pnlMenu.Controls.Add(btnRelatorios);
            pnlMenu.Controls.Add(pnlSubServicos);
            pnlMenu.Controls.Add(bntServicos);
            pnlMenu.Controls.Add(pnlSubOrdens);
            pnlMenu.Controls.Add(btnOrdens);
            pnlMenu.Controls.Add(pnlSubClientes);
            pnlMenu.Controls.Add(btnClientes);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(lblNomeSistema);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(5);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(276, 749);
            pnlMenu.TabIndex = 0;
            // 
            // pnlSubRelatorios
            // 
            pnlSubRelatorios.Controls.Add(btnRelatorioOS);
            pnlSubRelatorios.Controls.Add(tnRelatorioClientes);
            pnlSubRelatorios.Location = new Point(20, 616);
            pnlSubRelatorios.Name = "pnlSubRelatorios";
            pnlSubRelatorios.Size = new Size(220, 88);
            pnlSubRelatorios.TabIndex = 9;
            pnlSubRelatorios.Visible = false;
            // 
            // btnRelatorioOS
            // 
            btnRelatorioOS.FlatStyle = FlatStyle.Flat;
            btnRelatorioOS.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorioOS.ForeColor = Color.White;
            btnRelatorioOS.Location = new Point(5, 47);
            btnRelatorioOS.Name = "btnRelatorioOS";
            btnRelatorioOS.Size = new Size(212, 35);
            btnRelatorioOS.TabIndex = 1;
            btnRelatorioOS.Text = "Relatório de Serviços";
            btnRelatorioOS.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorioOS.UseVisualStyleBackColor = true;
            btnRelatorioOS.Click += btnRelatorioOS_Click;
            // 
            // tnRelatorioClientes
            // 
            tnRelatorioClientes.FlatStyle = FlatStyle.Flat;
            tnRelatorioClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tnRelatorioClientes.ForeColor = Color.White;
            tnRelatorioClientes.Location = new Point(5, 3);
            tnRelatorioClientes.Name = "tnRelatorioClientes";
            tnRelatorioClientes.Size = new Size(212, 35);
            tnRelatorioClientes.TabIndex = 0;
            tnRelatorioClientes.Text = "Relatório de Clientes";
            tnRelatorioClientes.UseVisualStyleBackColor = true;
            tnRelatorioClientes.Click += tnRelatorioClientes_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorios.ForeColor = Color.White;
            btnRelatorios.Location = new Point(20, 576);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(200, 34);
            btnRelatorios.TabIndex = 8;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.UseVisualStyleBackColor = true;
            btnRelatorios.Click += button2_Click;
            // 
            // pnlSubServicos
            // 
            pnlSubServicos.Controls.Add(btnEditarServico);
            pnlSubServicos.Controls.Add(btnConsultarServico);
            pnlSubServicos.Controls.Add(btnCadastrarServico);
            pnlSubServicos.Location = new Point(20, 438);
            pnlSubServicos.Name = "pnlSubServicos";
            pnlSubServicos.Size = new Size(200, 132);
            pnlSubServicos.TabIndex = 7;
            pnlSubServicos.Visible = false;
            // 
            // btnEditarServico
            // 
            btnEditarServico.FlatStyle = FlatStyle.Flat;
            btnEditarServico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarServico.ForeColor = Color.White;
            btnEditarServico.Location = new Point(5, 89);
            btnEditarServico.Name = "btnEditarServico";
            btnEditarServico.Size = new Size(190, 35);
            btnEditarServico.TabIndex = 2;
            btnEditarServico.Text = "Editar Serviço";
            btnEditarServico.UseVisualStyleBackColor = true;
            btnEditarServico.Click += btnEditarServico_Click;
            // 
            // btnConsultarServico
            // 
            btnConsultarServico.FlatStyle = FlatStyle.Flat;
            btnConsultarServico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultarServico.ForeColor = Color.White;
            btnConsultarServico.Location = new Point(5, 47);
            btnConsultarServico.Name = "btnConsultarServico";
            btnConsultarServico.Size = new Size(190, 35);
            btnConsultarServico.TabIndex = 1;
            btnConsultarServico.Text = "Consultar Serviços";
            btnConsultarServico.UseVisualStyleBackColor = true;
            btnConsultarServico.Click += btnConsultarServico_Click;
            // 
            // btnCadastrarServico
            // 
            btnCadastrarServico.FlatStyle = FlatStyle.Flat;
            btnCadastrarServico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarServico.ForeColor = Color.White;
            btnCadastrarServico.Location = new Point(5, 3);
            btnCadastrarServico.Name = "btnCadastrarServico";
            btnCadastrarServico.Size = new Size(190, 37);
            btnCadastrarServico.TabIndex = 0;
            btnCadastrarServico.Text = "Cadastrar Serviço";
            btnCadastrarServico.UseVisualStyleBackColor = true;
            btnCadastrarServico.Click += btnCadastrarServico_Click;
            // 
            // bntServicos
            // 
            bntServicos.FlatStyle = FlatStyle.Flat;
            bntServicos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntServicos.ForeColor = Color.White;
            bntServicos.Location = new Point(20, 402);
            bntServicos.Name = "bntServicos";
            bntServicos.Size = new Size(190, 30);
            bntServicos.TabIndex = 6;
            bntServicos.Text = "Serviços";
            bntServicos.TextAlign = ContentAlignment.MiddleLeft;
            bntServicos.UseVisualStyleBackColor = true;
            bntServicos.Click += bntServicos_Click;
            // 
            // pnlSubOrdens
            // 
            pnlSubOrdens.BackColor = Color.FromArgb(45, 55, 72);
            pnlSubOrdens.Controls.Add(btnEditarOS);
            pnlSubOrdens.Controls.Add(btnConsultarOS);
            pnlSubOrdens.Controls.Add(btnNovaOS);
            pnlSubOrdens.Location = new Point(20, 267);
            pnlSubOrdens.Name = "pnlSubOrdens";
            pnlSubOrdens.Size = new Size(200, 129);
            pnlSubOrdens.TabIndex = 5;
            pnlSubOrdens.Visible = false;
            // 
            // btnEditarOS
            // 
            btnEditarOS.FlatStyle = FlatStyle.Flat;
            btnEditarOS.ForeColor = Color.White;
            btnEditarOS.Location = new Point(5, 89);
            btnEditarOS.Name = "btnEditarOS";
            btnEditarOS.Size = new Size(190, 35);
            btnEditarOS.TabIndex = 2;
            btnEditarOS.Text = "Editar OS";
            btnEditarOS.UseVisualStyleBackColor = true;
            btnEditarOS.Click += btnEditarOS_Click;
            // 
            // btnConsultarOS
            // 
            btnConsultarOS.FlatStyle = FlatStyle.Flat;
            btnConsultarOS.ForeColor = Color.White;
            btnConsultarOS.Location = new Point(5, 47);
            btnConsultarOS.Name = "btnConsultarOS";
            btnConsultarOS.Size = new Size(190, 35);
            btnConsultarOS.TabIndex = 1;
            btnConsultarOS.Text = "Consultar OS";
            btnConsultarOS.UseVisualStyleBackColor = true;
            btnConsultarOS.Click += btnConsultarOrdem_Click;
            // 
            // btnNovaOS
            // 
            btnNovaOS.FlatStyle = FlatStyle.Flat;
            btnNovaOS.ForeColor = Color.White;
            btnNovaOS.Location = new Point(5, 5);
            btnNovaOS.Name = "btnNovaOS";
            btnNovaOS.Size = new Size(190, 35);
            btnNovaOS.TabIndex = 0;
            btnNovaOS.Text = "Nova OS";
            btnNovaOS.UseVisualStyleBackColor = true;
            btnNovaOS.Click += btnNovaOrdem_Click;
            // 
            // btnOrdens
            // 
            btnOrdens.FlatStyle = FlatStyle.Flat;
            btnOrdens.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdens.ForeColor = Color.White;
            btnOrdens.Location = new Point(20, 233);
            btnOrdens.Name = "btnOrdens";
            btnOrdens.Size = new Size(200, 28);
            btnOrdens.TabIndex = 4;
            btnOrdens.Text = "Ordem de Serviços";
            btnOrdens.TextAlign = ContentAlignment.MiddleLeft;
            btnOrdens.UseVisualStyleBackColor = true;
            btnOrdens.Click += btnOrdens_Click;
            // 
            // pnlSubClientes
            // 
            pnlSubClientes.BackColor = Color.FromArgb(45, 55, 72);
            pnlSubClientes.Controls.Add(btnEditarCliente);
            pnlSubClientes.Controls.Add(btnConsultarCliente);
            pnlSubClientes.Controls.Add(btnCadastrarCliente);
            pnlSubClientes.Location = new Point(20, 100);
            pnlSubClientes.Name = "pnlSubClientes";
            pnlSubClientes.Size = new Size(200, 127);
            pnlSubClientes.TabIndex = 3;
            pnlSubClientes.Visible = false;
            pnlSubClientes.Paint += pnlSubClientes_Paint;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.FlatStyle = FlatStyle.Flat;
            btnEditarCliente.ForeColor = Color.White;
            btnEditarCliente.Location = new Point(5, 89);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(190, 35);
            btnEditarCliente.TabIndex = 2;
            btnEditarCliente.Text = "Editar";
            btnEditarCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarCliente.UseVisualStyleBackColor = true;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // btnConsultarCliente
            // 
            btnConsultarCliente.FlatStyle = FlatStyle.Flat;
            btnConsultarCliente.ForeColor = Color.White;
            btnConsultarCliente.Location = new Point(5, 47);
            btnConsultarCliente.Name = "btnConsultarCliente";
            btnConsultarCliente.Size = new Size(190, 35);
            btnConsultarCliente.TabIndex = 1;
            btnConsultarCliente.Text = "Consultar";
            btnConsultarCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultarCliente.UseVisualStyleBackColor = true;
            btnConsultarCliente.Click += btnConsultarCliente_Click;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.FlatStyle = FlatStyle.Flat;
            btnCadastrarCliente.ForeColor = Color.White;
            btnCadastrarCliente.Location = new Point(5, 4);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(190, 37);
            btnCadastrarCliente.TabIndex = 0;
            btnCadastrarCliente.Text = "Cadastrar";
            btnCadastrarCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(30, 41, 59);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(20, 65);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(200, 29);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(20, 30);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(114, 32);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblNomeSistema
            // 
            lblNomeSistema.AutoSize = true;
            lblNomeSistema.BackColor = Color.FromArgb(30, 41, 59);
            lblNomeSistema.ForeColor = Color.White;
            lblNomeSistema.Location = new Point(20, 0);
            lblNomeSistema.Margin = new Padding(5, 0, 5, 0);
            lblNomeSistema.Name = "lblNomeSistema";
            lblNomeSistema.Size = new Size(153, 25);
            lblNomeSistema.TabIndex = 0;
            lblNomeSistema.Text = "Service Manager";
            lblNomeSistema.Click += lblNomeSistema_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(222, 37);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Painel Principal ";
            // 
            // pnlConteudo
            // 
            pnlConteudo.Controls.Add(lblSubtitulo);
            pnlConteudo.Controls.Add(lblTitulo);
            pnlConteudo.Cursor = Cursors.Hand;
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlConteudo.Location = new Point(276, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(529, 749);
            pnlConteudo.TabIndex = 1;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(41, 69);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(168, 20);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "Bem-Vindo ao Sistema";
            lblSubtitulo.Click += lblSubtitulo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(805, 749);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Formualrio";
            Load += Form1_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlSubRelatorios.ResumeLayout(false);
            pnlSubServicos.ResumeLayout(false);
            pnlSubOrdens.ResumeLayout(false);
            pnlSubClientes.ResumeLayout(false);
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Label lblNomeSistema;
        private Button btnInicio;
        private Label lblTitulo;
        private Panel pnlConteudo;
        private Label lblSubtitulo;
        private Button btnClientes;
        private Panel pnlSubClientes;
        private Button btnCadastrarCliente;
        private Button btnEditarCliente;
        private Button btnConsultarCliente;
        private Button btnOrdens;
        private Panel pnlSubOrdens;
        private Button btnEditarOS;
        private Button btnConsultarOS;
        private Button btnNovaOS;
        private Button bntServicos;
        private Panel pnlSubServicos;
        private Button btnEditarServico;
        private Button btnConsultarServico;
        private Button btnCadastrarServico;
        private Button btnRelatorios;
        private Panel pnlSubRelatorios;
        private Button btnRelatorioOS;
        private Button tnRelatorioClientes;
    }
}
