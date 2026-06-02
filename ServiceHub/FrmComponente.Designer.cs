namespace ServiceHub
{
    partial class FrmComponente
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dgvServicos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnPreço = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnDescontinuado = new DataGridViewCheckBoxColumn();
            dgvUsuarios = new DataGridView();
            clnIdUsuarios = new DataGridViewTextBoxColumn();
            clnNomeUsuarios = new DataGridViewTextBoxColumn();
            clnEmailUsuarios = new DataGridViewTextBoxColumn();
            dgvSolicitacoes = new DataGridView();
            clnIdSolicitações = new DataGridViewTextBoxColumn();
            clnDescriçãoSolicitações = new DataGridViewTextBoxColumn();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitacoes).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(215, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(145, 169);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(27, 176);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(108, 175);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 108);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 3;
            label1.Text = "Digite o(s) número(s)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 29);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Operação";
            // 
            // dgvServicos
            // 
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnPreço, clnDescricao, clnDescontinuado });
            dgvServicos.Location = new Point(27, 216);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.Size = new Size(689, 154);
            dgvServicos.TabIndex = 7;
            dgvServicos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "Id";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 200;
            // 
            // clnPreço
            // 
            clnPreço.Frozen = true;
            clnPreço.HeaderText = "Preço";
            clnPreço.Name = "clnPreço";
            clnPreço.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 206;
            // 
            // clnDescontinuado
            // 
            clnDescontinuado.HeaderText = "Descontinuado";
            clnDescontinuado.Name = "clnDescontinuado";
            clnDescontinuado.ReadOnly = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnIdUsuarios, clnNomeUsuarios, clnEmailUsuarios });
            dgvUsuarios.Location = new Point(27, 387);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(584, 96);
            dgvUsuarios.TabIndex = 8;
            dgvUsuarios.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // clnIdUsuarios
            // 
            clnIdUsuarios.Frozen = true;
            clnIdUsuarios.HeaderText = "ID";
            clnIdUsuarios.Name = "clnIdUsuarios";
            clnIdUsuarios.ReadOnly = true;
            clnIdUsuarios.Width = 40;
            // 
            // clnNomeUsuarios
            // 
            clnNomeUsuarios.Frozen = true;
            clnNomeUsuarios.HeaderText = "Nome";
            clnNomeUsuarios.Name = "clnNomeUsuarios";
            clnNomeUsuarios.ReadOnly = true;
            clnNomeUsuarios.Width = 200;
            // 
            // clnEmailUsuarios
            // 
            clnEmailUsuarios.Frozen = true;
            clnEmailUsuarios.HeaderText = "Email";
            clnEmailUsuarios.Name = "clnEmailUsuarios";
            clnEmailUsuarios.ReadOnly = true;
            clnEmailUsuarios.Width = 300;
            // 
            // dgvSolicitacoes
            // 
            dgvSolicitacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitacoes.Columns.AddRange(new DataGridViewColumn[] { clnIdSolicitações, clnDescriçãoSolicitações });
            dgvSolicitacoes.Location = new Point(396, 30);
            dgvSolicitacoes.Name = "dgvSolicitacoes";
            dgvSolicitacoes.Size = new Size(320, 108);
            dgvSolicitacoes.TabIndex = 9;
            // 
            // clnIdSolicitações
            // 
            clnIdSolicitações.Frozen = true;
            clnIdSolicitações.HeaderText = "ID";
            clnIdSolicitações.Name = "clnIdSolicitações";
            clnIdSolicitações.ReadOnly = true;
            clnIdSolicitações.Width = 40;
            // 
            // clnDescriçãoSolicitações
            // 
            clnDescriçãoSolicitações.Frozen = true;
            clnDescriçãoSolicitações.HeaderText = "Descrição";
            clnDescriçãoSolicitações.Name = "clnDescriçãoSolicitações";
            clnDescriçãoSolicitações.ReadOnly = true;
            clnDescriçãoSolicitações.Width = 200;
            // 
            // button3
            // 
            button3.Location = new Point(481, 154);
            button3.Name = "button3";
            button3.Size = new Size(140, 23);
            button3.TabIndex = 10;
            button3.Text = "Ver Solicitações";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmComponente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 614);
            Controls.Add(button3);
            Controls.Add(dgvSolicitacoes);
            Controls.Add(dgvUsuarios);
            Controls.Add(dgvServicos);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "FrmComponente";
            Text = "FrmComponente";
            Load += FrmComponente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label2;
        private DataGridView dgvServicos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnPreço;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewCheckBoxColumn clnDescontinuado;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnIdUsuarios;
        private DataGridViewTextBoxColumn clnNomeUsuarios;
        private DataGridViewTextBoxColumn clnEmailUsuarios;
        private DataGridView dgvSolicitacoes;
        private DataGridViewTextBoxColumn clnIdSolicitações;
        private DataGridViewTextBoxColumn clnDescriçãoSolicitações;
        private Button button3;
    }
}