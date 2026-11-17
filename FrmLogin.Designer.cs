namespace WinFormsApp2
{
    partial class FrmLogin
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
            pnlLogin = new Panel();
            lblIdentificacaoSenha = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblIdentificacaoUsuario = new Label();
            lblTituloLogin = new Label();
            btnEntrar = new Button();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnEntrar);
            pnlLogin.Controls.Add(lblIdentificacaoSenha);
            pnlLogin.Controls.Add(txtSenha);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(lblIdentificacaoUsuario);
            pnlLogin.Controls.Add(lblTituloLogin);
            pnlLogin.Location = new Point(196, 46);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(400, 350);
            pnlLogin.TabIndex = 0;
            // 
            // lblIdentificacaoSenha
            // 
            lblIdentificacaoSenha.AutoSize = true;
            lblIdentificacaoSenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdentificacaoSenha.Location = new Point(49, 171);
            lblIdentificacaoSenha.Name = "lblIdentificacaoSenha";
            lblIdentificacaoSenha.Size = new Size(51, 20);
            lblIdentificacaoSenha.TabIndex = 4;
            lblIdentificacaoSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(48, 204);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(300, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(48, 125);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 23);
            txtUsuario.TabIndex = 2;
            // 
            // lblIdentificacaoUsuario
            // 
            lblIdentificacaoUsuario.AutoSize = true;
            lblIdentificacaoUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdentificacaoUsuario.Location = new Point(48, 91);
            lblIdentificacaoUsuario.Name = "lblIdentificacaoUsuario";
            lblIdentificacaoUsuario.Size = new Size(63, 20);
            lblIdentificacaoUsuario.TabIndex = 1;
            lblIdentificacaoUsuario.Text = "Usuário";
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.AutoSize = true;
            lblTituloLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLogin.Location = new Point(128, 34);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(154, 32);
            lblTituloLogin.TabIndex = 0;
            lblTituloLogin.Text = "BEM-VINDO";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(0, 0, 192);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(48, 260);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(300, 40);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlLogin);
            Name = "FrmLogin";
            Text = "FrmLogin";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Label lblIdentificacaoUsuario;
        private Label lblTituloLogin;
        private TextBox txtUsuario;
        private Label lblIdentificacaoSenha;
        private TextBox txtSenha;
        private Button btnEntrar;
    }
}