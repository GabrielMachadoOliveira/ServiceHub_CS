namespace ServiceHub
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCodBarras = new TextBox();
            txtDescricao = new TextBox();
            nudValorUnit = new NumericUpDown();
            nudEstoqueMinimo = new NumericUpDown();
            txtUnidadeVenda = new TextBox();
            cmbCategoria = new ComboBox();
            btnBuscar = new Button();
            label7 = new Label();
            nudClasseDesconto = new NumericUpDown();
            pictureBox1 = new PictureBox();
            btnCarregar = new Button();
            checkBox1 = new CheckBox();
            dgvProduto = new DataGridView();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)nudValorUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 47);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "CodBarras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 76);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 106);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 134);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 167);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Estoque Mínimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 106);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 6;
            label6.Text = "Unidade Venda";
            // 
            // txtCodBarras
            // 
            txtCodBarras.ForeColor = SystemColors.WindowFrame;
            txtCodBarras.Location = new Point(89, 44);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.PlaceholderText = "Código de barras";
            txtCodBarras.Size = new Size(227, 23);
            txtCodBarras.TabIndex = 7;
            // 
            // txtDescricao
            // 
            txtDescricao.ForeColor = SystemColors.WindowFrame;
            txtDescricao.Location = new Point(89, 73);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.Size = new Size(381, 23);
            txtDescricao.TabIndex = 8;
            // 
            // nudValorUnit
            // 
            nudValorUnit.Location = new Point(89, 104);
            nudValorUnit.Name = "nudValorUnit";
            nudValorUnit.Size = new Size(120, 23);
            nudValorUnit.TabIndex = 10;
            // 
            // nudEstoqueMinimo
            // 
            nudEstoqueMinimo.Location = new Point(125, 165);
            nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            nudEstoqueMinimo.Size = new Size(120, 23);
            nudEstoqueMinimo.TabIndex = 10;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.ForeColor = SystemColors.WindowFrame;
            txtUnidadeVenda.Location = new Point(322, 103);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PlaceholderText = "Unid. Venda";
            txtUnidadeVenda.Size = new Size(148, 23);
            txtUnidadeVenda.TabIndex = 11;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(89, 133);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(381, 23);
            cmbCategoria.TabIndex = 12;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(357, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(113, 50);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "    &Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(273, 167);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 15;
            label7.Text = "Classe Desconto";
            // 
            // nudClasseDesconto
            // 
            nudClasseDesconto.Location = new Point(372, 165);
            nudClasseDesconto.Name = "nudClasseDesconto";
            nudClasseDesconto.Size = new Size(98, 23);
            nudClasseDesconto.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(489, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 157);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnCarregar
            // 
            btnCarregar.Image = (Image)resources.GetObject("btnCarregar.Image");
            btnCarregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarregar.Location = new Point(489, 175);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(149, 46);
            btnCarregar.TabIndex = 14;
            btnCarregar.Text = "        Carregar Imagem";
            btnCarregar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(322, 202);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 19);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Descontinuado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dgvProduto
            // 
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Location = new Point(12, 306);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.Size = new Size(693, 183);
            dgvProduto.TabIndex = 18;
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
            btnCancelar.Location = new Point(511, 237);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 61);
            btnCancelar.TabIndex = 63;
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
            btnExcluir.Location = new Point(375, 237);
            btnExcluir.Margin = new Padding(5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(95, 61);
            btnExcluir.TabIndex = 62;
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
            btnEditar.Location = new Point(240, 237);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(95, 61);
            btnEditar.TabIndex = 61;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Red;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Constantia", 11F);
            btnAdd.ForeColor = Color.LimeGreen;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(91, 237);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 61);
            btnAdd.TabIndex = 60;
            btnAdd.Text = "&Adicionar";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 501);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdd);
            Controls.Add(dgvProduto);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(btnCarregar);
            Controls.Add(btnBuscar);
            Controls.Add(cmbCategoria);
            Controls.Add(txtUnidadeVenda);
            Controls.Add(nudEstoqueMinimo);
            Controls.Add(nudClasseDesconto);
            Controls.Add(nudValorUnit);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodBarras);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmCadastrarProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)nudValorUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCodBarras;
        private TextBox txtDescricao;
        private NumericUpDown nudValorUnit;
        private NumericUpDown nudEstoqueMinimo;
        private TextBox txtUnidadeVenda;
        private ComboBox cmbCategoria;
        private Button btnBuscar;
        private Label label7;
        private NumericUpDown nudClasseDesconto;
        private PictureBox pictureBox1;
        private Button btnCarregar;
        private CheckBox checkBox1;
        private DataGridView dgvProduto;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnAdd;
    }
}