namespace ServiceHub
{
    partial class FrmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            txtSigla = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            Sigla = new Label();
            Nome = new Label();
            ID = new Label();
            txtBuscar = new TextBox();
            dgvCategorias = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Constantia", 11F);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(452, 84);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 87);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.Red;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Constantia", 11F);
            btnExcluir.ForeColor = SystemColors.ActiveCaptionText;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(347, 84);
            btnExcluir.Margin = new Padding(5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(97, 87);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Constantia", 11F);
            btnPesquisar.ForeColor = SystemColors.ActiveCaptionText;
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.Location = new Point(137, 84);
            btnPesquisar.Margin = new Padding(5);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(97, 87);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Constantia", 11F);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.TopCenter;
            btnEditar.Location = new Point(242, 84);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 87);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Constantia", 11F);
            btnAdicionar.ForeColor = SystemColors.ActiveCaptionText;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.Location = new Point(32, 84);
            btnAdicionar.Margin = new Padding(5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(97, 87);
            btnAdicionar.TabIndex = 18;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(482, 51);
            txtSigla.Margin = new Padding(5);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(98, 23);
            txtSigla.TabIndex = 15;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(72, 51);
            txtNome.Margin = new Padding(5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(400, 23);
            txtNome.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Location = new Point(15, 51);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 27;
            // 
            // Sigla
            // 
            Sigla.AutoSize = true;
            Sigla.Location = new Point(482, 31);
            Sigla.Margin = new Padding(5, 0, 5, 0);
            Sigla.Name = "Sigla";
            Sigla.Size = new Size(32, 15);
            Sigla.TabIndex = 25;
            Sigla.Text = "Sigla";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(72, 31);
            Nome.Margin = new Padding(5, 0, 5, 0);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 24;
            Nome.Text = "Nome";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(15, 31);
            ID.Margin = new Padding(5, 0, 5, 0);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 23;
            ID.Text = "ID";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(14, 190);
            txtBuscar.Margin = new Padding(5);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(566, 23);
            txtBuscar.TabIndex = 14;
            txtBuscar.Text = "Buscar Categoria";
            txtBuscar.TextChanged += textBox1_TextChanged;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvCategorias.Location = new Point(12, 221);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(568, 217);
            dgvCategorias.TabIndex = 28;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 390;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Sigla";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(dgvCategorias);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtSigla);
            Controls.Add(txtBuscar);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(Sigla);
            Controls.Add(Nome);
            Controls.Add(ID);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnAdicionar;
        private TextBox txtSigla;
        private TextBox txtNome;
        private TextBox txtId;
        private Label Sigla;
        private Label Nome;
        private Label ID;
        private TextBox txtBuscar;
        private DataGridView dgvCategorias;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}