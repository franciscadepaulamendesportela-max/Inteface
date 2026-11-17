namespace WinFormsApp2
{
    partial class FrmRelatoriosCliente
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
            pnlTotalClientes = new Panel();
            lblTituloTotalClientes = new Label();
            lblTotalClientes = new Label();
            dgvRelatorioClientes = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colTelefone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colEndereco = new DataGridViewTextBoxColumn();
            pnlTotalClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorioClientes).BeginInit();
            SuspendLayout();
            // 
            // pnlTotalClientes
            // 
            pnlTotalClientes.BackColor = Color.White;
            pnlTotalClientes.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalClientes.Controls.Add(lblTotalClientes);
            pnlTotalClientes.Controls.Add(lblTituloTotalClientes);
            pnlTotalClientes.Location = new Point(67, 12);
            pnlTotalClientes.Name = "pnlTotalClientes";
            pnlTotalClientes.Size = new Size(300, 100);
            pnlTotalClientes.TabIndex = 0;
            // 
            // lblTituloTotalClientes
            // 
            lblTituloTotalClientes.AutoSize = true;
            lblTituloTotalClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTotalClientes.Location = new Point(25, 16);
            lblTituloTotalClientes.Name = "lblTituloTotalClientes";
            lblTituloTotalClientes.Size = new Size(131, 17);
            lblTituloTotalClientes.TabIndex = 0;
            lblTituloTotalClientes.Text = "TOTAL DE CLIENTES";
            // 
            // lblTotalClientes
            // 
            lblTotalClientes.AutoSize = true;
            lblTotalClientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalClientes.Location = new Point(43, 51);
            lblTotalClientes.Name = "lblTotalClientes";
            lblTotalClientes.Size = new Size(33, 37);
            lblTotalClientes.TabIndex = 1;
            lblTotalClientes.Text = "0";
            // 
            // dgvRelatorioClientes
            // 
            dgvRelatorioClientes.AllowUserToAddRows = false;
            dgvRelatorioClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatorioClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorioClientes.Columns.AddRange(new DataGridViewColumn[] { colNome, colTelefone, colEmail, colEndereco });
            dgvRelatorioClientes.Location = new Point(25, 134);
            dgvRelatorioClientes.Name = "dgvRelatorioClientes";
            dgvRelatorioClientes.ReadOnly = true;
            dgvRelatorioClientes.Size = new Size(900, 300);
            dgvRelatorioClientes.TabIndex = 1;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colTelefone
            // 
            colTelefone.HeaderText = "Telefone";
            colTelefone.Name = "colTelefone";
            colTelefone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "E-mail";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colEndereco
            // 
            colEndereco.HeaderText = "Endereço";
            colEndereco.Name = "colEndereco";
            colEndereco.ReadOnly = true;
            // 
            // FrmRelatoriosCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 478);
            Controls.Add(dgvRelatorioClientes);
            Controls.Add(pnlTotalClientes);
            Name = "FrmRelatoriosCliente";
            Text = "FrmRelatoriosCliente";
            pnlTotalClientes.ResumeLayout(false);
            pnlTotalClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorioClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTotalClientes;
        private Label lblTotalClientes;
        private Label lblTituloTotalClientes;
        private DataGridView dgvRelatorioClientes;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colTelefone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colEndereco;
    }
}