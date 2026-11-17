namespace WinFormsApp2
{
    partial class FrmRelatorios
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
            pnlTotalOS = new Panel();
            lblTituloTotal = new Label();
            lblTotalOS = new Label();
            pnlPendentes = new Panel();
            lblTituloPendentes = new Label();
            lblPendentes = new Label();
            pnlEmAndamento = new Panel();
            pnlConcluidas = new Panel();
            lblTituloAndamento = new Label();
            lblEmAndamento = new Label();
            lblTituloConcluidas = new Label();
            lblConcluidas = new Label();
            pnlValorTotal = new Panel();
            lblTituloValorTotal = new Label();
            lblValorTotal = new Label();
            dgvRelatorios = new DataGridView();
            pnlTotalOS.SuspendLayout();
            pnlPendentes.SuspendLayout();
            pnlEmAndamento.SuspendLayout();
            pnlConcluidas.SuspendLayout();
            pnlValorTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorios).BeginInit();
            SuspendLayout();
            // 
            // pnlTotalOS
            // 
            pnlTotalOS.BackColor = Color.White;
            pnlTotalOS.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalOS.Controls.Add(lblTotalOS);
            pnlTotalOS.Controls.Add(lblTituloTotal);
            pnlTotalOS.Location = new Point(67, 12);
            pnlTotalOS.Name = "pnlTotalOS";
            pnlTotalOS.Size = new Size(200, 110);
            pnlTotalOS.TabIndex = 0;
            // 
            // lblTituloTotal
            // 
            lblTituloTotal.AutoSize = true;
            lblTituloTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTotal.Location = new Point(26, 20);
            lblTituloTotal.Name = "lblTituloTotal";
            lblTituloTotal.Size = new Size(90, 17);
            lblTituloTotal.TabIndex = 0;
            lblTituloTotal.Text = "TOTAL DE OS";
            // 
            // lblTotalOS
            // 
            lblTotalOS.AutoSize = true;
            lblTotalOS.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOS.Location = new Point(26, 57);
            lblTotalOS.Name = "lblTotalOS";
            lblTotalOS.Size = new Size(34, 40);
            lblTotalOS.TabIndex = 1;
            lblTotalOS.Text = "0";
            // 
            // pnlPendentes
            // 
            pnlPendentes.BackColor = Color.White;
            pnlPendentes.BorderStyle = BorderStyle.FixedSingle;
            pnlPendentes.Controls.Add(lblPendentes);
            pnlPendentes.Controls.Add(lblTituloPendentes);
            pnlPendentes.Location = new Point(267, 12);
            pnlPendentes.Name = "pnlPendentes";
            pnlPendentes.Size = new Size(200, 110);
            pnlPendentes.TabIndex = 1;
            // 
            // lblTituloPendentes
            // 
            lblTituloPendentes.AutoSize = true;
            lblTituloPendentes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPendentes.Location = new Point(30, 20);
            lblTituloPendentes.Name = "lblTituloPendentes";
            lblTituloPendentes.Size = new Size(82, 17);
            lblTituloPendentes.TabIndex = 0;
            lblTituloPendentes.Text = "PENDENTES";
            // 
            // lblPendentes
            // 
            lblPendentes.AutoSize = true;
            lblPendentes.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendentes.Location = new Point(30, 57);
            lblPendentes.Name = "lblPendentes";
            lblPendentes.Size = new Size(34, 40);
            lblPendentes.TabIndex = 1;
            lblPendentes.Text = "0";
            // 
            // pnlEmAndamento
            // 
            pnlEmAndamento.BackColor = Color.White;
            pnlEmAndamento.BorderStyle = BorderStyle.FixedSingle;
            pnlEmAndamento.Controls.Add(lblEmAndamento);
            pnlEmAndamento.Controls.Add(lblTituloAndamento);
            pnlEmAndamento.Location = new Point(67, 128);
            pnlEmAndamento.Name = "pnlEmAndamento";
            pnlEmAndamento.Size = new Size(200, 110);
            pnlEmAndamento.TabIndex = 2;
            // 
            // pnlConcluidas
            // 
            pnlConcluidas.BackColor = Color.White;
            pnlConcluidas.BorderStyle = BorderStyle.FixedSingle;
            pnlConcluidas.Controls.Add(lblConcluidas);
            pnlConcluidas.Controls.Add(lblTituloConcluidas);
            pnlConcluidas.Location = new Point(267, 128);
            pnlConcluidas.Name = "pnlConcluidas";
            pnlConcluidas.Size = new Size(200, 110);
            pnlConcluidas.TabIndex = 3;
            // 
            // lblTituloAndamento
            // 
            lblTituloAndamento.AutoSize = true;
            lblTituloAndamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAndamento.Location = new Point(26, 16);
            lblTituloAndamento.Name = "lblTituloAndamento";
            lblTituloAndamento.Size = new Size(116, 17);
            lblTituloAndamento.TabIndex = 0;
            lblTituloAndamento.Text = "EM ANDAMENTO";
            // 
            // lblEmAndamento
            // 
            lblEmAndamento.AutoSize = true;
            lblEmAndamento.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmAndamento.Location = new Point(26, 54);
            lblEmAndamento.Name = "lblEmAndamento";
            lblEmAndamento.Size = new Size(34, 40);
            lblEmAndamento.TabIndex = 1;
            lblEmAndamento.Text = "0";
            lblEmAndamento.Click += lblEmAndamento_Click;
            // 
            // lblTituloConcluidas
            // 
            lblTituloConcluidas.AutoSize = true;
            lblTituloConcluidas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloConcluidas.Location = new Point(22, 16);
            lblTituloConcluidas.Name = "lblTituloConcluidas";
            lblTituloConcluidas.Size = new Size(90, 17);
            lblTituloConcluidas.TabIndex = 0;
            lblTituloConcluidas.Text = "CONCLUÍDAS";
            // 
            // lblConcluidas
            // 
            lblConcluidas.AutoSize = true;
            lblConcluidas.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConcluidas.Location = new Point(32, 54);
            lblConcluidas.Name = "lblConcluidas";
            lblConcluidas.Size = new Size(34, 40);
            lblConcluidas.TabIndex = 1;
            lblConcluidas.Text = "0";
            lblConcluidas.Click += lblConcluidas_Click;
            // 
            // pnlValorTotal
            // 
            pnlValorTotal.BackColor = Color.White;
            pnlValorTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlValorTotal.Controls.Add(lblValorTotal);
            pnlValorTotal.Controls.Add(lblTituloValorTotal);
            pnlValorTotal.Location = new Point(67, 244);
            pnlValorTotal.Name = "pnlValorTotal";
            pnlValorTotal.Size = new Size(400, 100);
            pnlValorTotal.TabIndex = 4;
            // 
            // lblTituloValorTotal
            // 
            lblTituloValorTotal.AutoSize = true;
            lblTituloValorTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloValorTotal.Location = new Point(16, 14);
            lblTituloValorTotal.Name = "lblTituloValorTotal";
            lblTituloValorTotal.Size = new Size(145, 17);
            lblTituloValorTotal.TabIndex = 0;
            lblTituloValorTotal.Text = "VALOR TOTAL DAS OS";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(16, 47);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(113, 37);
            lblValorTotal.TabIndex = 1;
            lblValorTotal.Text = "R$ 0,00";
            // 
            // dgvRelatorios
            // 
            dgvRelatorios.AllowUserToAddRows = false;
            dgvRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorios.Location = new Point(35, 361);
            dgvRelatorios.Name = "dgvRelatorios";
            dgvRelatorios.ReadOnly = true;
            dgvRelatorios.Size = new Size(900, 220);
            dgvRelatorios.TabIndex = 5;
            // 
            // FrmRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(dgvRelatorios);
            Controls.Add(pnlValorTotal);
            Controls.Add(pnlConcluidas);
            Controls.Add(pnlEmAndamento);
            Controls.Add(pnlPendentes);
            Controls.Add(pnlTotalOS);
            Name = "FrmRelatorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatórios do Sistema";
            pnlTotalOS.ResumeLayout(false);
            pnlTotalOS.PerformLayout();
            pnlPendentes.ResumeLayout(false);
            pnlPendentes.PerformLayout();
            pnlEmAndamento.ResumeLayout(false);
            pnlEmAndamento.PerformLayout();
            pnlConcluidas.ResumeLayout(false);
            pnlConcluidas.PerformLayout();
            pnlValorTotal.ResumeLayout(false);
            pnlValorTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTotalOS;
        private Label lblTotalOS;
        private Label lblTituloTotal;
        private Panel pnlPendentes;
        private Label lblTituloPendentes;
        private Label lblPendentes;
        private Panel pnlEmAndamento;
        private Label lblEmAndamento;
        private Label lblTituloAndamento;
        private Panel pnlConcluidas;
        private Label lblConcluidas;
        private Label lblTituloConcluidas;
        private Panel pnlValorTotal;
        private Label lblValorTotal;
        private Label lblTituloValorTotal;
        private DataGridView dgvRelatorios;
    }
}