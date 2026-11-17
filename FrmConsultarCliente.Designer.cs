namespace WinFormsApp2
{
    partial class FrmConsultarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlConsultaCliente = new Panel();
            btnExcluirCliente = new Button();
            btnEditar = new Button();
            dgvClientes = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colTelefone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colEndereco = new DataGridViewTextBoxColumn();
            txtPesquisarCliente = new TextBox();
            lblPesquisarCliente = new Label();
            pnlConsultaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // pnlConsultaCliente
            // 
            pnlConsultaCliente.Controls.Add(lblPesquisarCliente);
            pnlConsultaCliente.Controls.Add(txtPesquisarCliente);
            pnlConsultaCliente.Controls.Add(btnExcluirCliente);
            pnlConsultaCliente.Controls.Add(btnEditar);
            pnlConsultaCliente.Controls.Add(dgvClientes);
            pnlConsultaCliente.Location = new Point(26, 12);
            pnlConsultaCliente.Name = "pnlConsultaCliente";
            pnlConsultaCliente.Size = new Size(791, 426);
            pnlConsultaCliente.TabIndex = 0;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.Location = new Point(453, 322);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(127, 23);
            btnExcluirCliente.TabIndex = 2;
            btnExcluirCliente.Text = "Excluir Cliente";
            btnExcluirCliente.UseVisualStyleBackColor = true;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(315, 323);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colNome, colTelefone, colEmail, colEndereco });
            dgvClientes.Location = new Point(3, 32);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(693, 360);
            dgvClientes.TabIndex = 0;
            // 
            // colNome
            // 
            colNome.FillWeight = 11.5059214F;
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colTelefone
            // 
            colTelefone.FillWeight = 11.5059214F;
            colTelefone.HeaderText = "Telefone ";
            colTelefone.Name = "colTelefone";
            colTelefone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.FillWeight = 365.4822F;
            colEmail.HeaderText = "E-mail";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colEndereco
            // 
            colEndereco.FillWeight = 11.5059214F;
            colEndereco.HeaderText = "Endereço";
            colEndereco.Name = "colEndereco";
            colEndereco.ReadOnly = true;
            // 
            // txtPesquisarCliente
            // 
            txtPesquisarCliente.Location = new Point(19, 323);
            txtPesquisarCliente.Name = "txtPesquisarCliente";
            txtPesquisarCliente.PlaceholderText = "Pesquisar por nome ou telefone...";
            txtPesquisarCliente.Size = new Size(235, 23);
            txtPesquisarCliente.TabIndex = 3;
            txtPesquisarCliente.TextChanged += txtPesquisarCliente_TextChanged;
            // 
            // lblPesquisarCliente
            // 
            lblPesquisarCliente.AutoSize = true;
            lblPesquisarCliente.Location = new Point(21, 293);
            lblPesquisarCliente.Name = "lblPesquisarCliente";
            lblPesquisarCliente.Size = new Size(97, 15);
            lblPesquisarCliente.TabIndex = 4;
            lblPesquisarCliente.Text = "Pesquisar Cliente";
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 450);
            Controls.Add(pnlConsultaCliente);
            Name = "FrmConsultarCliente";
            Text = "FrmConsultarCliente";
            Load += FrmConsultarCliente_Load;
            pnlConsultaCliente.ResumeLayout(false);
            pnlConsultaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConsultaCliente;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colTelefone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colEndereco;
        private Button btnEditar;
        private Button btnExcluirCliente;
        private TextBox txtPesquisarCliente;
        private Label lblPesquisarCliente;
    }
}