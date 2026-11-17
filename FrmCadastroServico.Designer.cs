namespace WinFormsApp2
{
    partial class FrmCadastroServico
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
            lblNomeServico = new Label();
            pnlDadosServico = new Panel();
            label1 = new Label();
            btnLimparServico = new Button();
            btnSalvarServico = new Button();
            txtValorServico = new TextBox();
            lblValorServico = new Label();
            txtDescricaoServico = new TextBox();
            lblDescricaoServico = new Label();
            txtNomeServico = new TextBox();
            pnlDadosServico.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeServico
            // 
            lblNomeServico.AutoSize = true;
            lblNomeServico.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeServico.Location = new Point(28, 56);
            lblNomeServico.Name = "lblNomeServico";
            lblNomeServico.Size = new Size(128, 20);
            lblNomeServico.TabIndex = 0;
            lblNomeServico.Text = "Nome do serviço";
            // 
            // pnlDadosServico
            // 
            pnlDadosServico.BorderStyle = BorderStyle.FixedSingle;
            pnlDadosServico.Controls.Add(label1);
            pnlDadosServico.Controls.Add(btnLimparServico);
            pnlDadosServico.Controls.Add(btnSalvarServico);
            pnlDadosServico.Controls.Add(txtValorServico);
            pnlDadosServico.Controls.Add(lblValorServico);
            pnlDadosServico.Controls.Add(txtDescricaoServico);
            pnlDadosServico.Controls.Add(lblDescricaoServico);
            pnlDadosServico.Controls.Add(txtNomeServico);
            pnlDadosServico.Controls.Add(lblNomeServico);
            pnlDadosServico.Location = new Point(80, 0);
            pnlDadosServico.Name = "pnlDadosServico";
            pnlDadosServico.Size = new Size(455, 329);
            pnlDadosServico.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 7);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 8;
            label1.Text = "Cadstro de Serviços";
            // 
            // btnLimparServico
            // 
            btnLimparServico.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparServico.Location = new Point(233, 253);
            btnLimparServico.Name = "btnLimparServico";
            btnLimparServico.Size = new Size(159, 45);
            btnLimparServico.TabIndex = 7;
            btnLimparServico.Text = "Limpar";
            btnLimparServico.UseVisualStyleBackColor = true;
            btnLimparServico.Click += btnLimparServico_Click;
            // 
            // btnSalvarServico
            // 
            btnSalvarServico.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarServico.Location = new Point(36, 253);
            btnSalvarServico.Name = "btnSalvarServico";
            btnSalvarServico.Size = new Size(182, 45);
            btnSalvarServico.TabIndex = 6;
            btnSalvarServico.Text = "Salvar";
            btnSalvarServico.UseVisualStyleBackColor = true;
            btnSalvarServico.Click += btnSalvarServico_Click;
            // 
            // txtValorServico
            // 
            txtValorServico.Location = new Point(31, 213);
            txtValorServico.Name = "txtValorServico";
            txtValorServico.Size = new Size(361, 23);
            txtValorServico.TabIndex = 5;
            // 
            // lblValorServico
            // 
            lblValorServico.AutoSize = true;
            lblValorServico.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorServico.Location = new Point(31, 185);
            lblValorServico.Name = "lblValorServico";
            lblValorServico.Size = new Size(80, 20);
            lblValorServico.TabIndex = 4;
            lblValorServico.Text = "Valor (R$)";
            // 
            // txtDescricaoServico
            // 
            txtDescricaoServico.Location = new Point(30, 149);
            txtDescricaoServico.Name = "txtDescricaoServico";
            txtDescricaoServico.Size = new Size(362, 23);
            txtDescricaoServico.TabIndex = 3;
            // 
            // lblDescricaoServico
            // 
            lblDescricaoServico.AutoSize = true;
            lblDescricaoServico.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricaoServico.Location = new Point(30, 119);
            lblDescricaoServico.Name = "lblDescricaoServico";
            lblDescricaoServico.Size = new Size(76, 20);
            lblDescricaoServico.TabIndex = 2;
            lblDescricaoServico.Text = "Descrição";
            lblDescricaoServico.Click += lblDescricaoServico_Click;
            // 
            // txtNomeServico
            // 
            txtNomeServico.Location = new Point(30, 84);
            txtNomeServico.Name = "txtNomeServico";
            txtNomeServico.Size = new Size(362, 23);
            txtNomeServico.TabIndex = 1;
            txtNomeServico.TextChanged += txtNomeServico_TextChanged;
            // 
            // FrmCadastroServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDadosServico);
            Name = "FrmCadastroServico";
            Text = "FrmCadastroServico";
            pnlDadosServico.ResumeLayout(false);
            pnlDadosServico.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNomeServico;
        private Panel pnlDadosServico;
        private TextBox txtValorServico;
        private Label lblValorServico;
        private TextBox txtDescricaoServico;
        private Label lblDescricaoServico;
        private TextBox txtNomeServico;
        private Label label1;
        private Button btnLimparServico;
        private Button btnSalvarServico;
    }
}