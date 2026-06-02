using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using ServiceHubClass;

namespace ServiceHub
{
    public partial class FrmComponente : Form
    {
        public FrmComponente()
        {
            InitializeComponent();
        }

        private void FrmComponente_Load(object sender, EventArgs e)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from servicos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvServicos.Rows.Add();
                int linha = dgvServicos.RowCount - 1;
                dgvServicos.Rows[linha].Cells[0].Value = dr.GetInt32(0);
                dgvServicos.Rows[linha].Cells[1].Value = dr.GetString(1);
                dgvServicos.Rows[linha].Cells[2].Value = dr.GetString(2);
                dgvServicos.Rows[linha].Cells[3].Value = dr.GetDouble(3);
                dgvServicos.Rows[linha].Cells[4].Value = dr.GetBoolean(4);
            }
            dr.Close(); // Fechando o dataReader

            cmd.CommandText = "select id, nome, email from usuarios where ativo = 1";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvUsuarios.Rows.Add();
                int linha = dgvUsuarios.RowCount - 1;
                dgvUsuarios.Rows[linha].Cells[0].Value = dr.GetInt32(0);
                dgvUsuarios.Rows[linha].Cells[1].Value = dr.GetString(1);
                dgvUsuarios.Rows[linha].Cells[2].Value = dr.GetString(2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                double numero1 = 0;
                numero1 = double.Parse(textBox1.Text);
                double numero2 = 0;

                numero2 = comboBox1.SelectedIndex < 5 ? double.Parse(textBox2.Text) : 0;
                switch (comboBox1.SelectedIndex)

                {
                    case 0: //multiplicação
                        listBox1.Items.Add("------------------Multiplicação------------------");
                        listBox1.Items.Add($"{numero1} x {numero2} = {numero1 * numero2}");
                        break;
                    case 1: //Divisão
                        listBox1.Items.Add("------------------Divisão------------------");
                        listBox1.Items.Add($"{numero1} / {numero2} = {numero1 / numero2}");
                        break;
                    case 2: //Adição
                        listBox1.Items.Add("------------------Adição------------------");
                        listBox1.Items.Add($"{numero1} + {numero2} = {numero1 + numero2}");
                        break;
                    case 3: //Subtração
                        listBox1.Items.Add("------------------Subtração------------------");
                        listBox1.Items.Add($"{numero1} - {numero2} = {numero1 - numero2}");
                        break;
                    case 4: //exponenciação
                        listBox1.Items.Add("------------------exponenciação------------------");
                        listBox1.Items.Add(Math.Pow(numero1, numero2));
                        break;
                    case 5: //tabuada
                        listBox1.Items.Add("------------------tabuada------------------");
                        for (int i = 1; i < 11; i++)
                        {
                            listBox1.Items.Add($"{numero1} x {i} = {numero1 * (i)}");
                        }
                        break;
                    case 6: //radiciação
                        listBox1.Items.Add("------------------radiciação------------------");
                        listBox1.Items.Add(Math.Sqrt(numero1));
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(comboBox1.SelectedIndex.ToString());
            if (comboBox1.SelectedIndex < 5)
            {
                label1.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox1.Focus();
            }
            else
            {
                label1.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox1.Focus();


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmcomponente_Load(object sender, EventArgs e)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from servicos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr.GetString(1));

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvSolicitacoes.Rows.Clear();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, descricao_problema from solicitacoes";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvSolicitacoes.Rows.Add();
                int linha = dgvSolicitacoes.RowCount - 1;
                //MessageBox.Show(linha.ToString());
                dgvSolicitacoes.Rows[linha].Cells[0].Value = dr.GetInt32(0);
                dgvSolicitacoes.Rows[linha].Cells[1].Value = dr.GetString(1);
            }
        }
    }
}
