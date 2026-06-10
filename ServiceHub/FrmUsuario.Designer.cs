namespace ServiceHub
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            btnPesquisar = new Button();
            txtBuscar = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            Nome = new Label();
            ID = new Label();
            dgvUsuarios = new DataGridView();
            Email = new Label();
            Senha = new Label();
            Nivel = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            cmbNivel = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
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
            btnCancelar.Location = new Point(553, 196);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 61);
            btnCancelar.TabIndex = 59;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            btnExcluir.Location = new Point(417, 196);
            btnExcluir.Margin = new Padding(5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(95, 61);
            btnExcluir.TabIndex = 58;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
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
            btnEditar.Location = new Point(282, 196);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(95, 61);
            btnEditar.TabIndex = 57;
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
            btnAdicionar.ForeColor = Color.LimeGreen;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.Location = new Point(133, 196);
            btnAdicionar.Margin = new Padding(5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(95, 61);
            btnAdicionar.TabIndex = 56;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
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
            btnPesquisar.Location = new Point(580, 154);
            btnPesquisar.Margin = new Padding(5);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(111, 38);
            btnPesquisar.TabIndex = 55;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.ForeColor = SystemColors.WindowFrame;
            txtBuscar.Location = new Point(88, 163);
            txtBuscar.Margin = new Padding(5);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Categoria";
            txtBuscar.Size = new Size(482, 23);
            txtBuscar.TabIndex = 47;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(161, 30);
            txtNome.Margin = new Padding(5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(386, 23);
            txtNome.TabIndex = 48;
            // 
            // txtId
            // 
            txtId.Location = new Point(88, 30);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 53;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(161, 10);
            Nome.Margin = new Padding(5, 0, 5, 0);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 51;
            Nome.Text = "Nome";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(88, 10);
            ID.Margin = new Padding(5, 0, 5, 0);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 50;
            ID.Text = "ID";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(88, 265);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(600, 156);
            dgvUsuarios.TabIndex = 60;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(88, 74);
            Email.Margin = new Padding(5, 0, 5, 0);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 50;
            Email.Text = "Email";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(417, 74);
            Senha.Margin = new Padding(5, 0, 5, 0);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 50;
            Senha.Text = "Senha";
            // 
            // Nivel
            // 
            Nivel.AutoSize = true;
            Nivel.Location = new Point(567, 10);
            Nivel.Margin = new Padding(5, 0, 5, 0);
            Nivel.Name = "Nivel";
            Nivel.Size = new Size(34, 15);
            Nivel.TabIndex = 50;
            Nivel.Text = "Nivel";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 23);
            txtEmail.TabIndex = 61;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(417, 92);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(278, 23);
            txtSenha.TabIndex = 61;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(567, 30);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(121, 23);
            cmbNivel.TabIndex = 62;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbNivel);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtBuscar);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(Nome);
            Controls.Add(Nivel);
            Controls.Add(Senha);
            Controls.Add(Email);
            Controls.Add(ID);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnAdicionar;
        private Button btnPesquisar;
        private TextBox txtBuscar;
        private TextBox txtNome;
        private TextBox txtId;
        private Label Nome;
        private Label ID;
        private DataGridView dgvUsuarios;
        private Label Email;
        private Label Senha;
        private Label Nivel;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private ComboBox cmbNivel;
    }
}