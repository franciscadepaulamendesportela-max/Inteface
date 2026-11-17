namespace WinFormsApp2
{
    partial class FrmConsultarOrdemServico
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
            pnlConsultaOrdem = new Panel();
            btnExcluirOS = new Button();
            btnEditarOS = new Button();
            dgvOrdens = new DataGridView();
            colNumero = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colServico = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            colData = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            txtPesquisarOS = new TextBox();
            pnlConsultaOrdem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdens).BeginInit();
            SuspendLayout();
            // 
            // pnlConsultaOrdem
            // 
            pnlConsultaOrdem.Controls.Add(txtPesquisarOS);
            pnlConsultaOrdem.Controls.Add(btnExcluirOS);
            pnlConsultaOrdem.Controls.Add(btnEditarOS);
            pnlConsultaOrdem.Controls.Add(dgvOrdens);
            pnlConsultaOrdem.Location = new Point(12, 12);
            pnlConsultaOrdem.Name = "pnlConsultaOrdem";
            pnlConsultaOrdem.Size = new Size(921, 383);
            pnlConsultaOrdem.TabIndex = 0;
            // 
            // btnExcluirOS
            // 
            btnExcluirOS.Location = new Point(526, 153);
            btnExcluirOS.Name = "btnExcluirOS";
            btnExcluirOS.Size = new Size(124, 23);
            btnExcluirOS.TabIndex = 2;
            btnExcluirOS.Text = "Excluir Ordem";
            btnExcluirOS.UseVisualStyleBackColor = true;
            btnExcluirOS.Click += btnExcluirOS_Click;
            // 
            // btnEditarOS
            // 
            btnEditarOS.Location = new Point(386, 153);
            btnEditarOS.Name = "btnEditarOS";
            btnEditarOS.Size = new Size(75, 23);
            btnEditarOS.TabIndex = 1;
            btnEditarOS.Text = "Editar OS";
            btnEditarOS.UseVisualStyleBackColor = true;
            btnEditarOS.Click += btnEditarOS_Click;
            // 
            // dgvOrdens
            // 
            dgvOrdens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdens.Columns.AddRange(new DataGridViewColumn[] { colNumero, colCliente, colServico, colValor, colData, colStatus });
            dgvOrdens.Location = new Point(0, 3);
            dgvOrdens.Name = "dgvOrdens";
            dgvOrdens.Size = new Size(895, 197);
            dgvOrdens.TabIndex = 0;
            // 
            // colNumero
            // 
            colNumero.DataPropertyName = "Numero";
            colNumero.HeaderText = "Número da OS";
            colNumero.Name = "colNumero";
            // 
            // colCliente
            // 
            colCliente.DataPropertyName = "NomeCliente";
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.Width = 180;
            // 
            // colServico
            // 
            colServico.DataPropertyName = "NomeServico";
            colServico.HeaderText = "Serviço";
            colServico.Name = "colServico";
            colServico.Width = 180;
            // 
            // colValor
            // 
            colValor.DataPropertyName = "Valor";
            colValor.HeaderText = "Valor (R$)";
            colValor.Name = "colValor";
            colValor.Width = 110;
            // 
            // colData
            // 
            colData.DataPropertyName = "DataAbertura";
            colData.HeaderText = "Data de Abertura";
            colData.Name = "colData";
            colData.Width = 150;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.Width = 120;
            // 
            // txtPesquisarOS
            // 
            txtPesquisarOS.Location = new Point(17, 153);
            txtPesquisarOS.Name = "txtPesquisarOS";
            txtPesquisarOS.PlaceholderText = "Pesquisar número, cliente ou serviço...";
            txtPesquisarOS.Size = new Size(238, 23);
            txtPesquisarOS.TabIndex = 3;
            txtPesquisarOS.TextChanged += txtPesquisarOS_TextChanged;
            // 
            // FrmConsultarOrdemServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            Controls.Add(pnlConsultaOrdem);
            Name = "FrmConsultarOrdemServico";
            Text = "FrmConsultarOrdemServico";
            pnlConsultaOrdem.ResumeLayout(false);
            pnlConsultaOrdem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConsultaOrdem;
        private DataGridView dgvOrdens;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colServico;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn colData;
        private DataGridViewTextBoxColumn colStatus;
        private Button btnEditarOS;
        private Button btnExcluirOS;
        private TextBox txtPesquisarOS;
    }
}