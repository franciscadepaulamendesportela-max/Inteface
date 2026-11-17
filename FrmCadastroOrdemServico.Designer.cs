namespace WinFormsApp2
{
    partial class FrmCadastroOrdemServico
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
            pnlDadosOrdem = new Panel();
            lblTitulo = new Label();
            lblCliente = new Label();
            lblServico = new Label();
            lblValor = new Label();
            lblData = new Label();
            lblStatus = new Label();
            cmbServico = new ComboBox();
            cmbCliente = new ComboBox();
            txtValor = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSalvarOrdem = new Button();
            btnLimparOrdem = new Button();
            cmbStatus = new ComboBox();
            pnlDadosOrdem.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDadosOrdem
            // 
            pnlDadosOrdem.Controls.Add(cmbStatus);
            pnlDadosOrdem.Controls.Add(btnLimparOrdem);
            pnlDadosOrdem.Controls.Add(btnSalvarOrdem);
            pnlDadosOrdem.Controls.Add(dateTimePicker1);
            pnlDadosOrdem.Controls.Add(txtValor);
            pnlDadosOrdem.Controls.Add(cmbCliente);
            pnlDadosOrdem.Controls.Add(cmbServico);
            pnlDadosOrdem.Controls.Add(lblStatus);
            pnlDadosOrdem.Controls.Add(lblData);
            pnlDadosOrdem.Controls.Add(lblValor);
            pnlDadosOrdem.Controls.Add(lblServico);
            pnlDadosOrdem.Controls.Add(lblCliente);
            pnlDadosOrdem.Controls.Add(lblTitulo);
            pnlDadosOrdem.Location = new Point(54, 12);
            pnlDadosOrdem.Name = "pnlDadosOrdem";
            pnlDadosOrdem.Size = new Size(471, 410);
            pnlDadosOrdem.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(23, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(132, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nova Ordem de Serviço";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(23, 50);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente:";
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Location = new Point(22, 94);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(48, 15);
            lblServico.TabIndex = 2;
            lblServico.Text = "Serviço:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(22, 138);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 3;
            lblValor.Text = "Valor:";
            lblValor.Click += lblValor_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(213, 150);
            lblData.Name = "lblData";
            lblData.Size = new Size(97, 15);
            lblData.TabIndex = 4;
            lblData.Text = "Data de abertura:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(23, 225);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status:";
            // 
            // cmbServico
            // 
            cmbServico.FormattingEnabled = true;
            cmbServico.Location = new Point(22, 112);
            cmbServico.Name = "cmbServico";
            cmbServico.Size = new Size(391, 23);
            cmbServico.TabIndex = 6;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(23, 68);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(390, 23);
            cmbCliente.TabIndex = 7;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(22, 165);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(133, 23);
            txtValor.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(213, 168);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnSalvarOrdem
            // 
            btnSalvarOrdem.Location = new Point(23, 314);
            btnSalvarOrdem.Name = "btnSalvarOrdem";
            btnSalvarOrdem.Size = new Size(122, 40);
            btnSalvarOrdem.TabIndex = 10;
            btnSalvarOrdem.Text = "Salvar Ordem";
            btnSalvarOrdem.UseVisualStyleBackColor = true;
            btnSalvarOrdem.Click += this.btnSalvarOrdem_Click;
            // 
            // btnLimparOrdem
            // 
            btnLimparOrdem.Location = new Point(306, 314);
            btnLimparOrdem.Name = "btnLimparOrdem";
            btnLimparOrdem.Size = new Size(118, 40);
            btnLimparOrdem.TabIndex = 11;
            btnLimparOrdem.Text = "Limpar";
            btnLimparOrdem.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(23, 264);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(401, 23);
            cmbStatus.TabIndex = 12;
            cmbStatus.SelectedIndexChanged += this.cmbStatus_SelectedIndexChanged;
            // 
            // FrmCadastroOrdemServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDadosOrdem);
            Name = "FrmCadastroOrdemServico";
            Text = "FrmCadastroOrdemServico";
            pnlDadosOrdem.ResumeLayout(false);
            pnlDadosOrdem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDadosOrdem;
        private Button btnLimparOrdem;
        private Button btnSalvarOrdem;
        private DateTimePicker dateTimePicker1;
        private TextBox txtValor;
        private ComboBox cmbCliente;
        private ComboBox cmbServico;
        private Label lblStatus;
        private Label lblData;
        private Label lblValor;
        private Label lblServico;
        private Label lblCliente;
        private Label lblTitulo;
        private ComboBox cmbStatus;
    }
}