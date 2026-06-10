namespace ServiceHub
{
    partial class FrmNivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNivel));
            dgvCategorias = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtSigla = new TextBox();
            txtBuscar = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            Sigla = new Label();
            Nome = new Label();
            ID = new Label();
            btnPesquisar = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvCategorias.Location = new Point(116, 273);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(568, 156);
            dgvCategorias.TabIndex = 41;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.Width = 390;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Sigla";
            Column3.Name = "Column3";
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(586, 162);
            txtSigla.Margin = new Padding(5);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(98, 23);
            txtSigla.TabIndex = 31;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(119, 95);
            txtBuscar.Margin = new Padding(5);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(457, 23);
            txtBuscar.TabIndex = 29;
            txtBuscar.Text = "Buscar Categoria";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(176, 162);
            txtNome.Margin = new Padding(5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(400, 23);
            txtNome.TabIndex = 30;
            // 
            // txtId
            // 
            txtId.Location = new Point(119, 162);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 40;
            // 
            // Sigla
            // 
            Sigla.AutoSize = true;
            Sigla.Location = new Point(586, 142);
            Sigla.Margin = new Padding(5, 0, 5, 0);
            Sigla.Name = "Sigla";
            Sigla.Size = new Size(32, 15);
            Sigla.TabIndex = 39;
            Sigla.Text = "Sigla";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(176, 142);
            Nome.Margin = new Padding(5, 0, 5, 0);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 38;
            Nome.Text = "Nome";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(119, 142);
            ID.Margin = new Padding(5, 0, 5, 0);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 37;
            ID.Text = "ID";
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Constantia", 11F);
            btnPesquisar.ForeColor = Color.FromArgb(0, 192, 192);
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.Location = new Point(586, 86);
            btnPesquisar.Margin = new Padding(5);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(111, 38);
            btnPesquisar.TabIndex = 42;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Constantia", 11F);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(563, 195);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 61);
            btnCancelar.TabIndex = 46;
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
            btnExcluir.ForeColor = Color.FromArgb(192, 0, 0);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(427, 195);
            btnExcluir.Margin = new Padding(5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(95, 61);
            btnExcluir.TabIndex = 45;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Constantia", 11F);
            btnEditar.ForeColor = Color.Gold;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.TopCenter;
            btnEditar.Location = new Point(292, 195);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(95, 61);
            btnEditar.TabIndex = 44;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Constantia", 11F);
            btnAdicionar.ForeColor = Color.LimeGreen;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.Location = new Point(143, 195);
            btnAdicionar.Margin = new Padding(5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(95, 61);
            btnAdicionar.TabIndex = 43;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(280, 24);
            label1.Name = "label1";
            label1.Size = new Size(228, 37);
            label1.TabIndex = 47;
            label1.Text = "Cadastro de Nivel";
            label1.Click += label1_Click;
            // 
            // FrmNivel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(btnPesquisar);
            Controls.Add(dgvCategorias);
            Controls.Add(txtSigla);
            Controls.Add(txtBuscar);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(Sigla);
            Controls.Add(Nome);
            Controls.Add(ID);
            Name = "FrmNivel";
            Text = "FrmNivel";
            Load += FrmNivel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategorias;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txtSigla;
        private TextBox txtBuscar;
        private TextBox txtNome;
        private TextBox txtId;
        private Label Sigla;
        private Label Nome;
        private Label ID;
        private Button btnPesquisar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnAdicionar;
        private Label label1;
    }
}