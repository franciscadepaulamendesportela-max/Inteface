namespace WinFormsApp2
{
    partial class FrmConsultarServico
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
            pnlConsultaServico = new Panel();
            btnExcluirServico = new Button();
            btnEditarServico = new Button();
            dgvServicos = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colDescricao = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            txtPesquisarServico = new TextBox();
            pnlConsultaServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            SuspendLayout();
            // 
            // pnlConsultaServico
            // 
            pnlConsultaServico.Controls.Add(txtPesquisarServico);
            pnlConsultaServico.Controls.Add(btnExcluirServico);
            pnlConsultaServico.Controls.Add(btnEditarServico);
            pnlConsultaServico.Controls.Add(dgvServicos);
            pnlConsultaServico.Location = new Point(12, 21);
            pnlConsultaServico.Name = "pnlConsultaServico";
            pnlConsultaServico.Size = new Size(776, 395);
            pnlConsultaServico.TabIndex = 0;
            // 
            // btnExcluirServico
            // 
            btnExcluirServico.Location = new Point(581, 304);
            btnExcluirServico.Name = "btnExcluirServico";
            btnExcluirServico.Size = new Size(148, 23);
            btnExcluirServico.TabIndex = 2;
            btnExcluirServico.Text = "Excluir Serviço";
            btnExcluirServico.UseVisualStyleBackColor = true;
            btnExcluirServico.Click += btnExcluirServico_Click;
            // 
            // btnEditarServico
            // 
            btnEditarServico.Location = new Point(373, 304);
            btnEditarServico.Name = "btnEditarServico";
            btnEditarServico.Size = new Size(171, 23);
            btnEditarServico.TabIndex = 1;
            btnEditarServico.Text = "Editar Serviço";
            btnEditarServico.UseVisualStyleBackColor = true;
            btnEditarServico.Click += btnEditarServico_Click;
            // 
            // dgvServicos
            // 
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicos.Columns.AddRange(new DataGridViewColumn[] { colNome, colDescricao, colValor });
            dgvServicos.Location = new Point(22, 32);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.Size = new Size(739, 307);
            dgvServicos.TabIndex = 0;
            // 
            // colNome
            // 
            colNome.DataPropertyName = "Nome";
            colNome.HeaderText = "Nome do Serviço";
            colNome.Name = "colNome";
            colNome.Width = 220;
            // 
            // colDescricao
            // 
            colDescricao.DataPropertyName = "Descricao";
            colDescricao.HeaderText = "Descrição";
            colDescricao.Name = "colDescricao";
            colDescricao.Width = 350;
            // 
            // colValor
            // 
            colValor.DataPropertyName = "Valor";
            colValor.HeaderText = "Valor (R$)";
            colValor.Name = "colValor";
            colValor.Width = 120;
            // 
            // txtPesquisarServico
            // 
            txtPesquisarServico.Location = new Point(37, 304);
            txtPesquisarServico.Name = "txtPesquisarServico";
            txtPesquisarServico.PlaceholderText = "Pesquisar serviço...";
            txtPesquisarServico.Size = new Size(165, 23);
            txtPesquisarServico.TabIndex = 3;
            txtPesquisarServico.TextChanged += txtPesquisarServico_TextChanged;
            // 
            // FrmConsultarServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlConsultaServico);
            Name = "FrmConsultarServico";
            Text = "FrmConsultarServico";
            pnlConsultaServico.ResumeLayout(false);
            pnlConsultaServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConsultaServico;
        private DataGridView dgvServicos;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colDescricao;
        private DataGridViewTextBoxColumn colValor;
        private Button btnEditarServico;
        private Button btnExcluirServico;
        private TextBox txtPesquisarServico;
    }
}