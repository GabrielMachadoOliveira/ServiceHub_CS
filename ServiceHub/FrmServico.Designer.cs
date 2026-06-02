namespace ServiceHub
{
    partial class FrmServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServico));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            checkBox1 = new CheckBox();
            nudPreco = new NumericUpDown();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 72);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 18);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 113);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 10;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 158);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 18);
            label3.TabIndex = 11;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 201);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 18);
            label4.TabIndex = 12;
            label4.Text = "Preço";
            // 
            // txtId
            // 
            txtId.Location = new Point(130, 65);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(49, 25);
            txtId.TabIndex = 13;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(130, 110);
            txtNome.Margin = new Padding(5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(233, 25);
            txtNome.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(130, 155);
            txtDescricao.Margin = new Padding(5);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(400, 25);
            txtDescricao.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(404, 202);
            checkBox1.Margin = new Padding(5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 22);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Descontinuado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // nudPreco
            // 
            nudPreco.Location = new Point(130, 201);
            nudPreco.Margin = new Padding(5);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(154, 25);
            nudPreco.TabIndex = 2;
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
            btnAdicionar.Location = new Point(58, 283);
            btnAdicionar.Margin = new Padding(5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(95, 61);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
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
            btnEditar.Location = new Point(268, 283);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(95, 61);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
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
            btnPesquisar.Location = new Point(163, 283);
            btnPesquisar.Margin = new Padding(5);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(95, 61);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.Click += btnPesquisar_Click;
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
            btnExcluir.Location = new Point(373, 283);
            btnExcluir.Margin = new Padding(5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(95, 61);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
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
            btnCancelar.Location = new Point(478, 283);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 61);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmServico
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 458);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(nudPreco);
            Controls.Add(checkBox1);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Constantia", 11F);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(5);
            Name = "FrmServico";
            Text = "FrmServico";
            Load += FrmServico_Load;
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private CheckBox checkBox1;
        private NumericUpDown nudPreco;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnCancelar;
    }
}