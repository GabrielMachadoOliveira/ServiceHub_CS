namespace ServiceHub
{
    partial class FrmListaClientes
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
            dgvClientes = new DataGridView();
            cinSeq = new DataGridViewTextBoxColumn();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { cinSeq, clnId, clnNome, clnCpf, clnEmail, clnTelefone, clnAtivo });
            dgvClientes.Location = new Point(12, 118);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(727, 280);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // cinSeq
            // 
            cinSeq.Frozen = true;
            cinSeq.HeaderText = "#";
            cinSeq.Name = "cinSeq";
            cinSeq.ReadOnly = true;
            cinSeq.Width = 40;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 80;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 200;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 168;
            // 
            // clnTelefone
            // 
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 40;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(679, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Buscar";
            label1.Click += label1_Click;
            // 
            // FrmListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dgvClientes);
            Name = "FrmListaClientes";
            Text = "FrmListaClientes";
            Load += FrmListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn cinSeq;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}