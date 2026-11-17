namespace WinFormsApp2
{
    partial class FrmCadastroCliente
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
            pnlCadastro = new Panel();
            btnLimparCliente = new Button();
            btnSalvarCliente = new Button();
            txtEndereco = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            lblEnderecoCliente = new Label();
            lblEmailCliente = new Label();
            lblTelefoneCliente = new Label();
            lblNomeCliente = new Label();
            lblTituloCadastro = new Label();
            pnlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCadastro
            // 
            pnlCadastro.Controls.Add(btnLimparCliente);
            pnlCadastro.Controls.Add(btnSalvarCliente);
            pnlCadastro.Controls.Add(txtEndereco);
            pnlCadastro.Controls.Add(txtEmail);
            pnlCadastro.Controls.Add(txtTelefone);
            pnlCadastro.Controls.Add(txtNome);
            pnlCadastro.Controls.Add(lblEnderecoCliente);
            pnlCadastro.Controls.Add(lblEmailCliente);
            pnlCadastro.Controls.Add(lblTelefoneCliente);
            pnlCadastro.Controls.Add(lblNomeCliente);
            pnlCadastro.Controls.Add(lblTituloCadastro);
            pnlCadastro.Location = new Point(73, 12);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(575, 426);
            pnlCadastro.TabIndex = 0;
            // 
            // btnLimparCliente
            // 
            btnLimparCliente.BackColor = Color.Gainsboro;
            btnLimparCliente.Cursor = Cursors.Hand;
            btnLimparCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparCliente.Location = new Point(334, 352);
            btnLimparCliente.Name = "btnLimparCliente";
            btnLimparCliente.Size = new Size(120, 40);
            btnLimparCliente.TabIndex = 10;
            btnLimparCliente.Text = "Limpar";
            btnLimparCliente.UseVisualStyleBackColor = false;
            btnLimparCliente.Click += btnLimparCliente_Click;
            // 
            // btnSalvarCliente
            // 
            btnSalvarCliente.BackColor = Color.Navy;
            btnSalvarCliente.Cursor = Cursors.Hand;
            btnSalvarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarCliente.ForeColor = Color.White;
            btnSalvarCliente.Location = new Point(128, 351);
            btnSalvarCliente.Name = "btnSalvarCliente";
            btnSalvarCliente.Size = new Size(194, 40);
            btnSalvarCliente.TabIndex = 9;
            btnSalvarCliente.Text = "Salvar Clientes";
            btnSalvarCliente.UseVisualStyleBackColor = false;
            btnSalvarCliente.Click += bntSalvarCliente_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(128, 312);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(326, 23);
            txtEndereco.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 238);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(128, 175);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(326, 23);
            txtTelefone.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(128, 109);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(326, 23);
            txtNome.TabIndex = 5;
            // 
            // lblEnderecoCliente
            // 
            lblEnderecoCliente.AutoSize = true;
            lblEnderecoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnderecoCliente.Location = new Point(128, 277);
            lblEnderecoCliente.Name = "lblEnderecoCliente";
            lblEnderecoCliente.Size = new Size(81, 21);
            lblEnderecoCliente.TabIndex = 4;
            lblEnderecoCliente.Text = "Endereço";
            // 
            // lblEmailCliente
            // 
            lblEmailCliente.AutoSize = true;
            lblEmailCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailCliente.Location = new Point(128, 214);
            lblEmailCliente.Name = "lblEmailCliente";
            lblEmailCliente.Size = new Size(59, 21);
            lblEmailCliente.TabIndex = 3;
            lblEmailCliente.Text = "E-mail";
            // 
            // lblTelefoneCliente
            // 
            lblTelefoneCliente.AutoSize = true;
            lblTelefoneCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefoneCliente.Location = new Point(128, 151);
            lblTelefoneCliente.Name = "lblTelefoneCliente";
            lblTelefoneCliente.Size = new Size(76, 21);
            lblTelefoneCliente.TabIndex = 2;
            lblTelefoneCliente.Text = "Telefone";
            lblTelefoneCliente.Click += lblTelefoneCliente_Click;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCliente.Location = new Point(128, 75);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(134, 21);
            lblNomeCliente.TabIndex = 1;
            lblNomeCliente.Text = "Nome completo";
            // 
            // lblTituloCadastro
            // 
            lblTituloCadastro.AutoSize = true;
            lblTituloCadastro.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCadastro.Location = new Point(168, 24);
            lblTituloCadastro.Name = "lblTituloCadastro";
            lblTituloCadastro.Size = new Size(257, 30);
            lblTituloCadastro.TabIndex = 0;
            lblTituloCadastro.Text = "CADASTRO DE CLIENTES";
            // 
            // FrmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCadastro);
            Name = "FrmCadastroCliente";
            Text = "FrmCadastroCliente";
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCadastro;
        private Label lblTituloCadastro;
        private TextBox txtEndereco;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private Label lblEnderecoCliente;
        private Label lblEmailCliente;
        private Label lblTelefoneCliente;
        private Label lblNomeCliente;
        private Button btnLimparCliente;
        private Button btnSalvarCliente;
    }
}