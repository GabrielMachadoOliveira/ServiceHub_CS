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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            numericUpDown3 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(89, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "Código de barras";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(89, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 23);
            textBox2.TabIndex = 8;
            textBox2.Text = "Descrição";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(89, 104);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(125, 165);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.WindowFrame;
            textBox4.Location = new Point(322, 103);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(148, 23);
            textBox4.TabIndex = 11;
            textBox4.Text = "Unid. Venda";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(381, 23);
            comboBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(357, 17);
            button1.Name = "button1";
            button1.Size = new Size(113, 50);
            button1.TabIndex = 13;
            button1.Text = "    &Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(125, 256);
            button2.Name = "button2";
            button2.Size = new Size(127, 44);
            button2.TabIndex = 14;
            button2.Text = "    &Salvar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(273, 256);
            button3.Name = "button3";
            button3.Size = new Size(127, 44);
            button3.TabIndex = 14;
            button3.Text = "    &Editar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(428, 256);
            button4.Name = "button4";
            button4.Size = new Size(127, 44);
            button4.TabIndex = 14;
            button4.Text = "     &Cancelar";
            button4.UseVisualStyleBackColor = true;
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
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(372, 165);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(98, 23);
            numericUpDown3.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(489, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 157);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(489, 175);
            button5.Name = "button5";
            button5.Size = new Size(149, 46);
            button5.TabIndex = 14;
            button5.Text = "        Carregar Imagem";
            button5.UseVisualStyleBackColor = true;
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
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 355);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmCadastrarProduto";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private NumericUpDown numericUpDown3;
        private PictureBox pictureBox1;
        private Button button5;
        private CheckBox checkBox1;
    }
}